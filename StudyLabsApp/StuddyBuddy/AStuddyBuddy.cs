using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace StudyLabsApp
{
    //A list of ranks for studdybuddies
   public enum Level
    {
        Starter = 1,
        Private,
        Trainee,
        TryHard,
        TeachersPet,
        Captain,
        Magician,
        MrKnowItAll,
        Genius,
        PhD,
    }
    public class AStuddyBuddy
    {
        Level Status;
        public Level EnumProperty {
            get
            {
                return Status;
            }
            set
            {
                Status = value;
            }
        }
        public string Nickname { get; set; }
        public string Link { get; set; }
        public string Faculty { get; set; }
        public string Studies { get; set; }
        
        public AStuddyBuddy(string nickname, string link, string faculty, string studies, Level status)
        {
            this.Nickname = nickname;
            this.Link = link;
            this.Faculty = faculty;
            this.Studies = studies;
            this.Status = status;
        }
    }
}
