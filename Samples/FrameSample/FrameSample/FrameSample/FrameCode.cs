using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FrameSample
{
	public class FrameCode : ContentPage
	{
		public FrameCode ()
		{
            Title = "Code";
            string[] colorname = { "Red", "Green", "Blue" };

            StackLayout mStackLayout = new StackLayout();

            for (int i = 0; i < colorname.Length; i++)
            {
                StackLayout tempStack = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                };

                Frame tempframe = new Frame
                {
                    OutlineColor = Color.Accent,
                };

                var converter = new ColorTypeConverter();

                Color tempColor = (Color)converter.ConvertFromInvariantString(colorname[i]);

                tempStack.Children.Add(new BoxView { Color = tempColor });
                tempStack.Children.Add(new Label
                {
                    Text = colorname[i],
                    VerticalOptions = LayoutOptions.Center
                });

                tempframe.Content = tempStack;

                mStackLayout.Children.Add(tempframe);
            };

            Content = mStackLayout;
        }
	}
}