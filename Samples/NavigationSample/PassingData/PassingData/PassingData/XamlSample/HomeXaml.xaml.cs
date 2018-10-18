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
	public partial class HomeXaml : ContentPage
	{
		public HomeXaml ()
		{
			InitializeComponent ();
		}

        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            var contact = new Contact
            {
                Name = "Jane Doe",
                Age = 30,
                Occupation = "Developer",
                Country = "USA"
            };

            var secondPage = new SecondPageXaml();
            secondPage.BindingContext = contact;
            await Navigation.PushAsync(secondPage);
        }
    }
}