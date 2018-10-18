using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DataTemplates.Code
{
	public class HomeCode : TabbedPage
    {
		public HomeCode ()
		{
            Children.Add(new WithoutDataTemplatePageCode());
            Children.Add(new WithDataTemplatePageCode());
            Children.Add(new WithDataTemplatePageFromTypeCode());
        }
	}
}