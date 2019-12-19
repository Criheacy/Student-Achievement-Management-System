using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Students_Achievement_Management_System
{
    public class ListViewCell
    {
        /// <summary>
        /// 单元格所在的行。
        /// </summary>
        public ListViewItem Item { get; set; }
        /// <summary>
        /// Item 的 Index 值会变成 -1，暂时未找到原因，用这个代替。
        /// </summary>
        public int ItemIndex { get; set; }
        /// <summary>
        /// 单元格所在的列。
        /// </summary>
        public ColumnHeader Column { get; set; }
    }

    public class ListViewCellLocator
    {
        [DllImport("user32.dll", EntryPoint = "GetScrollPos")]
        public static extern int GetScrollPos(int hwnd, int nBar);
        public static ListViewCell GetCell(ListView listView, int x, int y)
        {
            ListViewCell cell = new ListViewCell();

            // 获得单元格所在的行。
            cell.Item = listView.GetItemAt(x, y);
            if (cell.Item == null)
            {
                return null;
            }
            cell.ItemIndex = cell.Item.Index; // 现在 Item.Index 还能用

            // 根据各列宽度，获得单元格所在的列，以及 Bounds。
            int currentX = cell.Item.GetBounds(ItemBoundsPortion.Entire).Left; // 依次循环各列，表示各列的起点值
            // int scrollLeft = GetScrollPos(listView.Handle.ToInt32(), 0); // 可能出现了横向滚动条，左边隐藏起来的宽度

            // MessageBox.Show(("Hided = " + scrollLeft.ToString() + " X = " + currentX.ToString()),
            //     "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                if (x >= currentX &&
                    x < currentX + listView.Columns[i].Width)
                {
                    cell.Column = listView.Columns[i]; // 列找到了
                    break;
                }
                currentX += listView.Columns[i].Width;
            }

            if (cell.Column == null)
            {
                return null;
            }
            return cell;
        }
    }
}
