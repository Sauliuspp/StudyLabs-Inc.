using System;
using System.Collections.Generic;
using XamarinApp.Models;

namespace DummyLibrary
{
    public class TestClass
    {
        public List<StuddyBuddy> LoadStuddyBuddies()
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

        private List<ForumThread> LoadForumThreads()
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
                new ForumThread(){ Id=8, Creator="Vytis", Topic="Question8", Description="Description8", Studies="Philosophy" },
                new ForumThread(){ Id=9, Creator="Petras", Topic="Question9", Description="Description9", Studies="Software Engineering" },
                new ForumThread(){ Id=9, Creator="Abc", Topic="Question10", Description="Description10", Studies="English Literature" }
            };
        }

        private void Join()
        {
            var query = 
        }
    }
}
