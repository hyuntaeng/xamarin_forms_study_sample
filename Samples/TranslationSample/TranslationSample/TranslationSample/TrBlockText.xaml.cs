using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TranslationSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrBlockText : ContentPage
	{
		public TrBlockText ()
		{
			InitializeComponent ();

            for (int i = 0; i < 12; i++)
            {
                grid.Children.Insert(0, new Label
                {
                    TranslationX = i,
                    TranslationY = -i
                });
            }
        }
	}
}