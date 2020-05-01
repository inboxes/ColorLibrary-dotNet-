using System;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;

namespace ColorLibrary__dotNet_.Models
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        //public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //public Color Color { get; set; }
        //public Image Image { get; set; }
        public string Tags { get; set; }
        public DateTime Date { get; set; }
    }
}