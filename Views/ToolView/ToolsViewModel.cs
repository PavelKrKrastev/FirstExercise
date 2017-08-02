using NemetschekFirstAssigment.ViewModel;
using System;
using System.Collections.Generic;

namespace NemetschekFirstAssigment.Views.ToolView
{
    class ToolsViewModel : GeneralViewModel
    {
        public bool CheckBox1Value { get; set; }
        public bool CheckBox2Value { get; set; }
        public bool CheckBox3Value { get; set; }

        public bool RadioButtonValue { get; set; }

        public List<String> ToolsList { get; set; }


        public ToolsViewModel()
        {
            CheckBox1Value = ToolsCheckBox1;
            CheckBox2Value = ToolsCheckBox2;
            CheckBox3Value = ToolsCheckBox3;

            RadioButtonValue = ToolsRadioButton;

            ToolsList = new List<string> {ToolsListBox1, ToolsListBox2, ToolsListBox3, ToolsListBox4 };
        }
    }
}
