using StudyLabsApp.DatabaseIO;
using StudyLabsApp.Resources;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyLabsApp.UserIO
{
    public class UIOutput
    {

        public static string workingDirectory = Environment.CurrentDirectory;
        public static string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

        public static ResXResourceReader Faculties = new ResXResourceReader(projectDirectory + @"\Resources\Faculties.resx");
        public static ResXResourceReader Studies = new ResXResourceReader(projectDirectory + @"\Resources\Faculties_and_studies.resx");

        private IEnumerable<DataRow> tableRows;

        public void DisplayData(DataTable table, ListView listView, string selectedFaculty, string selectedStudies)
        {
            tableRows = from DataRow r in table.Rows
                        select r;

            foreach (DataRow row in tableRows)
            {
                if (row.Field<string>("Faculty") == selectedFaculty &&
                    row.Field<string>("Studies") == selectedStudies)
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

        public void DisplayData(DataTable table, ListView listView, string selectedFaculty)
        {
            List<AStuddyBuddy> studdyBuddyList = new List<AStuddyBuddy>();
            AStuddyBuddy studdyBuddy;

            foreach (DataRow row in table.Rows)
            {
                if (row.Field<string>("Faculty") == selectedFaculty)
                {
                    studdyBuddy = new AStuddyBuddy(row.Field<string>("Nickname"),
                                               row.Field<string>("Facebook"),
                                               row.Field<string>("Faculty"),
                                               row.Field<string>("Studies"))
                    {
                        Status = row.Field<int>("Status"),
                        Points = row.Field<int>("Points")
                    };

                    studdyBuddyList.Add(studdyBuddy);
                }
            }

            studdyBuddyList.Sort();
            studdyBuddyList.Reverse();

            foreach (AStuddyBuddy buddy in studdyBuddyList)
            {
                addBuddiesToTable(listView, buddy, table);
            }
        }

        Action<ListView, AStuddyBuddy, DataTable> addBuddiesToTable = (listView, buddy, table) =>
        {
            ListViewItem item = new ListViewItem(buddy.Nickname);
            for (int j = 2; j < table.Columns.Count; j++)
            {
                item.SubItems.Add(buddy.Link);
                item.SubItems.Add(buddy.Faculty);
                item.SubItems.Add(buddy.Studies);
                item.SubItems.Add(Enum.GetName(typeof(Level), buddy.Status));
                item.SubItems.Add(buddy.Points.ToString());
            }
            listView.Items.Add(item);
        };

        public void ShowFaculties(ComboBox FacultyComboBox)
        {
            // Iterate through the resources and display the contents
            foreach (DictionaryEntry d in Faculties)
            {
                FacultyComboBox.Items.Add(d.Key.ToString());
            }
        }

        public void ShowStudies(ComboBox FacultyComboBox, ComboBox StudiesComboBox)
        {
            foreach (DictionaryEntry d in Studies)
            {
                int studiesValue = Int32.Parse(d.Value.ToString());

                if (studiesValue == FacultyComboBox.SelectedIndex)
                {
                    StudiesComboBox.Items.Add(d.Key.ToString());
                }
            }
        }

        public void ShowForumThreads(DataTable table, ListView listView, string faculty, string studies)
        {
            tableRows = from DataRow r in table.Rows
                        select r;

            foreach (DataRow row in tableRows)
            {
                if (row.Field<string>("Faculty") == faculty &&
                    row.Field<string>("Studies") == studies)
                {
                    ListViewItem item = new ListViewItem(row.Field<string>("Question"));
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        item.SubItems.Add(row[2].ToString());
                        item.SubItems.Add(row[5].ToString());
                        item.SubItems.Add(row[0].ToString());
                    }
                    listView.Items.Add(item);
                }
            }
        }

        public void ShowFilteredDiscussion(ListView listView, int QuestionId)
        {
            DatabaseProcessor dbProcessor = new DatabaseProcessor();
            DataTable discussionTable = dbProcessor.LoadFilteredDiscussion(QuestionId);

            tableRows = from DataRow r in discussionTable.Rows
                        select r;

            foreach (DataRow row in tableRows)
            {
                DateTime date = row.Field<DateTime>("Time");
                string time = date.ToString();

                ListViewItem item = new ListViewItem(time);
                for (int j = 0; j < discussionTable.Rows.Count; j++)
                {
                    item.SubItems.Add(row[0].ToString());
                    item.SubItems.Add(row[2].ToString());
                }
                listView.Items.Add(item);
            }
        }
    }
}
