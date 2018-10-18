﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Diagnostics;
using System.Threading.Tasks;

namespace ButtonEtc
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BtnScaler : ContentPage
	{
		public BtnScaler ()
		{
			InitializeComponent ();
		}

        void OnAnimateScaleClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            AnimateAndBack(1, 5, TimeSpan.FromSeconds(3), (double value) =>
            {
                button.Scale = value;
            });
        }

        void OnAnimateFontSizeClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;

            AnimateAndBack(button.FontSize, 5 * button.FontSize,
                           TimeSpan.FromSeconds(3), (double value) =>
                           {
                               button.FontSize = value;
                           });
        }

        async void AnimateAndBack(double fromValue, double toValue,
                                  TimeSpan duration, Action<double> callback)
        {
            Stopwatch stopWatch = new Stopwatch();
            double t = 0;
            stopWatch.Start();

            while (t < 1)
            {
                double tReversing = 2 * (t < 0.5 ? t : 1 - t);
                callback(fromValue + (toValue - fromValue) * tReversing);
                await Task.Delay(16);
                t = stopWatch.ElapsedMilliseconds / duration.TotalMilliseconds;
            }

            stopWatch.Stop();
            callback(fromValue);
        }
    }
}