﻿using NemetschekFirstAssigment.ViewModel.MainViewModels;

namespace NemetschekFirstAssigment.ViewModel.UserControlViewModels
{
    class SettingsViewModel : BaseViewModel
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

        public SettingsViewModel()
        {
            CheckBoxValue = true;
            LblValue = "Settings View Model";
        }

    }
}
