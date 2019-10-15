using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace StudyLabsApp
{
    public class AStuddyBuddy
    {
        public String nickname { get; set; }
        public String link { get; set; }
        public String faculty { get; set; }
        public String studies { get; set; }
        public AStuddyBuddy(String nickname, String link, String faculty, String studies)
        {
            this.nickname = nickname;
            this.link = link;
            this.faculty = faculty;
            this.studies = studies;
        }
    }
}
