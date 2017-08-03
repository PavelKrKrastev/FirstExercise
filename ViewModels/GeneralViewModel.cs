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

        public GeneralModel gModel = new GeneralModel();

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
