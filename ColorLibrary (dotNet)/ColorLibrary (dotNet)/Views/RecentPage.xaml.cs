using ColorLibrary__dotNet_.Data;
using ColorLibrary__dotNet_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetItemAsync();
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