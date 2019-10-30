using StudyLabsWeb.Models;
using StudyLabsWeb.Processors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace StuddyBuddyWeb.Processors
{
    public class AStuddyBuddyProcessor
    {
        public List<AStuddyBuddy> LoadData(string selectedFaculty)
        {
            DatabaseProcessor DBProcessor = new DatabaseProcessor();
            DataTable studdyBuddyInfo = DBProcessor.LoadData();

            List<AStuddyBuddy> studdyBuddyList = new List<AStuddyBuddy>();
            AStuddyBuddy studdyBuddy;

            foreach (DataRow row in studdyBuddyInfo.Rows)
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

            return studdyBuddyList;
        }
    }
}