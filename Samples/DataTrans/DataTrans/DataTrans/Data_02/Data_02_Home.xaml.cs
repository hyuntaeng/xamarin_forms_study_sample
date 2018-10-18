using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace DataTrans.Data_02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Data_02_Home : ContentPage
	{
        ObservableCollection<Data_02_information> list = new ObservableCollection<Data_02_information>();

        public Data_02_Home ()
		{
			InitializeComponent ();
            // Set collection to ListView.
            listView.ItemsSource = list;

            // Subscribe to "InformationReady" message.
            MessagingCenter.Subscribe<Data_02_Info, Data_02_information>
                (this, "InformationReady", (sender, info) =>
                {
                    // If the object has already been added, replace it.
                    int index = list.IndexOf(info);

                    if (index != -1)
                    {
                        list[index] = info;
                    }
                    // Otherwise, add it.
                    else
                    {
                        list.Add(info);
                    }
                });
        }

        // Button Clicked handler.
        async void OnGetInfoButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Data_02_Info());
        }

        // ListView ItemSelected handler.
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem != null)
            {
                // De-select the item.
                listView.SelectedItem = null;

                Data_02_Info infoPage = new Data_02_Info();
                await Navigation.PushAsync(infoPage);

                // Send "InitializeInfo" message to info page.
                MessagingCenter.Send<Data_02_Home, Data_02_information>
                    (this, "InitializeInfo", (Data_02_information)args.SelectedItem);
            }
        }
    }
}
