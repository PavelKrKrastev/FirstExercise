﻿using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    class SettingsViewModel : BaseViewModel
    {

        #region private variables
        private bool _checkBoxValue;
        private string _lblValue;
        #endregion

        #region public properties
        public bool CheckBoxValue
        {
            get { return _checkBoxValue; }
            set { _checkBoxValue = value; }
        }

        public string LblValue
        {
            get { return _lblValue; }
            set { _lblValue = value; }
        }
        #endregion

        public SettingsViewModel()
        {
            CheckBoxValue = true;
            LblValue = "Settings View Model";
        }

    }
}
