using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyZoo.Extensions
{
    static class HelperMethod
    {
        public static int GetSelectedRowIndex(DataGridView dw)
        {
            for (int i = 0; i < dw.RowCount; i++)
            {
                //If row is selected
                if (dw.Rows[i].Selected)
                {
                    return i;
                }

                //If cell is selected
                for (int x = 0; x < dw.ColumnCount; x++)
                {
                    if (dw[x, i].Selected)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
