using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApp.Models
{
    public class ForumThread
    {
        public int Id { get; set; }
        public string Creator { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public string Studies { get; set; }
    }
}
