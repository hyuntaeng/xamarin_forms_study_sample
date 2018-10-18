using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTrans.Data_04
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Data_04_Home : ContentPage
	{
        App app = (App)Application.Current;

        public Data_04_Home ()
		{
			InitializeComponent ();

            listView.ItemsSource = app.InfoCollection;
        }

        // Button Clicked handler.
        async void OnGetInfoButtonClicked(object sender, EventArgs args)
        {
            // Create new Information item.
            app.CurrentInfoItem = new Data_04_information();

            // Navigate to info page.
            await Navigation.PushAsync(new Data_04_Info());
        }

        // ListView ItemSelected handler.
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem != null)
            {
                // De-select the item.
                listView.SelectedItem = null;

                // Get existing Information item.
                app.CurrentInfoItem = (Data_04_information)args.SelectedItem;

                // Navigate to info page.
                await Navigation.PushAsync(new Data_04_Info());
            }
        }
	}
}