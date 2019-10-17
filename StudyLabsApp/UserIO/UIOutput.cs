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
        private static IEnumerable<DataRow> tableRows;

        public static void DisplayData(DataTable table, ListView listView, string comboBoxFaculty, string comboBoxStudies)
        {
            tableRows = from DataRow r in table.Rows
                           select r;

            List<DataRow> rows = tableRows.ToList();

            foreach (DataRow row in rows)
            {
                if (row.Field<string>("Faculty") == comboBoxFaculty &&
                    row.Field<string>("Studies") == comboBoxStudies)
                {
                    ListViewItem item = new ListViewItem(row.Field<string>("Nickname"));
                    for (int j = 2; j < table.Columns.Count; j++)
                    {
                        item.SubItems.Add(row[j].ToString());
                    }
                    listView.Items.Add(item);
                }
            }
        }
    }
}
