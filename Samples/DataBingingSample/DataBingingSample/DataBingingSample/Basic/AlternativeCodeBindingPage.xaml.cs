using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBingingSample.Basic
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlternativeCodeBindingPage : ContentPage
	{
		public AlternativeCodeBindingPage ()
		{
			InitializeComponent ();

            blabel.SetBinding(Label.ScaleProperty, 
                new Binding("Value", source: bslider));
        }
	}
}