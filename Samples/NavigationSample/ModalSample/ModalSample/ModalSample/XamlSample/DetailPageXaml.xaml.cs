using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ModalSample.XamlSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPageXaml : ContentPage
	{
		public DetailPageXaml ()
		{
			InitializeComponent ();
		}

        async void OnDismissButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}