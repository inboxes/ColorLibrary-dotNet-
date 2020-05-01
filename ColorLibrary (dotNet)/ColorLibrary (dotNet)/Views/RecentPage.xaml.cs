using ColorLibrary__dotNet_.Data;
using ColorLibrary__dotNet_.Models;
using ColorLibrary__dotNet_.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorLibrary__dotNet_.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecentPage : ContentPage
    {
        public RecentPage()
        {
            InitializeComponent();
            BindingContext = new ColorItemViewModel();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //ObservableCollection<ColorItemViewModel.ColorItem> _colorlist = new ObservableCollection<ColorItemViewModel.ColorItem>();
            //_colorlist.Add(new ColorItemViewModel.ColorItem { Name = "Rob Finnerty" });
            //ColorList.ItemsSource = _colorlist;

            var note = new Item();
            note.Description = "Smile";
            note.Date = DateTime.UtcNow;
            await App.Database.SaveItemAsync(note);
            ColorList.ItemsSource = await App.Database.GetItemAsync();
        }

        //async void OnNoteAddedClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new NoteEntryPage
        //    {
        //        BindingContext = new Note()
        //    });
        //}

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ItemDetailPage
                {
                    BindingContext = e.SelectedItem as Item
                });
            }
        }
    }
}