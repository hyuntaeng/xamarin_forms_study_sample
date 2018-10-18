using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BtnImage
{
	public class IconCode : ContentPage
	{
		public IconCode ()
		{
            Title = "Code";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Button {
                        HorizontalOptions = LayoutOptions.Center,
                        Image = "ic_action_good.png",
                        Text = "Oh Yeah",
                    },
                        new Button
                        {
                            HorizontalOptions = LayoutOptions.Center,
                            Image = "ic_action_bad.png",
                            Text = "No Way",
                        }
                }
            };
        }
	}
}