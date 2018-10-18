using Xamarin.Forms;

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CarouselPageSample.ModelCode
{
	public class ColorsDataModel
	{
        public string Name { get; set; }

        public Color Color { get; set; }

        public static IList<ColorsDataModel> All { get; set; }

        static ColorsDataModel()
        {
            All = new ObservableCollection<ColorsDataModel> {
                new ColorsDataModel {
                    Name = "Red",
                    Color = Color.Red
                },
                new ColorsDataModel {
                    Name = "Green",
                    Color = Color.Green
                },
                new ColorsDataModel {
                    Name = "Blue",
                    Color = Color.Blue
                }
            };
        }
    }
}
