﻿using NemetschekFirstAssigment.ViewModel.MainViewModels;

namespace NemetschekFirstAssigment.View.WindowView
{
    class ResolutionViewModel : BaseViewModel
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

        public ResolutionViewModel()
        {
            CheckBoxValue = true;
            LblValue = "Resolution View Model";
        }

    }
}