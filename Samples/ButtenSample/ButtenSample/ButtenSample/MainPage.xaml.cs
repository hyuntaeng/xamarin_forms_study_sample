using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ButtenSample
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
            Children.Add(new TwoButtonXaml());
            Children.Add(new TwoButtonCode());
            Children.Add(new NumberPadXaml());
            Children.Add(new NumberPadCode());
        }
	}
}
