using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrameSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FrameXaml : ContentPage
	{
		public FrameXaml ()
		{
			InitializeComponent ();
		}
	}
}