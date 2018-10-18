using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ButtonEtc
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BtnGlide : ContentPage
	{
        static readonly TimeSpan duration = TimeSpan.FromSeconds(1);
        Random random = new Random();
        Point startPoint;
        Point animationVector;
        DateTime startTime;

        public BtnGlide ()
		{
			InitializeComponent ();

            Device.StartTimer(TimeSpan.FromMilliseconds(16), OnTimerTick);
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            View container = (View)button.Parent;

            startPoint = new Point(button.TranslationX, button.TranslationY);
            
            double endX = (random.NextDouble() - 0.5) * (container.Width - button.Width);
            double endY = (random.NextDouble() - 0.5) * (container.Height - button.Height);
            
            animationVector = new Point(endX - startPoint.X, endY - startPoint.Y);
            
            startTime = DateTime.Now;
        }

        bool OnTimerTick()
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            
            double t = Math.Max(0, Math.Min(1, elapsedTime.TotalMilliseconds /
                                                    duration.TotalMilliseconds));
            
            button.TranslationX = startPoint.X + t * animationVector.X;
            button.TranslationY = startPoint.Y + t * animationVector.Y;
            return true;
        }
    }
}