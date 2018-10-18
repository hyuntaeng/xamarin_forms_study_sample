using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedSample.WithNaviCode
{
	public class SchedulePageCode : ContentPage
	{
		public SchedulePageCode ()
		{
            Button button = new Button
            {
                Text = "Upcoming Appointments",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += OnUpcomingAppointmentsButtonClicked;

            Title = "This Week";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "This week's appointments go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                    button
                }
            };
        }

        async void OnUpcomingAppointmentsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpcomingAppointmentsPageCode());
        }
    }
}