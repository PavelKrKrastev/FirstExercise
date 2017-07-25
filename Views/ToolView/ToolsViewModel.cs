using NemetschekFirstAssigment.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.Views.ToolView
{
    class ToolsViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public bool CheckBox1Value { get; set; }
        public bool CheckBox2Value { get; set; }
        public bool CheckBox3Value { get; set; }

        public bool RadioButtonValue { get; set; }

        public List<String> ToolsList { get; set; }


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
