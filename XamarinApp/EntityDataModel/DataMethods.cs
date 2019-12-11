using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDataModel
{
    public class DataMethods
    {
        public List<StuddyBuddy> GetStuddyBuddies()
        {
            using (var db = new DataContext())
            {

            }
                return new List<StuddyBuddy>();
        }
    }
}
