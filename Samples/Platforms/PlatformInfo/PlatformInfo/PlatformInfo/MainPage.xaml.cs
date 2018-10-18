using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlatformInfo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            MyPatformInfo platformInfo = DependencyService.Get<MyPatformInfo>();
            modelLabel.Text = platformInfo.GetModel();
            versionLabel.Text = platformInfo.GetVersion();

            if (Device.RuntimePlatform == Device.iOS)
            {
                deviceslabel.Text = "Device IOS";
            }

            if (Device.RuntimePlatform == Device.Android)
            {
                deviceslabel.Text = "Device Android";
            }

            else
            {
                deviceslabel.Text = "Device None";
            }
        }
	}
}
