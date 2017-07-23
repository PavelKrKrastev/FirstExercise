using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.ViewModel.UserControlViewModels
{
    class ToolsViewModel
    {
        public ObservableCollection<String> ToolsList { get; set; }

        private bool _checkBox1Value;

        public bool CheckBox1Value
        {
            get { return _checkBox1Value; }
            set { _checkBox1Value = value; }
        }

        private bool _checkBox2Value;

        public bool CheckBox2Value
        {
            get { return _checkBox2Value; }
            set { _checkBox2Value = value; }
        }

        private bool _checkBox3Value;

        public bool CheckBox3Value
        {
            get { return _checkBox3Value; }
            set { _checkBox3Value = value; }
        }

        private bool _radioButtonValue;

        public bool RadioButtonValue
        {
            get { return _radioButtonValue;}
            set { _radioButtonValue = value;}
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
