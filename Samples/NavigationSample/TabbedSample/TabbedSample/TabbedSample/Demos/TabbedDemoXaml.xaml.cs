using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedSample.Demos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabbedDemoXaml : TabbedPage
    {
		public TabbedDemoXaml ()
		{
			InitializeComponent ();

            ItemsSource = MonkeyDataModel.All;
        }
	}
}