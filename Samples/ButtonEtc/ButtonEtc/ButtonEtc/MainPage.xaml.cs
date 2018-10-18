using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ButtonEtc
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();

            Children.Add(new BtnGlide());
            Children.Add(new BtnJump());
            Children.Add(new BtnScaler());

        }
    }
}
