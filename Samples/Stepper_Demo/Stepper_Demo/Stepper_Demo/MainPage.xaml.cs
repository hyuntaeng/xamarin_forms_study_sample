using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Stepper_Demo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            OnStepperValueChanged(stepper, null);
        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs args)
        {
            Stepper stepper = (Stepper)sender;
            button.BorderWidth = stepper.Value;
            label.Text = stepper.Value.ToString("F0");
        }
    }
}
