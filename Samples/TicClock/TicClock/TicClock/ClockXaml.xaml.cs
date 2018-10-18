using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicClock
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClockXaml : ContentPage
	{
		public ClockXaml ()
		{
			InitializeComponent ();

            Device.StartTimer(TimeSpan.FromSeconds(1), TimerSpanSeconds);
        }

        void LabelSizeChage(object sender, EventArgs args)
        {
            if (this.Width > 0)
                lbl_timer.FontSize = this.Width / 6;
        }

        bool TimerSpanSeconds()
        {
            lbl_timer.Text = DateTime.Now.ToString("h:mm:ss tt");
            return true;
        }
    }
}