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
                new GeneralViewModel("Window", new List<GeneralModel>()
                {
                    new GeneralModel("View", new ViewView()),
                    new GeneralModel("Resolution", new ResolutionView() ),
                }),
                #endregion

                #region Advanced
                new GeneralViewModel("Advanced", new List<GeneralModel>()
                {               
                    new GeneralModel("Advanced 1", new Advanced1View()),
                    new GeneralModel("Advanced 2", new Advanced2View()),
                    new GeneralModel("Advanced 3", new Advanced3View()),
                    new GeneralModel("Advanced 4", new Advanced4View()),
                }),
                #endregion

            };
        }
    }
}

