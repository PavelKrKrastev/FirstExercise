﻿using NemetschekFirstAssigment.ViewModel.MainViewModels;

namespace NemetschekFirstAssigment.View.GeneralView
{
    public class OptionsViewModel : BaseViewModel
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

        public OptionsViewModel()
        {
            CheckBoxValue = true;
            LblValue = "Options View Model";
        }
    }
}