using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleBindding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeXaml : ContentPage
	{
        bool originalTemplate = true;
        ControlTemplate tealTemplate;
        ControlTemplate aquaTemplate;

        public static readonly BindableProperty HeaderTextProperty = BindableProperty.Create("HeaderText", typeof(string), typeof(HomeXaml), "Control Template Demo App");
        public static readonly BindableProperty FooterTextProperty = BindableProperty.Create("FooterText", typeof(string), typeof(HomeXaml), "(c) Xamarin 2016");

        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
        }

        public string FooterText
        {
            get { return (string)GetValue(FooterTextProperty); }
        }

        public HomeXaml ()
		{
			InitializeComponent ();

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