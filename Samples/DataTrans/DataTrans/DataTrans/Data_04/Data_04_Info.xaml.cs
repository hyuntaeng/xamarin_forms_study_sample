using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTrans.Data_04
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Data_04_Info : ContentPage
	{
        App app = (App)Application.Current;

        public Data_04_Info ()
		{
			InitializeComponent ();

            Data_04_information info = app.CurrentInfoItem;

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
            Data_04_information info = app.CurrentInfoItem;

            info.Name = nameEntry.Text;
            info.Email = emailEntry.Text;

            int index = languagePicker.SelectedIndex;
            info.Language = index == -1 ? null : languagePicker.Items[index];

            info.Date = datePicker.Date;

            // If the object has already been added to the collection, replace it.
            IList<Data_04_information> list = app.InfoCollection;

            index = list.IndexOf(info);

            if (index != -1)
            {
                list[index] = info;
            }
            // Otherwise, add it.
            else
            {
                list.Add(info);
            }
        }
    }
}