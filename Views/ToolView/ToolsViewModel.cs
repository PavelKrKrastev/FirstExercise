using NemetschekFirstAssigment.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.Views.ToolView
{
    class ToolsViewModel : BaseViewModel
    {
        #region private variables
        private ObservableCollection<String> _toolsList;
        private bool _checkBox1Value;
        private bool _checkBox2Value;
        private bool _checkBox3Value;
        private bool _radioButtonValue;
        #endregion

        #region public properties
        public ObservableCollection<String> ToolsList
        {
            get { return _toolsList; }
            set { _toolsList = value; }
        }

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
        #endregion

        public ToolsViewModel()
        {
            this.ToolsList = new ObservableCollection<String>() { "Wrench", "Screw Driver", "Hammer", "Hex Key" };

            CheckBox1Value = true;
            CheckBox2Value = false;
            CheckBox3Value = true;

            RadioButtonValue = true;
        }
    }
}
