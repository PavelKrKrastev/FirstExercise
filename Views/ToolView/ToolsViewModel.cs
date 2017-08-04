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
            set { gModel.ToolsCheckBox1 = value; RaisePropertyChangedEvent("ToolsCheckBox1"); }
        }

        public bool ToolsCheckBox2
        {
            get { return gModel.ToolsCheckBox2; }
            set { gModel.ToolsCheckBox2 = value; RaisePropertyChangedEvent("ToolsCheckBox2"); }
        }

        public bool ToolsCheckBox3
        {
            get { return gModel.ToolsCheckBox3; }
            set { gModel.ToolsCheckBox3 = value; RaisePropertyChangedEvent("ToolsCheckBox3"); }
        }

        public bool ToolsRadioButton1
        {
            get { return gModel.ToolsRadioButton1; }
            set { gModel.ToolsRadioButton1 = value; RaisePropertyChangedEvent("ToolsRadioButton1"); }
        }

        public bool ToolsRadioButton2
        {
            get { return gModel.ToolsRadioButton2; }
            set { gModel.ToolsRadioButton2 = value; RaisePropertyChangedEvent("ToolsRadioButton2"); }
        }

        public bool ToolsRadioButton3
        {
            get { return gModel.ToolsRadioButton3; }
            set { gModel.ToolsRadioButton3 = value; RaisePropertyChangedEvent("ToolsRadioButton3"); }
        }

        public string ToolsListBox1
        {
            get { return gModel.ToolsListBox1; }
            set { gModel.ToolsListBox1 = value; RaisePropertyChangedEvent("ToolsListBox1"); }
        }

        public string ToolsListBox2
        {
            get { return gModel.ToolsListBox2; }
            set { gModel.ToolsListBox2 = value; RaisePropertyChangedEvent("ToolsListBox2"); }
        }

        public string ToolsListBox3
        {
            get { return gModel.ToolsListBox3; }
            set { gModel.ToolsListBox3 = value; RaisePropertyChangedEvent("ToolsListBox3"); }
        }

        public string ToolsListBox4
        {
            get { return gModel.ToolsListBox4; }
            set { gModel.ToolsListBox4 = value; RaisePropertyChangedEvent("ToolsListBox4"); }
        }

        public string ToolsListBoxSelectedItem
        {
            get { return gModel.ToolsListBoxSelectedItem; }
            set { gModel.ToolsListBoxSelectedItem = value; RaisePropertyChangedEvent("ToolsListBoxSelectedItem"); }
        }

        public List<String> ToolsList { get; set; }


        public ToolsViewModel()
        {
            ToolsList = new List<string> { ToolsListBox1, ToolsListBox2, ToolsListBox3, ToolsListBox4 };
        }
    }
}
