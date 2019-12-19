using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Achievement_Management_System
{
    public class ListViewExtendClass : System.Windows.Forms.ListView
    {
        public class ListViewColumnSorter : System.Collections.IComparer
        {
            private int ColumnToSort; // 指定按照哪个列排序
            private System.Windows.Forms.SortOrder OrderOfSort; // 指定排序的方式
            private System.Collections.CaseInsensitiveComparer ObjectCompare;
            // 声明CaseInsensitiveComparer类对象
            public ListViewColumnSorter(int sortedColumn)
            {
                ColumnToSort = sortedColumn;
                OrderOfSort = System.Windows.Forms.SortOrder.None;
                ObjectCompare = new System.Collections.CaseInsensitiveComparer();
            }
            public ListViewColumnSorter(int sortedColumn, SortOrder theOrder)
            {
                ColumnToSort = sortedColumn;
                OrderOfSort = theOrder;
                ObjectCompare = new System.Collections.CaseInsensitiveComparer();
            }
            /// <summary>
            /// 重写IComparer接口.
            /// </summary>
            /// <param name="x">要比较的第一个对象</param>
            /// <param name="y">要比较的第二个对象</param>
            /// <returns>比较的结果.如果相等返回0，如果x大于y返回1，如果x小于y返回-1</returns>
            public int Compare(object x, object y)
            {
                int compareResult;
                System.Windows.Forms.ListViewItem listviewX, listviewY;
                // 将比较对象转换为ListViewItem对象
                listviewX = (System.Windows.Forms.ListViewItem)x;
                listviewY = (System.Windows.Forms.ListViewItem)y;

                string xText = listviewX.SubItems[ColumnToSort].Text;
                string yText = listviewY.SubItems[ColumnToSort].Text;

                string xNum = xText.Split(' ')[0];
                string yNum = yText.Split(' ')[0];

                int xInt, yInt;
                double xDouble, yDouble;
                if (int.TryParse(xNum, out xInt) && int.TryParse(yNum, out yInt)) //是否全为数字
                {
                    //比较数字
                    compareResult = CompareInt(xInt, yInt);
                }
                else if (double.TryParse(xNum, out xDouble) && double.TryParse(yNum, out yDouble)) //是否全为数字
                {
                    //比较数字
                    compareResult = CompareDouble(xDouble, yDouble);
                }
                else
                {
                    compareResult = (string.Compare((listviewX).SubItems[ColumnToSort].Text,
                        (listviewY).SubItems[ColumnToSort].Text));
                }
                // 根据上面的比较结果返回正确的比较结果
                if (OrderOfSort == System.Windows.Forms.SortOrder.Ascending)
                {
                    // 因为是正序排序，所以直接返回结果
                    return compareResult;
                }
                else if (OrderOfSort == System.Windows.Forms.SortOrder.Descending)
                {
                    // 如果是反序排序，所以要取负值再返回
                    return (-compareResult);
                }
                else
                {
                    // 不进行排序
                    return 0;
                }
            }
            private int CompareInt(int x, int y)
            {
                if (x > y) return 1;
                else if (x < y) return -1;
                else return 0;
            }
            private int CompareDouble(double x, double y)
            {
                if (x > y) return 1;
                else if (x < y) return -1;
                else return 0;
            }
            public int SortColumn
            {
                set
                {
                    ColumnToSort = value;
                }
                get
                {
                    return ColumnToSort;
                }
            }
            public System.Windows.Forms.SortOrder Order
            {
                set
                {
                    OrderOfSort = value;
                }
                get
                {
                    return OrderOfSort;
                }
            }
        }
    }
}
