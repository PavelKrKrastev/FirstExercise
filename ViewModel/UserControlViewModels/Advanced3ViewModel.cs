﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.ViewModel.UserControlViewModels
{
    class Advanced3ViewModel
    {

        private bool _checkBoxValue;

        public bool CheckBoxValue
        {
            get { return _checkBoxValue; }
            set { _checkBoxValue = value; }
        }

        private string _lblValue;

        public string LblValue
        {
            get { return _lblValue; }
            set { _lblValue = value; }
        }

        public Advanced3ViewModel()
        {
            CheckBoxValue = false;
            LblValue = "Advanced 3 View Model";
        }

    }
}
