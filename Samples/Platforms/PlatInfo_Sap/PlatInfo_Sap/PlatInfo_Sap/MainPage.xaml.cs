﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using Xamarin.Forms.Xaml;

namespace PlatInfo_Sap
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
            Children.Add(new NomalMode());
            Children.Add(new PlatFormType());
        }
    }
}