using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PassingData.XamlSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPageXaml : ContentPage
	{
		public SecondPageXaml ()
		{
			InitializeComponent ();
		}

        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}