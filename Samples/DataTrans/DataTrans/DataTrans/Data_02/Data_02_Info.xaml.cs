using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTrans.Data_02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Data_02_Info : ContentPage
	{
        Data_02_information info = new Data_02_information();

        public Data_02_Info ()
		{
			InitializeComponent ();
            // Subscribe to "InitializeInfo" message.
            MessagingCenter.Subscribe<Data_02_Home, Data_02_information>
                (this, "InitializeInfo", (sender, info) =>
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

                    // Don't need "InitializeInfo" any more so unsubscribe.
                    MessagingCenter.Unsubscribe<Data_02_Home, Data_02_information>
                        (this, "InitializeInfo");
                });
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

            // Send "InformationReady" message back to home page.
            MessagingCenter.Send<Data_02_Info, Data_02_information>
                (this, "InformationReady", info);
        }
    }
}
