using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CommandBind
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class MainPageViewMode : ViewModelBase
    {
        int xOffset = 0;    // ranges from -2 to 2
        int yOffset = 0;    // ranges from -2 to 2
        Rectangle _boxPosition = new Rectangle(0.5, 0.5, 0.2, 0.2);

        public Rectangle BoxPosition
        {
            get { return _boxPosition;  }
            set
            {
                _boxPosition = value;
                OnPropertyChanged("BoxPosition");
            }
        }
    
        public ICommand MoveCommand
        {
            get { return new Command<string>(ExecuteMove, CanExecuteMove); }
        }

        void ExecuteMove(string direction)
        {
            switch (direction)
            {
                case "left": xOffset--; break;
                case "right": xOffset++; break;
                case "up": yOffset--; break;
                case "down": yOffset++; break;
            }

      

            BoxPosition = new Rectangle((xOffset + 2) / 4.0,
                                (yOffset + 2) / 4.0, 0.2, 0.2);

            OnPropertyChanged("MoveCommand");
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
