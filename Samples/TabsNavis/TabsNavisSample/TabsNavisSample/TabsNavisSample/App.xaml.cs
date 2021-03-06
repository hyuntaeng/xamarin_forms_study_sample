﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabsNavisSample
{
	public partial class App : Application
	{
        public static App GlobalAppData;

        public bool bNaivState;

        public App ()
		{
            if (GlobalAppData == null)
            {
                GlobalAppData = this;
            }

			InitializeComponent();

            //MainPage = new TabsNavisSample.MainPage();
            MainPage = new NavigationPage(new TabsNavisSample.MainPage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
