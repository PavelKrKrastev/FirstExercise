using NemetschekFirstAssigment.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NemetschekFirstAssigment.Models;
using NemetschekFirstAssigment.Views;
using System.Xml.Linq;

namespace NemetschekFirstAssigment.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        private ObservableCollection<object> _allModels;

        public ObservableCollection<object> AllModels
        {
            get { return _allModels; }
            set
            {
                _allModels = value;
                RaisePropertyChangedEvent("AllModels");
            }
        }

        public MainViewModel()
        {
            AllModels = new ObservableCollection<object>
            {
                #region General
                new GeneralViewModel(Doc.Root.Element("General").Attribute("Name").Value, new List<GeneralModel>()
                {
                    new GeneralModel(Doc.Root.Element("General").Element("GeneralTab1").Attribute("Name").Value, new OptionsView()),
                    new GeneralModel(Doc.Root.Element("General").Element("GeneralTab2").Attribute("Name").Value, new PreferencesView()),
                    new GeneralModel(Doc.Root.Element("General").Element("GeneralTab3").Attribute("Name").Value, new SettingsView()),
                }),
                #endregion

                #region Tools
                new GeneralViewModel(Doc.Root.Element("Tools").Attribute("Name").Value, new List<GeneralModel>()
                {
                    new GeneralModel(Doc.Root.Element("Tools").Element("ToolsTab").Attribute("Name").Value, new ToolsView())
                }),
                #endregion

                #region Window
                new GeneralViewModel(Doc.Root.Element("Window").Attribute("Name").Value, new List<GeneralModel>()
                {
                    new GeneralModel(Doc.Root.Element("Window").Element("WindowTab1").Attribute("Name").Value, new ViewView()),
                    new GeneralModel(Doc.Root.Element("Window").Element("WindowTab2").Attribute("Name").Value, new ResolutionView() ),
                }),
                #endregion

                #region Advanced
                new GeneralViewModel(Doc.Root.Element("Advanced").Attribute("Name").Value, new List<GeneralModel>()
                {               
                    new GeneralModel(Doc.Root.Element("Advanced").Element("AdvancedTab1").Attribute("Name").Value, new Advanced1View()),
                    new GeneralModel(Doc.Root.Element("Advanced").Element("AdvancedTab2").Attribute("Name").Value, new Advanced2View()),
                    new GeneralModel(Doc.Root.Element("Advanced").Element("AdvancedTab3").Attribute("Name").Value, new Advanced3View()),
                    new GeneralModel(Doc.Root.Element("Advanced").Element("AdvancedTab4").Attribute("Name").Value, new Advanced4View()),
                }),
                #endregion

            };
        }
    }
}

