using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SimpleTheme
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			//MainPage = new SimpleTheme.MainCode();

            TabbedPage tabbedPage = new TabbedPage();

            tabbedPage.Children.Add(new SimpleTheme.MainPage());
            tabbedPage.Children.Add(new SimpleTheme.MainCode());

            MainPage = tabbedPage;
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
