using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

#if __IOS__
using UIKit;

#elif __ANDROID__
using Android.OS;

#endif

namespace PlatInfo_Sap
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NomalMode : ContentPage
	{
		public NomalMode ()
		{
            InitializeComponent();

#if __IOS__

            UIDevice device = new UIDevice();
            modelLabel.Text = device.Model.ToString();
            versionLabel.Text = String.Format("{0} {1}", device.SystemName, 
                                                         device.SystemVersion);

#elif __ANDROID__

            modelLabel.Text = String.Format("{0} {1}", Build.Manufacturer,
                                                       Build.Model);
            versionLabel.Text = Build.VERSION.Release.ToString();

#endif

        }
    }
}
