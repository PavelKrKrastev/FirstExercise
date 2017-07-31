using System.ComponentModel;
using System.IO;
using System.Xml.Linq;

namespace NemetschekFirstAssigment.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private static string xmlUrl = @"XmlFile\Information.xml";

        public XDocument Doc;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #region XML properties
        public string GeneralName { get; set; }
        public string GeneralTab1Name { get; set; }
        public string GeneralTab2Name { get; set; }
        public string GeneralTab3Name { get; set; }
        public string ToolsName { get; set; }
        public string ToolsTabName { get; set; }
        public string WindowName { get; set; }
        public string WindowTab1Name { get; set; }
        public string WindowTab2Name { get; set; }
        public string AdvancedName { get; set; }
        public string AdvancedTab1Name { get; set; }
        public string AdvancedTab2Name { get; set; }
        public string AdvancedTab3Name { get; set; }
        public string AdvancedTab4Name { get; set; }
        #endregion


        public BaseViewModel()
        {
            try
            {
                #region XML information
                Doc = XDocument.Load(xmlUrl);
                GeneralName = Doc.Root.Element("General").Attribute("Name").Value;
                GeneralTab1Name = Doc.Root.Element("General").Element("GeneralTab1").Value;
                GeneralTab2Name = Doc.Root.Element("General").Element("GeneralTab2").Value;
                GeneralTab3Name = Doc.Root.Element("General").Element("GeneralTab3").Value;
                ToolsName = Doc.Root.Element("Tools").Attribute("Name").Value;
                ToolsTabName = Doc.Root.Element("Tools").Element("ToolsTab").Value;
                WindowName = Doc.Root.Element("Window").Attribute("Name").Value;
                WindowTab1Name = Doc.Root.Element("Window").Element("WindowTab1").Value;
                WindowTab2Name = Doc.Root.Element("Window").Element("WindowTab2").Value;
                AdvancedName = Doc.Root.Element("Advanced").Attribute("Name").Value;
                AdvancedTab1Name = Doc.Root.Element("Advanced").Element("AdvancedTab1").Value;
                AdvancedTab2Name = Doc.Root.Element("Advanced").Element("AdvancedTab2").Value;
                AdvancedTab3Name = Doc.Root.Element("Advanced").Element("AdvancedTab3").Value;
                AdvancedTab4Name = Doc.Root.Element("Advanced").Element("AdvancedTab4").Value;
                #endregion
            }

            catch (FileNotFoundException)
            {
            }
        }
    }
}
