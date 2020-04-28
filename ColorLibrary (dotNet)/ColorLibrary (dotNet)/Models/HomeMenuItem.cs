using System;
using System.Collections.Generic;
using System.Text;

namespace ColorLibrary__dotNet_.Models
{
    public enum MenuItemType
    {
        Library,
        Recent,
        Catalogues,
        Settings,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
