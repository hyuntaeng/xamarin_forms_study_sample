using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliderSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SldSample : ContentPage
	{
		public SldSample ()
		{
			InitializeComponent ();
		}

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            label.Text = String.Format("Slider = {0}", args.NewValue);
        }
    }
}