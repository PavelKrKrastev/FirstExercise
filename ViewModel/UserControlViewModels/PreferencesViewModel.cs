﻿using NemetschekFirstAssigment.ViewModel.MainViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.ViewModel.UserControlViewModels
{
    class PreferencesViewModel : BaseViewModel
    {
        private bool _checkBoxValue;

        public bool CheckBoxValue
        {
            get { return _checkBoxValue; }
            set
            {
                _checkBoxValue = value;
                RaisePropertyChangedEvent("CheckBoxValue");
            }
        }

        private string _lblValue;

        public string LblValue
        {
            get { return _lblValue; }
            set
            {
                _lblValue = value;
                RaisePropertyChangedEvent("LblValue");
            }
        }

        public PreferencesViewModel()
        {
            CheckBoxValue = false;
            LblValue = "Preferences View Model";
        }
    }
}
