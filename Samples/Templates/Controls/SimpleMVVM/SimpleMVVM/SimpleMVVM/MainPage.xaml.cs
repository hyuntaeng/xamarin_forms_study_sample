using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleMVVM
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
            Children.Add(new HomeCode());
            Children.Add(new HomeXaml());
        }
	}
}
