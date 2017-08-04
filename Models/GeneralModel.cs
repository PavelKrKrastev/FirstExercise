using System;
using System.Xml.Serialization;

namespace NemetschekFirstAssigment.Models
{
    [Serializable]
    [XmlRoot("WindowContent")]
    public class GeneralModel
    {
        [XmlElement("GeneralTab1")]
        public string GeneralTab1 { get; set; }
        [XmlElement("GeneralTab2")]
        public string GeneralTab2 { get; set; }
        [XmlElement("GeneralTab3")]
        public string GeneralTab3 { get; set; }
        [XmlElement("GeneralLabel")]
        public string GeneralLabel { get; set; }
        [XmlElement("GeneralCheckBox1")]
        public bool GeneralCheckBox1 { get; set; }
        [XmlElement("GeneralCheckBox2")]
        public bool GeneralCheckBox2 { get; set; }
        [XmlElement("GeneralCheckBox3")]
        public bool GeneralCheckBox3 { get; set; }
        [XmlElement("GeneralName")]
        public string GeneralValue { get; set; }


        [XmlElement("ToolsTab")]
        public string ToolsTab { get; set; }
        [XmlElement("ToolsCheckBox1")]
        public bool ToolsCheckBox1 { get; set; }
        [XmlElement("ToolsCheckBox2")]
        public bool ToolsCheckBox2 { get; set; }
        [XmlElement("ToolsCheckBox3")]
        public bool ToolsCheckBox3 { get; set; }
        [XmlElement("ToolsRadioButton1")]
        public bool ToolsRadioButton1 { get; set; }
        [XmlElement("ToolsRadioButton2")]
        public bool ToolsRadioButton2 { get; set; }
        [XmlElement("ToolsRadioButton3")]
        public bool ToolsRadioButton3 { get; set; }
        [XmlElement("ToolsListBoxItem1")]
        public string ToolsListBox1 { get; set; }
        [XmlElement("ToolsListBoxItem2")]
        public string ToolsListBox2 { get; set; }
        [XmlElement("ToolsListBoxItem3")]
        public string ToolsListBox3 { get; set; }
        [XmlElement("ToolsListBoxItem4")]
        public string ToolsListBox4 { get; set; }
        [XmlElement("ToolsListBoxSelectedItem")]
        public string ToolsListBoxSelectedItem { get; set; }
        [XmlElement("ToolsName")]
        public string ToolsValue { get; set; }

        [XmlElement("Windowlabel")]
        public string WindowLabel { get; set; }
        [XmlElement("WindowTab1")]
        public string WindowTab1 { get; set; }
        [XmlElement("WindowTab2")]
        public string WindowTab2 { get; set; }
        [XmlElement("WindowCheckBox1")]
        public bool WindowCheckBox1 { get; set; }
        [XmlElement("WindowCheckBox2")]
        public bool WindowCheckBox2 { get; set; }
        [XmlElement("WindowName")]
        public string WindowValue { get; set; }

        [XmlElement("AdvancedLabel")]
        public string AdvancedLabel { get; set; }
        [XmlElement("AdvancedTab1")]
        public string AdvancedTab1 { get; set; }
        [XmlElement("AdvancedTab2")]
        public string AdvancedTab2 { get; set; }
        [XmlElement("AdvancedTab3")]
        public string AdvancedTab3 { get; set; }
        [XmlElement("AdvancedTab4")]
        public string AdvancedTab4 { get; set; }
        [XmlElement("AdvancedCheckBox2")]
        public bool AdvancedCheckBox2 { get; set; }
        [XmlElement("AdvancedCheckBox3")]
        public bool AdvancedCheckBox3 { get; set; }
        [XmlElement("AdvancedCheckBox4")]
        public bool AdvancedCheckBox4 { get; set; }
        [XmlElement("AdvancedComboBox1Item1")]
        public string AdvancedComboBox1Item1 { get; set; }
        [XmlElement("AdvancedComboBox1Item2")]
        public string AdvancedComboBox1Item2 { get; set; }
        [XmlElement("AdvancedComboBox2Item1")]
        public string AdvancedComboBox2Item1 { get; set; }
        [XmlElement("AdvancedComboBox2Item2")]
        public string AdvancedComboBox2Item2 { get; set; }
        [XmlElement("AdvancedComboBox3Item1")]
        public string AdvancedComboBox3Item1 { get; set; }
        [XmlElement("AdvancedComboBox3Item2")]
        public string AdvancedComboBox3Item2 { get; set; }
        [XmlElement("AdvancedComboBox1SelectedItem")]
        public string AdvancedComboBox1SelectedItem { get; set; }
        [XmlElement("AdvancedComboBox2SelectedItem")]
        public string AdvancedComboBox2SelectedItem { get; set; }
        [XmlElement("AdvancedComboBox3SelectedItem")]
        public string AdvancedComboBox3SelectedItem { get; set; }
        [XmlElement("AdvancedName")]
        public string AdvancedValue { get; set; }

        public GeneralModel() { }
    }
}
