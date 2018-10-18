using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TicClock
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
            Children.Add(new ClockXaml());
            Children.Add(new ClockCode());
        }
	}
}
