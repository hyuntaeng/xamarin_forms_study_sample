﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBingingSample.Basic
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BasicCodeBindingPage : ContentPage
	{
		public BasicCodeBindingPage ()
		{
			InitializeComponent ();

            label.BindingContext = slider;
            label.SetBinding(Label.RotationProperty, "Value");
        }
	}
}