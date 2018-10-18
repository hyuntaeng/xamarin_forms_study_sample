using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TriggerSample
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();

            Children.Add(new Triggers());
            Children.Add(new triggerBtn());
            Children.Add(new TriggerEntry());
            Children.Add(new TriggerEntryCode());
        }
	}
}
