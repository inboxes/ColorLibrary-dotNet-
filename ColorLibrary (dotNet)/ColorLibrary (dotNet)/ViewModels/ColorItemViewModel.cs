using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ColorLibrary__dotNet_.ViewModels
{
    class ColorItemViewModel
    {
        int id = 1;
        string description = "placeholder description";
        DateTime date = System.DateTime.Now;

        public int ID 
        {
            get { return id; }
            set { id = value; } 
        }
        public string Title { get; set; }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Color Color { get; set; }
        public Image Image { get; set; }
        public string Tags { get; set; }
        public DateTime Date 
        {
            get { return date; }
            set { date = value; } 
        }

        public class ColorItem
        {
            public string Description { get; set; }
        }

        public ObservableCollection<ColorItem> _colorlist = new ObservableCollection<ColorItem>();
        public ObservableCollection<ColorItem> ColorList
        {
            get { return _colorlist; }
        }
        
       
    }

}
