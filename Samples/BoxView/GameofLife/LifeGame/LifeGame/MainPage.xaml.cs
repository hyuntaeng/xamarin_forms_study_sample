using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LifeGame
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void OnLayoutSizeChanged(object sender, EventArgs args)
        {
            
        }

        void UpdateLayout()
        {
            
        }

        void OnRunButtonClicked(object sender, EventArgs args)
        {

        }

        void StopRunning()
        {

        }

        bool OnTimerTick()
        {
            return true;
        }

        void OnClearButtonClicked(object sender, EventArgs args)
        {

        }

        void OnAboutButtonClicked(object sender, EventArgs args)
        {
            aboutText.IsVisible = true;
        }

        void OnHyperlinkTapped(object sender, EventArgs args)
        {
            Label label = (Label)sender;
            Device.OpenUri(new Uri(label.Text));
        }

        private void OnCloseButtonClicked(object sender, EventArgs args)
        {
            aboutText.IsVisible = false;
        }
    }
}
