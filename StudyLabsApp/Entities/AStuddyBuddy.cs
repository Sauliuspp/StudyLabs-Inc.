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
        public string Nickname { get; set; }
        public string Link { get; set; }
        public string Faculty { get; set; }
        public string Studies { get; set; }
        
        public AStuddyBuddy(string nickname, string link, string faculty, string studies)
        {
            this.Nickname = nickname;
            this.Link = link;
            this.Faculty = faculty;
            this.Studies = studies;
        }
    }
}
