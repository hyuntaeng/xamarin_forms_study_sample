﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;

using Xamarin.Forms;

namespace SimpleMultiplier
{
	public class ViewModelDemo : INotifyPropertyChanged
    {
        double multiplicand, multiplier, product;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Multiplicand
        {
            set
            {
                if (multiplicand != value)
                {
                    multiplicand = value;
                    OnPropertyChanged("Multiplicand");
                    UpdateProduct();
                }
            }
            get
            {
                return multiplicand;
            }
        }

        public double Multiplier
        {
            set
            {
                if (multiplier != value)
                {
                    multiplier = value;
                    OnPropertyChanged("Multiplier");
                    UpdateProduct();
                }
            }
            get
            {
                return multiplier;
            }
        }

        public double Product
        {
            protected set
            {
                if (product != value)
                {
                    product = value;
                    OnPropertyChanged("Product");
                }
            }
            get
            {
                return product;
            }
        }

        void UpdateProduct()
        {
            Product = Multiplicand * Multiplier;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}