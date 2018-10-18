using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTrans.Data_03
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Data_03_Info : ContentPage
	{
        public event EventHandler<Data_03_Information> InformationReady;

        Data_03_Information info = new Data_03_Information();

        public Data_03_Info ()
		{
			InitializeComponent ();
		}

        public void InitializeInfo(Data_03_Information info)
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

            // Raise the InformationReady event.
            InformationReady?.Invoke(this, info);
        }
    }
}
