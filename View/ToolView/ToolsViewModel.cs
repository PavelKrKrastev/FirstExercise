using NemetschekFirstAssigment.ViewModel.MainViewModels;
using System;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.View.ToolView
{
    class ToolsViewModel : BaseViewModel
    {
        private ObservableCollection<String> _toolsList;

        public ObservableCollection<String> ToolsList
        {
            get { return _toolsList; }
            set
            {
                _toolsList = value;
                RaisePropertyChangedEvent("ToolsList");
            }
        }

        private bool _checkBox1Value;

        public bool CheckBox1Value
        {
            get { return _checkBox1Value; }
            set
            {
                _checkBox1Value = value;
                RaisePropertyChangedEvent("CheckBox1Value");
            }
        }

        private bool _checkBox2Value;

        public bool CheckBox2Value
        {
            get { return _checkBox2Value; }
            set
            {
                _checkBox2Value = value;
                RaisePropertyChangedEvent("CheckBox2Value");
            }
        }

        private bool _checkBox3Value;

        public bool CheckBox3Value
        {
            get { return _checkBox3Value; }
            set
            {
                _checkBox3Value = value;
                RaisePropertyChangedEvent("CheckBox3Value");
            }
        }

        private bool _radioButtonValue;

        public bool RadioButtonValue
        {
            get { return _radioButtonValue; }
            set
            {
                _radioButtonValue = value;
                RaisePropertyChangedEvent("RadioButtonValue");
            }
        }

        public ToolsViewModel()
        {
            this.ToolsList = new ObservableCollection<String>();
            ToolsList.Add("Wrench");
            ToolsList.Add("Screw Driver");
            ToolsList.Add("Hammer");
            ToolsList.Add("Hex Key");

            CheckBox1Value = true;
            CheckBox2Value = false;
            CheckBox3Value = true;

            RadioButtonValue = true;
        }
    }
}
