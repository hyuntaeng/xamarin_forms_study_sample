using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlatInfo_Sap
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlatFormType : ContentPage
	{
		public PlatFormType ()
		{
            InitializeComponent();

            PlatformInfoType platformInfo = new PlatformInfoType();
            modelLabel.Text = platformInfo.GetModel();
            versionLabel.Text = platformInfo.GetVersion();
        }
	}
}