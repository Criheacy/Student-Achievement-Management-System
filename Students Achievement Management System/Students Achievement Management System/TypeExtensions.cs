using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Achievement_Management_System
{
    public static class TypeExtensions
    {
        public static readonly char[] BlankSpaceChar = new char[] { (char)0x00, (char)0x01, (char)0x02, (char)0x03, (char)0x04, (char)0x05,
        (char)0x06, (char)0x07, (char)0x08, (char)0x09, (char)0x0a, (char)0x0b, (char)0x0c, (char)0x0d, (char)0x0e, (char)0x0f,
        (char)0x10, (char)0x11, (char)0x12, (char)0x13, (char)0x14, (char)0x15, (char)0x16, (char)0x17, (char)0x18, (char)0x19, (char)0x20,
        (char)0x1a, (char)0x1b, (char)0x1c, (char)0x1d, (char)0x1e, (char)0x1f, (char)0x7f, (char)0x85, (char)0x2028, (char)0x2029 };
        public static bool IsNullOrBlank(this string s)
        {
            if (s == null || s.Trim(BlankSpaceChar).Length == 0)
            {
                return true;
            }
            return false;
        }
        public static bool NotNullOrBlank(this string s)
        {
            if (s == null || s.Trim(BlankSpaceChar).Length == 0)
            {
                return false;
            }
            return true;
        }

        public static ListViewItem FindItemWithTag
            (this ListView theListView, object t)
        {
            foreach (ListViewItem theItem in theListView.Items)
            {
                if (theItem.Tag == t)
                    return theItem;
            }
            return null;
        }
    }
}
