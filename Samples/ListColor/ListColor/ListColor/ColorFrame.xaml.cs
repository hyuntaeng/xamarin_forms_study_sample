﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListColor
{
	public partial class ColorFrame : ContentView
    {
        string colorName;
        ColorTypeConverter colorTypeConv = new ColorTypeConverter();

        public ColorFrame ()
		{
			InitializeComponent ();
		}

        public string ColorName
        {
            set
            {
                // Set the name.
                colorName = value;
                colorNameLabel.Text = value;

                // Get the actual Color and set the other views.
                Color color = (Color)colorTypeConv.ConvertFromInvariantString(colorName);
                boxView.Color = color;
                colorValueLabel.Text = String.Format("{0:X2}-{1:X2}-{2:X2}",
                                                     (int)(255 * color.R),
                                                     (int)(255 * color.G),
                                                     (int)(255 * color.B));
            }
            get
            {
                return colorName;
            }
        }
    }
}