using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataTrans
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void BtnClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch ((string)button.StyleId)
            {
                case "Data_01":
                    await Navigation.PushAsync(new Data_01.Data_01_Home());
                    break;

                case "Data_02":
                    await Navigation.PushAsync(new Data_01.Data_01_Home());
                    break;

                case "Data_03":
                    await Navigation.PushAsync(new Data_01.Data_01_Home());
                    break;

                case "Data_04":
                    await Navigation.PushAsync(new Data_01.Data_01_Home());
                    break;

            }
        }
    }
}
