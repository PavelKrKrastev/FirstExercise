using NemetschekFirstAssigment.Models;
using NemetschekFirstAssigment.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace NemetschekFirstAssigment.ViewModel
{
    public class GeneralViewModel : BaseViewModel
    {
        private static string xmlUrl = @"XmlFile\Information.xml";

        GeneralModel gModel = new GeneralModel();

        #region Constructor properties
        public string ListContent { get; set; }
        public string TabName { get; set; }
        public object TabContent { get; set; }
        public List<object> Subcategories { get; set; }
        #endregion

        #region GeneralView Properties
        public string GeneralTab1
        {
            get { return gModel.GeneralTab1; }
            set { GeneralTab1 = gModel.GeneralTab1; RaisePropertyChangedEvent("GeneralTab1"); }
        }

        public string GeneralTab2
        {
            get { return gModel.GeneralTab2; }
            set { GeneralTab2 = gModel.GeneralTab2; RaisePropertyChangedEvent("GeneralTab2"); }
        }

        public string GeneralTab3
        {
            get { return gModel.GeneralTab3; }
            set { GeneralTab3 = gModel.GeneralTab3; RaisePropertyChangedEvent("GeneralTab3"); }
        }

        public bool GeneralCheckBox1
        {
            get { return gModel.GeneralCheckBox1; }
            set { GeneralCheckBox1 = gModel.GeneralCheckBox1; RaisePropertyChangedEvent("GeneralCheckBox1"); }
        }

        public bool GeneralCheckBox2
        {
            get { return gModel.GeneralCheckBox2; }
            set { GeneralCheckBox2 = gModel.GeneralCheckBox2; RaisePropertyChangedEvent("GeneralCheckBox2"); }
        }

        public bool GeneralCheckBox3
        {
            get { return gModel.GeneralCheckBox3; }
            set { GeneralCheckBox3 = gModel.GeneralCheckBox3; RaisePropertyChangedEvent("GeneralCheckBox3"); }
        }

        public string GeneralLabel
        {
            get { return gModel.GeneralLabel; }
            set { GeneralLabel = gModel.GeneralLabel; RaisePropertyChangedEvent("GeneralLabel"); }
        }

        public string GeneralValue
        {
            get { return gModel.GeneralValue; }
            set { GeneralValue = gModel.GeneralValue; RaisePropertyChangedEvent("GeneralValue"); }
        }
        #endregion

        #region ToolsView Properties

        public string ToolsTab
        {
            get { return gModel.ToolsTab; }
            set { ToolsTab = gModel.ToolsTab; RaisePropertyChangedEvent("ToolsTab"); }
        }

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

        public string ToolsValue
        {
            get { return gModel.ToolsValue; }
            set { ToolsValue = gModel.ToolsValue; RaisePropertyChangedEvent("ToolsValue"); }
        }
        #endregion

        #region WindowView Properties

        public string WindowTab1
        {
            get { return gModel.WindowTab1; }
            set { WindowTab1 = gModel.WindowTab1; RaisePropertyChangedEvent("WindowTab1"); }
        }

        public string WindowTab2
        {
            get { return gModel.WindowTab2; }
            set { WindowTab2 = gModel.WindowTab2; RaisePropertyChangedEvent("WindowTab2"); }
        }

        public bool WindowCheckBox1
        {
            get { return gModel.WindowCheckBox1; }
            set { WindowCheckBox1 = gModel.WindowCheckBox1; RaisePropertyChangedEvent("WindowCheckBox1"); }
        }

        public bool WindowCheckBox2
        {
            get { return gModel.WindowCheckBox2; }
            set { WindowCheckBox2 = gModel.WindowCheckBox2; RaisePropertyChangedEvent("WindowCheckBox2"); }
        }

        public string WindowLabel
        {
            get { return gModel.WindowLabel; }
            set { WindowLabel = gModel.WindowLabel; RaisePropertyChangedEvent("WindowLabel"); }
        }

        public string WindowValue
        {
            get { return gModel.WindowValue; }
            set { WindowValue = gModel.WindowValue; RaisePropertyChangedEvent("WindowValue"); }
        }
        #endregion

        #region AdvancedView Properties

        public string AdvancedTab1
        {
            get { return gModel.AdvancedTab1; }
            set { AdvancedTab1 = gModel.AdvancedTab1; RaisePropertyChangedEvent("AdvancedTab1"); }
        }

        public string AdvancedTab2
        {
            get { return gModel.AdvancedTab2; }
            set { AdvancedTab2 = gModel.AdvancedTab2; RaisePropertyChangedEvent("AdvancedTab2"); }
        }

        public string AdvancedTab3
        {
            get { return gModel.AdvancedTab3; }
            set { AdvancedTab3 = gModel.AdvancedTab3; RaisePropertyChangedEvent("AdvancedTab3"); }
        }

        public string AdvancedTab4
        {
            get { return gModel.AdvancedTab4; }
            set { AdvancedTab4 = gModel.AdvancedTab4; RaisePropertyChangedEvent("AdvancedTab4"); }
        }

        public bool AdvancedCheckBox2
        {
            get { return gModel.AdvancedCheckBox2; }
            set { AdvancedCheckBox2 = gModel.AdvancedCheckBox2; RaisePropertyChangedEvent("AdvancedCheckBox2"); }
        }

        public bool AdvancedCheckBox3
        {
            get { return gModel.AdvancedCheckBox3; }
            set { AdvancedCheckBox3 = gModel.AdvancedCheckBox3; RaisePropertyChangedEvent("AdvancedCheckBox3"); }
        }

        public bool AdvancedCheckBox4
        {
            get { return gModel.AdvancedCheckBox4; }
            set { AdvancedCheckBox4 = gModel.AdvancedCheckBox4; RaisePropertyChangedEvent("AdvancedCheckBox4"); }
        }

        public string AdvancedComboBox1Item1
        {
            get { return gModel.AdvancedComboBox1Item1; }
            set { AdvancedComboBox1Item1 = gModel.AdvancedComboBox1Item1; RaisePropertyChangedEvent("AdvancedComboBox1Item1"); }
        }

        public string AdvancedComboBox1Item2
        {
            get { return gModel.AdvancedComboBox1Item2; }
            set { AdvancedComboBox1Item2 = gModel.AdvancedComboBox1Item2; RaisePropertyChangedEvent("AdvancedComboBox1Item2"); }
        }

        public string AdvancedComboBox2Item1
        {
            get { return gModel.AdvancedComboBox2Item1; }
            set { AdvancedComboBox2Item1 = gModel.AdvancedComboBox2Item1; RaisePropertyChangedEvent("AdvancedComboBox2Item1"); }
        }

        public string AdvancedComboBox2Item2
        {
            get { return gModel.AdvancedComboBox2Item2; }
            set { AdvancedComboBox2Item2 = gModel.AdvancedComboBox2Item2; RaisePropertyChangedEvent("AdvancedComboBox2Item2"); }
        }

        public string AdvancedComboBox3Item1
        {
            get { return gModel.AdvancedComboBox3Item1; }
            set { AdvancedComboBox3Item1 = gModel.AdvancedComboBox3Item1; RaisePropertyChangedEvent("AdvancedComboBox3Item1"); }
        }

        public string AdvancedComboBox3Item2
        {
            get { return gModel.AdvancedComboBox3Item2; }
            set { AdvancedComboBox3Item2 = gModel.AdvancedComboBox3Item2; RaisePropertyChangedEvent("AdvancedComboBox3Item2"); }
        }

        public string AdvancedLabel
        {
            get { return gModel.AdvancedLabel; }
            set { AdvancedLabel = gModel.AdvancedLabel; RaisePropertyChangedEvent("AdvancedLabel"); }
        }

        public string AdvancedValue
        {
            get { return gModel.AdvancedValue; }
            set { AdvancedValue = gModel.AdvancedValue; RaisePropertyChangedEvent("AdvancedValue"); }
        }
        #endregion

        #region Constructors
        public GeneralViewModel()
        {
            gModel = GeneralViewModel.LoadXml(xmlUrl);
        }

        public GeneralViewModel(string ListContent, List<object> Subcategories)
        {
            this.ListContent = ListContent;
            this.Subcategories = Subcategories;
        }

        public GeneralViewModel(string tabName, object tabContent)
        {
            this.TabName = tabName;
            this.TabContent = tabContent;
        }
        #endregion

        public static GeneralModel LoadXml(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(GeneralModel));
                return (GeneralModel)XML.Deserialize(stream);
            }
        }

        public void SaveXml(string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(GeneralModel));
                XML.Serialize(stream,this.gModel);
            }
        }
    }
}
