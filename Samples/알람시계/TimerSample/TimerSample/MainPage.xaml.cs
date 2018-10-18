using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using System.ComponentModel;

namespace TimerSample
{
	public partial class MainPage : ContentPage
	{
        DateTime triggerTime;

        public MainPage()
		{
			InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        bool OnTimerTick()
        {
            if (@switch.IsToggled && DateTime.Now >= triggerTime)
            {
                @switch.IsToggled = false;
                DisplayAlert("Timer Alert",
                             "The '" + entry.Text + "' timer has elapsed",
                             "OK");
            }
            return true;
        }

        void OnTimePickerPropertyChanged(object obj, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Time")
            {
                SetTriggerTime();
            }
        }

        void OnSwitchToggled(object obj, ToggledEventArgs args)
        {
            SetTriggerTime();
        }

        void SetTriggerTime()
        {
            if (@switch.IsToggled)
            {
                triggerTime = DateTime.Today + timePicker.Time;

                if (triggerTime < DateTime.Now)
                {
                    triggerTime += TimeSpan.FromDays(1);
                }
            }
        }
    }
}
