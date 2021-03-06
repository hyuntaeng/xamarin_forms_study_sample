﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabsNavisSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NaviBack02 : ContentPage
	{
		public NaviBack02 ()
		{
			InitializeComponent ();
		}

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }

        async void OnBackClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}