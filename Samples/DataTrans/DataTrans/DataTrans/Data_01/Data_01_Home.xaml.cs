using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;
using DataTrans.Data_01;

namespace DataTrans.Data_01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Data_01_Home : ContentPage
	{
        ObservableCollection<Data_01_Information> list = new ObservableCollection<Data_01_Information>();

        public Data_01_Home ()
		{
			InitializeComponent ();

            listView.ItemsSource = list;
        }

        async void OnGetInfoButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Data_01_Info());
        }
        
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem != null)
            {
                // De-select the item.
                listView.SelectedItem = null;

                Data_01_Info infoPage = new Data_01_Info();
                await Navigation.PushAsync(infoPage);
                infoPage.Data_01_Info_InitializeInfo((Data_01_Information)args.SelectedItem);
            }
        }
        
        public void Data_01_InformationReady(Data_01_Information info)
        {
            int index = list.IndexOf(info);

            if (index != -1)
            {
                list[index] = info;
            }
            else
            {
                list.Add(info);
            }
        }
    }
}