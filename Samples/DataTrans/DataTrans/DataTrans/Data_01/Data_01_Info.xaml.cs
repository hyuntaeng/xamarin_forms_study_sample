using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DataTrans.Data_01;

namespace DataTrans.Data_01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Data_01_Info : ContentPage
	{
        Data_01_Information info = new Data_01_Information();

        public Data_01_Info ()
		{
			InitializeComponent ();
		}

        public void Data_01_Info_InitializeInfo(Data_01_Information info)
        {
            // Replace the instance.
            this.info = info;

            // Initialize the views.
            nameEntry.Text = info.Name ?? "";
            emailEntry.Text = info.Email ?? "";

            if (!String.IsNullOrWhiteSpace(info.Language))
            {
                languagePicker.SelectedIndex = languagePicker.Items.IndexOf(info.Language);
            }
            datePicker.Date = info.Date;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            // Set properties of Information object.
            info.Name = nameEntry.Text;
            info.Email = emailEntry.Text;

            int index = languagePicker.SelectedIndex;
            info.Language = index == -1 ? null : languagePicker.Items[index];

            info.Date = datePicker.Date;

            // Get the DataTransfer1HomePage that invoked this page.
            NavigationPage navPage = (NavigationPage)Application.Current.MainPage;
            IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
            int lastIndex = navStack.Count - 1;
            Data_01_Home homePage = navStack[lastIndex] as Data_01_Home;

            if (homePage == null)
            {
                homePage = navStack[lastIndex - 1] as Data_01_Home;
            }
            // Transfer Information object to DataTransfer1HomePage.
            homePage.Data_01_InformationReady(info);
        }
    }
}