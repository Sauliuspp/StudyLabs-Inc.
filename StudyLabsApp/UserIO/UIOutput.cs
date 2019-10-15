using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyLabsApp.UserIO
{
    public static class UIOutput
    {
        public static void DisplayData(DataTable table, ListView listView)
        {
            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row[1].ToString());
                for (int i = 2; i < table.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView.Items.Add(item);
            }
        }
    }
}
