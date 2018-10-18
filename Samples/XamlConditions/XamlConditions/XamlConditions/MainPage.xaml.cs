using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlConditions
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();

            Children.Add(new ConAnd());
            Children.Add(new ConOr());
            Children.Add(new ConXor());
        }
	}
}
