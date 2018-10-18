using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ListColor
{
	public class ColorListCode : ContentPage
	{
		public ColorListCode ()
		{
            string[] ColorName = { "Aqua", "Black", "Blue", "Fuchsia", "Gray",
                "Green", "Lime", "Maroon", "Navy", "Olive", "Purple", "Pink", "Red", "Silver",
                "Teal", "White", "Yellow"};
            Content = new StackLayout
            {
                Padding = new Thickness(10, 0),
            };

            StackLayout stackLayout = new StackLayout
            {
                Padding = new Thickness(10, 0),
            };


            for (int i = 0; i < ColorName.Length; ++i)
            {
                ColorFrame colorViewFrame = new ColorFrame();

                colorViewFrame.ColorName = ColorName[i];

                stackLayout.Children.Add(colorViewFrame);
            }

            Title = "Code";
            
            Content = new ScrollView
            {
                Content = stackLayout,

            };
        }
	}
}