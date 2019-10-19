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
        PhD
    }
    public class AStuddyBuddy : IComparable
    {
        public string Nickname { get; set; }
        public string Link { get; set; }
        public string Faculty { get; set; }
        public string Studies { get; set; }
        public int Status { get; set; }
        public int Points { get; set; }

        public AStuddyBuddy(string nickname, string link, string faculty, string studies)
        {
            this.Nickname = nickname;
            this.Link = link;
            this.Faculty = faculty;
            this.Studies = studies;
            this.Status = 1;
            this.Points = 0;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is AStuddyBuddy))
            {
                throw new ArgumentException("Object is not AStuddyBuddy");
            }
            else
            {
                AStuddyBuddy other = obj as AStuddyBuddy;
                return this.CompareTo(other);
            }
        }
    }
}
