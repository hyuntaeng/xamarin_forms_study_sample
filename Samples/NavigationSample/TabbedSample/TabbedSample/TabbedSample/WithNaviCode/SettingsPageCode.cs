using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedSample.WithNaviCode
{
	public class SettingsPageCode : ContentPage
	{
		public SettingsPageCode ()
		{
            Icon = "settings.png";
            Title = "Settings";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Settings go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
	}
}