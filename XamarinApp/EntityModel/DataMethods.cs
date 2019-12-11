using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class DataMethods
    {
        public void GetStuddyBuddies()
        {
            using (var dc = new DataModel())
            {
                var query = dc.StuddyBuddies
                            .Where(x => x.Points > 20)
                            .OrderByDescending(x => x.Points);
                
                //var query = from buddy in dc.StuddyBuddies
                //            where buddy.Points > 20
                //            orderby buddy.Points descending
                //            select buddy;
                
                foreach (var a in query)
                {
                    Console.WriteLine("asdafgdfsda");
                    Console.WriteLine("asdfsdfsasds");
                    Console.WriteLine("asfdasfdadfgs");
                }
                return query.ToList();
            }
        }
        
    }
}
