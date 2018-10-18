﻿using System;
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
        int xOffset = 0;    // ranges from -2 to 2
        int yOffset = 0;    // ranges from -2 to 2

        public MainPage()
		{
            MoveCommand = new Command<string>(ExecuteMove, CanExecuteMove);

            InitializeComponent();
		}

        public ICommand MoveCommand { private set; get; }

        void ExecuteMove(string direction)
        {
            switch (direction)
            {
                case "left": xOffset--; break;
                case "right": xOffset++; break;
                case "up": yOffset--; break;
                case "down": yOffset++; break;
            }

            ((Command)MoveCommand).ChangeCanExecute();

            AbsoluteLayout.SetLayoutBounds(boxView,
                new Rectangle((xOffset + 2) / 4.0,
                                (yOffset + 2) / 4.0, 0.2, 0.2));
        }

        bool CanExecuteMove(string direction)
        {
            switch (direction)
            {
                case "left": return xOffset > -2;
                case "right": return xOffset < 2;
                case "up": return yOffset > -2;
                case "down": return yOffset < 2;
            }
            return false;
        }
    }
}
