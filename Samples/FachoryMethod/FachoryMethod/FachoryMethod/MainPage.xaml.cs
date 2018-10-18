using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FachoryMethod
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();

            Children.Add(new FrachoryMethodPage());
            Children.Add(new ParameterePage());
        }
	}
}
