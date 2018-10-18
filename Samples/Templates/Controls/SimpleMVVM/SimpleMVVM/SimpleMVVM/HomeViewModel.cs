using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SimpleMVVM
{
	public class HomeViewModel
	{
        public string HeaderText { get { return "Control Template Demo App"; } }

        public string FooterText { get { return "(c) Xamarin 2016"; } }
	}
}