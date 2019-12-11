using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Models
{
    public class StuddyBuddy
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string Faculty { get; set; }
        public string Studies { get; set; }
        public int Status { get; set; }
        public int Points { get; set; }
        public StuddyBuddy(string nickname, string password, string faculty, string studies, int status, int points)
        {
            this.Nickname = nickname;
            this.Password = password;
            this.Faculty = faculty;
            this.Studies = studies;
            this.Status = status;
            this.Points = points;
        }
    }
}
