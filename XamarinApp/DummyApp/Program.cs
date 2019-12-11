using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;

namespace DummyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StuddyBuddy> buddyList = LoadStuddyBuddies();
            List<ForumThread> threadList = LoadForumThreads();

            //InnerJoin(buddyList, threadList);

            //GroupJoin(buddyList, threadList);

            //LeftOuterJoin(buddyList, threadList);

            //Group(buddyList, threadList);

            //Skip(buddyList, threadList);

            //Take(buddyList, threadList);

            Aggregate(buddyList, threadList);
            Console.ReadKey();
        }

        public static void InnerJoin(List<StuddyBuddy> buddyList, List<ForumThread> threadList)
        {
            var query = from buddies in buddyList
                        join threads in threadList on buddies.Nickname equals threads.Creator
                        select new { buddies.Nickname, buddies.Faculty, buddies.Studies, threads.Topic, threads.Description };

            //var query2 = buddyList.Join(threadList,
            //                            buddies => buddies.Nickname,
            //                            thread => thread.Creator,
            //                            (buddies, thread) => new { Nickname = buddies.Nickname, 
            //                                                        Faculty = buddies.Faculty,
            //                                                        Studies = buddies.Studies,
            //                                                        Topic = thread.Topic,
            //                                                        Description = thread.Description});

            foreach (var result in query)
            {
                Console.WriteLine(result.Nickname + "    " + result.Faculty + "    " + result.Topic + "    " + result.Description);
            }
            Console.WriteLine("results: " + query.Count());
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void GroupJoin(List<StuddyBuddy> buddyList, List<ForumThread> threadList)
        {
            var query = from buddies in buddyList
                        join threads in threadList on buddies.Nickname equals threads.Creator into result
                        select new { buddies.Nickname, buddies.Faculty, buddies.Studies};

            //var query2 = buddyList.GroupJoin(threadList,
            //                    buddy => buddy.Nickname,
            //                    thread => thread.Creator,
            //                    (buddy, thread) => new {
            //                                    Nickname = buddy.Nickname,
            //                                    Faculty = buddy.Faculty,
            //                                    Studies = buddy.Studies,
            //                                    Topic = thread,
            //                                    Description = thread});

            foreach (var result in query)
            {
                Console.WriteLine(result.Nickname + "    " + result.Faculty + "    " + result.Studies);
            }
            Console.WriteLine("results: " + query.Count());
            Console.WriteLine();
            Console.WriteLine();

            //foreach (var result in query2)
            //{
            //    Console.WriteLine(result.Nickname + "    " + result.Faculty + "    " + result.Topic + "    " + result.Description);
            //}
            //Console.WriteLine("results: " + query2.Count());
            //Console.WriteLine();
            //Console.WriteLine();
        }

        private static void LeftOuterJoin(List<StuddyBuddy> buddyList, List<ForumThread> threadList)
        {
            var query = from buddy in buddyList
                        join thread in threadList on buddy.Nickname equals thread.Creator into newList
                        from items in newList.DefaultIfEmpty(new ForumThread { Creator = String.Empty, Id = 0 })
                        select new {    Nickname = buddy.Nickname,
                                        Faculty = buddy.Faculty,
                                        Topic = items.Topic };

            foreach (var result in query)
            {
                Console.WriteLine(result.Nickname + "    " + result.Faculty + "    " + result.Topic);
            }
            Console.WriteLine("results: " + query.Count());
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void Group(List<StuddyBuddy> buddyList, List<ForumThread> threadList)
        {
            var query = from threads in threadList
                        group threads by threads.Creator into result
                        orderby result.Key
                        select result;

            //var query2 = threadList
            //            .GroupBy(c => c.Creator)
            //            .OrderBy(c => c.Key);

            foreach (var result in query)
            {
                Console.WriteLine(result.Key);
            }
            Console.WriteLine("results: " + query.Count());
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void Skip(List<StuddyBuddy> buddyList, List<ForumThread> threadList)
        {
            var query = threadList.Skip(2).Take(4);

            foreach (var result in query)
            {
                Console.WriteLine(result.Id + "     " + result.Creator + "  " + result.Topic);
            }
            Console.WriteLine("results: " + query.Count());
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void Take(List<StuddyBuddy> buddyList, List<ForumThread> threadList)
        {
            var query = threadList.Where(x => x.Id > 2).Take(3);

            foreach (var result in query)
            {
                Console.WriteLine(result.Id + "     " + result.Creator + "  " + result.Topic);
            }
            Console.WriteLine("results: " + query.Count());
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void Aggregate(List<StuddyBuddy> buddyList, List<ForumThread> threadList)
        {
            var query = from buddies in buddyList
                        select buddies.Points;

            foreach (var result in query)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine("results: " + query.Count());
            Console.WriteLine();
            Console.WriteLine();

            var query2 = query.Average();

            Console.WriteLine("Average: " + query2);
            Console.WriteLine();
            Console.WriteLine();
        }

        public static List<StuddyBuddy> LoadStuddyBuddies()
        {
            return new List<StuddyBuddy>()
            {
                new StuddyBuddy("Jonas", "Jonaspswd", "Business School", "Intenational business", 1, 11),
                new StuddyBuddy("Petras", "Petraspswd", "Faculty of Mathematics and Informatics", "Software Engineering", 2, 22),
                new StuddyBuddy("Abc", "Abcpswd", "Faculty of Philology", "English Literature", 3, 33),
                new StuddyBuddy("Marius", "Mariuspswd", "Business School", "Accounting and Auditing", 4, 44),
                new StuddyBuddy("Vytis", "Vytispswd", "Faculty of Philosophy", "Philosophy", 5, 55),
                new StuddyBuddy("Vytenis", "Vytenispswd", "Faculty of Mathematics and Informatics", "Software Engineering", 6, 66),
                new StuddyBuddy("Jonukas", "Jonukaspswd", "Faculty of Law", "Law", 7, 77)
            };
        }

        private static List<ForumThread> LoadForumThreads()
        {
            return new List<ForumThread>()
            {
                new ForumThread(){ Id=1, Creator="Jonas", Topic="Question1", Description="Description1", Studies="Intenational business" },
                new ForumThread(){ Id=2, Creator="Jonukas", Topic="Question2", Description="Description2", Studies="Law" },
                new ForumThread(){ Id=3, Creator="Jonas", Topic="Question3", Description="Description3", Studies="Intenational business" },
                new ForumThread(){ Id=4, Creator="Petras", Topic="Question4", Description="Description4", Studies="Software Engineering" },
                new ForumThread(){ Id=5, Creator="Marius", Topic="Question5", Description="Description5", Studies="Accounting and Auditing" },
                new ForumThread(){ Id=6, Creator="Vytenis", Topic="Question6", Description="Description6", Studies="Software Engineering" },
                new ForumThread(){ Id=7, Creator="Abc", Topic="Question7", Description="Description7", Studies="English literature" },
                new ForumThread(){ Id=8, Creator="Vytenis", Topic="Question8", Description="Description8", Studies="Software Engineering" },
                new ForumThread(){ Id=9, Creator="Petras", Topic="Question9", Description="Description9", Studies="Software Engineering" },
                new ForumThread(){ Id=10, Creator="Abc", Topic="Question10", Description="Description10", Studies="English Literature" }
            };
        }
    }
}
