using NemetschekFirstAssigment.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NemetschekFirstAssigment.Views.ToolView
{
    class ToolsViewModel : BaseViewModel
    {
        public bool CheckBox1Value { get; set; }
        public bool CheckBox2Value { get; set; }
        public bool CheckBox3Value { get; set; }

        public bool RadioButtonValue { get; set; }

        public List<String> ToolsList { get; set; }


        public ToolsViewModel()
        {
            this.ToolsList = new List<String>();
            ToolsList.Add(Doc.Root.Element("Tools").Element("ListBoxItem1").Attribute("Content").Value);
            ToolsList.Add(Doc.Root.Element("Tools").Element("ListBoxItem2").Attribute("Content").Value);
            ToolsList.Add(Doc.Root.Element("Tools").Element("ListBoxItem3").Attribute("Content").Value);

            CheckBox1Value = Convert.ToBoolean(Doc.Root.Element("Tools").Element("ToolsTab").Attribute("CheckBox1Value").Value);
            CheckBox2Value = Convert.ToBoolean(Doc.Root.Element("Tools").Element("ToolsTab").Attribute("CheckBox2Value").Value);
            CheckBox3Value = Convert.ToBoolean(Doc.Root.Element("Tools").Element("ToolsTab").Attribute("CheckBox3Value").Value);

            RadioButtonValue = Convert.ToBoolean(Doc.Root.Element("Tools").Element("ToolsTab").Attribute("RadioButtonValue").Value);
        }
    }
}
