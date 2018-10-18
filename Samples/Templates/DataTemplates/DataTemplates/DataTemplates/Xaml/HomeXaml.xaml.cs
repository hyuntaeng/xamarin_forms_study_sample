using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTemplates.Xaml
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeXaml : TabbedPage
	{
		public HomeXaml ()
		{
            Children.Add(new WithoutDataTemplatePageXaml());
            Children.Add(new WithDataTemplatePageXaml());
            Children.Add(new WithDataTemplatePageFromTypeXaml());
        }
	}
}