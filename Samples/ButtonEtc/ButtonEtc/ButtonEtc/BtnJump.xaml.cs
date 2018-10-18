using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ButtonEtc
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BtnJump : ContentPage
	{
        Random random = new Random();

        public BtnJump ()
		{
			InitializeComponent ();
		}

        void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            View container = (View)button.Parent;

            button.TranslationX = (random.NextDouble() - 0.5) * (container.Width - button.Width);
            button.TranslationY = (random.NextDouble() - 0.5) * (container.Height - button.Height);
        }
    }
}