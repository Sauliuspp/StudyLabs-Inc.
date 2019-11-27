using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApp.Models
{
    public enum MenuItemType
    {
        MainMenu,
        About,
        Testuks,
        Items
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
