using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginNavi.XamlSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeXaml : ContentPage
	{
		public HomeXaml ()
		{
			InitializeComponent ();
		}

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginPageXaml(), this);
            await Navigation.PopAsync();
        }
    }
}