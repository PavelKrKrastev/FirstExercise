using NemetschekFirstAssigment.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.Views.ToolView
{
    class ToolsViewModel : BaseViewModel
    {
        #region private variables
        private string _name;
        private bool _checkBox1Value;
        private bool _checkBox2Value;
        private bool _checkBox3Value;
        private bool _radioButtonValue;
        private List<String> _toolsList;
        #endregion

        #region public properties
        public bool CheckBox1Value
        {
            get { return _checkBox1Value; }
            set { _checkBox1Value = value; }
        }

        public bool CheckBox2Value
        {
            get { return _checkBox2Value; }
            set { _checkBox2Value = value; }
        }

        public bool CheckBox3Value
        {
            get { return _checkBox3Value; }
            set { _checkBox3Value = value; }
        }

        public bool RadioButtonValue
        {
            get { return _radioButtonValue; }
            set { _radioButtonValue = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<String> ToolsList
        {
            get { return _toolsList; }
            set { _toolsList = value; }
        }
        #endregion

        public ToolsViewModel()
        {
            this.ToolsList = new List<String>() { "Hammer", "Hex Key", "Screw Driver" };

            CheckBox1Value = true;
            CheckBox2Value = false;
            CheckBox3Value = true;

            RadioButtonValue = true;
        }
    }
}
