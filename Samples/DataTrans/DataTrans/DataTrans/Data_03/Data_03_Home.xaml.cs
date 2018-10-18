using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace DataTrans.Data_03
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Data_03_Home : ContentPage
	{
        ObservableCollection<Data_03_Information> list = new ObservableCollection<Data_03_Information>();

        public Data_03_Home ()
		{
			InitializeComponent ();

            listView.ItemsSource = list;
        }

        // Button Clicked handler.
        async void OnGetInfoButtonClicked(object sender, EventArgs args)
        {
            Data_03_Info infoPage = new Data_03_Info();
            await Navigation.PushAsync(infoPage);

            // Set event handler for obtaining information.
            infoPage.InformationReady += OnInfoPageInformationReady;
        }

        // ListView ItemSelected handler.
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem != null)
            {
                // De-select the item.
                listView.SelectedItem = null;

                Data_03_Info infoPage = new Data_03_Info();
                await Navigation.PushAsync(infoPage);
                infoPage.InitializeInfo((Data_03_Information)args.SelectedItem);

                // Set event handler for obtaining information.
                infoPage.InformationReady += OnInfoPageInformationReady;
            }
        }

        void OnInfoPageInformationReady(object sender, Data_03_Information info)
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
        }
    }
}