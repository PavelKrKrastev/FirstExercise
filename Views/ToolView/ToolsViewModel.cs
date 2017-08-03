using NemetschekFirstAssigment.ViewModel;
using System;
using System.Collections.Generic;

namespace NemetschekFirstAssigment.Views.ToolView
{
    class ToolsViewModel : GeneralViewModel
    {
        public bool ToolsCheckBox1
        {
            get { return gModel.ToolsCheckBox1; }
            set { ToolsCheckBox1 = gModel.ToolsCheckBox1; RaisePropertyChangedEvent("ToolsCheckBox1"); }
        }

        public bool ToolsCheckBox2
        {
            get { return gModel.ToolsCheckBox2; }
            set { ToolsCheckBox2 = gModel.ToolsCheckBox2; RaisePropertyChangedEvent("ToolsCheckBox2"); }
        }

        public bool ToolsCheckBox3
        {
            get { return gModel.ToolsCheckBox3; }
            set { ToolsCheckBox3 = gModel.ToolsCheckBox3; RaisePropertyChangedEvent("ToolsCheckBox3"); }
        }

        public bool ToolsRadioButton
        {
            get { return gModel.ToolsRadioButton; }
            set { ToolsRadioButton = gModel.ToolsRadioButton; RaisePropertyChangedEvent("ToolsRadioButton"); }
        }

        public string ToolsListBox1
        {
            get { return gModel.ToolsListBox1; }
            set { ToolsListBox1 = gModel.ToolsListBox1; RaisePropertyChangedEvent("ToolsListBox1"); }
        }

        public string ToolsListBox2
        {
            get { return gModel.ToolsListBox2; }
            set { ToolsListBox2 = gModel.ToolsListBox2; RaisePropertyChangedEvent("ToolsListBox2"); }
        }

        public string ToolsListBox3
        {
            get { return gModel.ToolsListBox3; }
            set { ToolsListBox3 = gModel.ToolsListBox3; RaisePropertyChangedEvent("ToolsListBox3"); }
        }

        public string ToolsListBox4
        {
            get { return gModel.ToolsListBox4; }
            set { ToolsListBox4 = gModel.ToolsListBox4; RaisePropertyChangedEvent("ToolsListBox4"); }
        }

        public List<String> ToolsList { get; set; }


        public ToolsViewModel()
        {
            ToolsList = new List<string> {ToolsListBox1, ToolsListBox2, ToolsListBox3, ToolsListBox4 };
        }
    }
}
