using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleTheme
{
	public partial class MainPage : ContentPage
	{
        bool originalTemplate = true;
        ControlTemplate tealTemplate;
        ControlTemplate aquaTemplate;


        public MainPage()
		{
			InitializeComponent();
            tealTemplate = (ControlTemplate)Application.Current.Resources["TealTemplate"];
            aquaTemplate = (ControlTemplate)Application.Current.Resources["AquaTemplate"];
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            originalTemplate = !originalTemplate;
            contentView.ControlTemplate = (originalTemplate) ? tealTemplate : aquaTemplate;
        }
    }
}
