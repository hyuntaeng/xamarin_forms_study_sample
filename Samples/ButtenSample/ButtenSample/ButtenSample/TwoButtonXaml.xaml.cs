using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ButtenSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TwoButtonXaml : ContentPage
	{
		public TwoButtonXaml ()
		{
			InitializeComponent ();
		}

        void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;

            if (button == addButton)
            {
                loggerLayout.Children.Add(new Label
                {
                    Text = "Button clicked at " + DateTime.Now.ToString("T")
                });
            }
            else
            {
                loggerLayout.Children.RemoveAt(0);
            }
            
            removeButton.IsEnabled = loggerLayout.Children.Count > 0;
        }
    }
}