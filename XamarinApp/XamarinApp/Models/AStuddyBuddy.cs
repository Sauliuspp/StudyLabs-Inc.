﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Models
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
    public class AStuddyBuddy : IEquatable<AStuddyBuddy>, IComparable
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string Link { get; set; }
        public string Faculty { get; set; }
        public string Studies { get; set; }
        public int Status { get; set; }
        public int Points { get; set; }

        public AStuddyBuddy(string nickname, string password, string link, string faculty, string studies)
        {
            this.Nickname = nickname;
            this.Password = password;
            this.Link = link;
            this.Faculty = faculty;
            this.Studies = studies;
            this.Status = 1;
            this.Points = 0;
        }

        public bool Equals(AStuddyBuddy other)
        {
            if (!(other is AStuddyBuddy))
            {
                throw new ArgumentException("Object is not AStuddyBuddy");
            }
            else
            {
                return this.Nickname == other.Nickname &&
                        this.Faculty == other.Faculty &&
                        this.Studies == other.Studies;
            }
        }

        public int CompareTo(object obj)
        {
            AStuddyBuddy other = obj as AStuddyBuddy;
            if (!(obj is AStuddyBuddy))
            {
                throw new ArgumentException("Object is not AStuddyBuddy");
            }
            else
            {
                return this.Points.CompareTo(other.Points);
            }
        }

        public string CreateDatabaseEntry()
        {
            return "INSERT INTO StuddyBuddy ([Nickname],[Facebook],[Faculty],[Studies],[Status],[Points]) VALUES('" +
                Nickname + "','" +
                Link + "','" +
                Faculty + "','" +
                Studies + "','" +
                (int)Level.Starter + "','" +
                0 + "')";
        }
    }
}
