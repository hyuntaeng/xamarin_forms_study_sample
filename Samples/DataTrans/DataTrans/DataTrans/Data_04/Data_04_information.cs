﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataTrans.Data_04
{
    public class Data_04_information
    {
        public Data_04_information()
        {
            Date = DateTime.Today;
        }

        public string Name { set; get; }

        public string Email { set; get; }

        public string Language { set; get; }

        public DateTime Date { set; get; }

        public override string ToString()
        {
            return String.Format("{0} / {1} / {2} / {3:d}",
                                 String.IsNullOrWhiteSpace(Name) ? "???" : Name,
                                 String.IsNullOrWhiteSpace(Email) ? "???" : Email,
                                 String.IsNullOrWhiteSpace(Language) ? "???" : Language,
                                 Date);
        }
    }
}
