using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TriggerSample
{
	public class TriggerEntryCode : ContentPage
	{
		public TriggerEntryCode ()
		{
            Title = "code";

            Padding = new Thickness(20, 50, 120, 0);
            Content = new StackLayout
            {
                Spacing = 20,
                Children =
                {
                    new Entry
                    {
                        Placeholder = "enter name",
                        AnchorX = 0,
                        Triggers =
                        {
                            new Trigger(typeof(Entry))
                            {
                                Property = Entry.IsFocusedProperty,
                                Value = true,
                                Setters =
                                {
                                    new Setter
                                    {
                                        Property = Entry.ScaleProperty,
                                        Value = 1.5
                                    }
                                }
                            }
                        }
                    },
                    new Entry
                    {
                        Placeholder = "enter addresss",
                        AnchorX = 0,
                        Triggers =
                        {
                            new Trigger(typeof(Entry))
                            {
                                Property = Entry.IsFocusedProperty,
                                Value = true,
                                Setters =
                                {
                                    new Setter
                                    {
                                        Property = Entry.ScaleProperty,
                                        Value = 1.5
                                    }
                                }
                            }
                        }
                    },
                    new Entry
                    {
                        Placeholder = "enter city and state",
                        AnchorX = 0,
                        Triggers =
                        {
                            new Trigger(typeof(Entry))
                            {
                                Property = Entry.IsFocusedProperty,
                                Value = true,
                                Setters =
                                {
                                    new Setter
                                    {
                                        Property = Entry.ScaleProperty,
                                        Value = 1.5
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
