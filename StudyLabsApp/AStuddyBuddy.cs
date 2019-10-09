using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace StudyLabsApp
{
    class AStuddyBuddy
    {
        public String nickname;
        public String link;
        public String faculty;
        public String studies;
        public AStuddyBuddy(String nickname, String link, String faculty, String studies)
        {
            this.nickname = nickname;
            this.link = link;
            this.faculty = faculty;
            this.studies = studies;
        }
        public String Get_nickname()
        {
            return nickname;
        }
        public void Set_nickname(String nickname)
        {
            this.nickname = nickname;
        }
        public String Get_link()
        {
            return link;
        }
        public void Set_link(String link)
        {
            this.link = link;
        }
        public String Get_faculty()
        {
            return faculty;
        }
        public void Set_faculty(String faculty)
        {
            this.faculty = faculty;
        }
        public String Get_studies()
        {
            return studies;
        }
        public void Set_studies(String studies)
        {
            this.studies = studies;
        }
    }
}
