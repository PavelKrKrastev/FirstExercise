using System;
using System.Xml.Serialization;

namespace NemetschekFirstAssigment.Models
{
    [Serializable]
    [XmlRoot("WindowContent")]
    public class GeneralModel
    {
        [XmlElement]
        public string GeneralTab1 { get; set; }
        [XmlElement]
        public string GeneralTab2 { get; set; }
        [XmlElement]
        public string GeneralTab3 { get; set; }
        [XmlElement]
        public string GeneralLabel { get; set; }
        [XmlElement]
        public bool GeneralCheckBox1 { get; set; }
        [XmlElement]
        public bool GeneralCheckBox2 { get; set; }
        [XmlElement]
        public bool GeneralCheckBox3 { get; set; }
        [XmlElement]
        public string GeneralValue { get; set; }

        [XmlElement]
        public string ToolsTab { get; set; }
        [XmlElement]
        public bool ToolsCheckBox1 { get; set; }
        [XmlElement]
        public bool ToolsCheckBox2 { get; set; }
        [XmlElement]
        public bool ToolsCheckBox3 { get; set; }
        [XmlElement]
        public bool ToolsRadioButton1 { get; set; }
        [XmlElement]
        public bool ToolsRadioButton2 { get; set; }
        [XmlElement]
        public bool ToolsRadioButton3 { get; set; }
        [XmlElement]
        public string ToolsListBoxItem1 { get; set; }
        [XmlElement]
        public string ToolsListBoxItem2 { get; set; }
        [XmlElement]
        public string ToolsListBoxItem3 { get; set; }
        [XmlElement]
        public string ToolsListBoxItem4 { get; set; }
        [XmlElement]
        public string ToolsListBoxSelectedItem { get; set; }
        [XmlElement]
        public string ToolsValue { get; set; }

        [XmlElement]
        public string WindowLabel { get; set; }
        [XmlElement]
        public string WindowTab1 { get; set; }
        [XmlElement]
        public string WindowTab2 { get; set; }
        [XmlElement]
        public bool WindowCheckBox1 { get; set; }
        [XmlElement]
        public bool WindowCheckBox2 { get; set; }
        [XmlElement]
        public string WindowValue { get; set; }

        [XmlElement]
        public string AdvancedLabel { get; set; }
        [XmlElement]
        public string AdvancedTab1 { get; set; }
        [XmlElement]
        public string AdvancedTab2 { get; set; }
        [XmlElement]
        public string AdvancedTab3 { get; set; }
        [XmlElement]
        public string AdvancedTab4 { get; set; }
        [XmlElement]
        public bool AdvancedCheckBox2 { get; set; }
        [XmlElement]
        public bool AdvancedCheckBox3 { get; set; }
        [XmlElement]
        public bool AdvancedCheckBox4 { get; set; }
        [XmlElement]
        public string AdvancedComboBox1Item1 { get; set; }
        [XmlElement]
        public string AdvancedComboBox1Item2 { get; set; }
        [XmlElement]
        public string AdvancedComboBox2Item1 { get; set; }
        [XmlElement]
        public string AdvancedComboBox2Item2 { get; set; }
        [XmlElement]
        public string AdvancedComboBox3Item1 { get; set; }
        [XmlElement]
        public string AdvancedComboBox3Item2 { get; set; }
        [XmlElement]
        public string AdvancedComboBox1SelectedItem { get; set; }
        [XmlElement]
        public string AdvancedComboBox2SelectedItem { get; set; }
        [XmlElement]
        public string AdvancedComboBox3SelectedItem { get; set; }
        [XmlElement]
        public string AdvancedValue { get; set; }

        public GeneralModel() { }
    }
}
