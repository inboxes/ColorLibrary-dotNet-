using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ColorLibrary__dotNet_.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Color Color { get; set; }
        public Image Image { get; set; }
        public string Tags { get; set; }
    }
}