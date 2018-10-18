using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MVVM_Sample
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

    public class MainPageViewModel : ViewModelBase
    {
        string lbl_text = "0";

        int nCount;

        public string TargetLabel
        {
            private set
            {
                if (lbl_text != value)
                {
                    lbl_text = value;
                    OnPropertyChanged("TargetLabel");
                }
            }
            get
            {
                return lbl_text;
            }
        }

        public MainPageViewModel()
        {
            TargetLabel = "1";

            nCount = 0;

            BtnClicked = new Command(
                execute: () =>
                {
                    ++nCount;

                    TargetLabel = nCount.ToString();
                    OnPropertyChanged("lbl_text");
                });
        }

        public ICommand BtnClicked { private set; get; }
    }
}