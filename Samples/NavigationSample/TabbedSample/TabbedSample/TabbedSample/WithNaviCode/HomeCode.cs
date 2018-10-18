using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedSample.WithNaviCode
{
	public class HomeCode : TabbedPage
    {
		public HomeCode ()
		{
            var navigationPage = new NavigationPage(new SchedulePageCode());
            navigationPage.Icon = "schedule.png";
            navigationPage.Title = "Schedule";

            Children.Add(new TodayPageCode());
            Children.Add(navigationPage);
            Children.Add(new SettingsPageCode());
        }
	}
}