using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.IO;
using System.Net;

namespace WaitingCircle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApmToTap : ContentPage
	{
		public ApmToTap ()
		{
			InitializeComponent ();
		}

        async void OnLoadButtonClicked(object sender, EventArgs args)
        {
            try
            {
                Stream stream =
                        await GetStreamAsync("https://developer.xamarin.com/demo/IMG_1996.JPG");

                image.Source = ImageSource.FromStream(() => stream);
            }
            catch (Exception exc)
            {
                errorLabel.Text = exc.Message;
            }
        }

        async Task<Stream> GetStreamAsync(string uri)
        {
            TaskFactory factory = new TaskFactory();
            WebRequest request = WebRequest.Create(uri);
            WebResponse response = await factory.FromAsync<WebResponse>(request.BeginGetResponse,
                                                                        request.EndGetResponse,
                                                                        null);
            return response.GetResponseStream();
        }
    }
}