using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using System.Windows.Input;

namespace CommandBind
{
	public partial class MainPage : ContentPage
	{
        MainPageViewMode _vm;
        

        public MainPage()
		{
            
            _vm = new MainPageViewMode();
            BindingContext = _vm; 

            InitializeComponent();
		}

        
    }
}
