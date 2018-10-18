using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TranslationSample
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();

            Children.Add(new TrDemo());
            Children.Add(new TrBlockText());
            Children.Add(new TrTextOffSet());
            Children.Add(new TrVerticalSliders());
        }
	}
}
