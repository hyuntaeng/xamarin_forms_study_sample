using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataTrans
{
	public partial class App : Application
	{
        // 04번 관련 소스
        public IList<Data_04.Data_04_information> InfoCollection { private set; get; }
        public Data_04.Data_04_information CurrentInfoItem { set; get; }

        public App ()
		{
			InitializeComponent();

            // 04번 관련 소스
            InfoCollection = new ObservableCollection<Data_04.Data_04_information>();


            MainPage = new NavigationPage(new DataTrans.MainPage());
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
