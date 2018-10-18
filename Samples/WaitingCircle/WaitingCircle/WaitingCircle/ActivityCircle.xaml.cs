using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaitingCircle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ActivityCircle : ContentPage
	{
		public ActivityCircle ()
		{
			InitializeComponent ();
		}

        async void BtnClicked(object sender, EventArgs e)
        {
            wcai.IsRunning = true;
            boxvisible.IsVisible = true;

            await Task.Delay(3000);

            wcai.IsRunning = false;
            boxvisible.IsVisible = false;
        }
    }
}