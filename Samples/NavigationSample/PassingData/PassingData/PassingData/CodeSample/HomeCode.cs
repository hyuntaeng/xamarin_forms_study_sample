using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PassingData.CodeSample
{
	public class HomeCode : ContentPage
	{
		public HomeCode ()
		{
            string date = DateTime.Now.ToString("u");

            var navigateButton = new Button { Text = "Next Page", HorizontalOptions = LayoutOptions.Center };
            navigateButton.Clicked += OnNavigateButtonClicked;

            Title = "Main Page";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    new StackLayout {
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.Center,
                        Children = {
                            new Label { Text = "Date: ", FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)) },
                            new Label { Text = date, FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)) }
                        }
                    },
                    navigateButton
                }
            };
        }

        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            var contact = new Contact
            {
                Name = "Jane Doe",
                Age = 30,
                Occupation = "Developer",
                Country = "USA"
            };

            var secondPage = new SecondPageCode();
            secondPage.BindingContext = contact;
            await Navigation.PushAsync(secondPage);
        }
    }
}
