using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLabsApp.ForumFiles
{
    public class ForumThread
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Author { get; set; }
        public DateTime Time { get; set; }
    }
}
