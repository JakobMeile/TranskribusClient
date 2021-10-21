﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using TrClient;
using System.Windows.Media;

namespace TrClient
{
    public class clsTrBaseLineFilter : INotifyPropertyChanged
    {
        private bool _coordinatesPositive = true;
        public bool CoordinatesPositive
        {
            get { return _coordinatesPositive; }
            set
            {
                _coordinatesPositive = value;
                NotifyPropertyChanged("CoordinatesPositive");
            }
        }

        private bool _baseLineStraight = true;
        public bool BaseLineStraight
        {
            get { return _baseLineStraight; }
            set
            {
                _baseLineStraight = value;
                NotifyPropertyChanged("BaseLineStraight");
            }
        }

        private bool _baseLineDirectionOK = true;
        public bool BaseLineDirectionOK
        {
            get { return _baseLineDirectionOK; }
            set
            {
                _baseLineDirectionOK = value;
                NotifyPropertyChanged("BaseLineDirectionOK");
            }
        }


        // Constructor
        public clsTrBaseLineFilter()
        {
        }

        public void Reset()
        {
            CoordinatesPositive = true;
            BaseLineStraight = true;
            BaseLineDirectionOK = true;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
