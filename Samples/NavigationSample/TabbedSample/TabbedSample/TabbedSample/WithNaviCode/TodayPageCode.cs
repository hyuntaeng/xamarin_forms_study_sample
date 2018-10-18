using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedSample.WithNaviCode
{
	public class TodayPageCode : ContentPage
	{
		public TodayPageCode ()
		{
            Icon = "today.png";
            Title = "Today";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Today's appointments go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
	}
}