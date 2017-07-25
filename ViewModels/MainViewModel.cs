using NemetschekFirstAssigment.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NemetschekFirstAssigment.Models;
using NemetschekFirstAssigment.Views;

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
                new GeneralViewModel("General", new List<TabContentModel>()
                {
                new TabContentModel("Options", new OptionsView()),
                new TabContentModel("Preferences", new PreferencesView()),
                new TabContentModel("Settings", new SettingsView()),
                }),
                #endregion

                #region Tools
                new GeneralViewModel("Tools", new List<TabContentModel>()
                {
                 new TabContentModel("Tools", new ToolsView())
                }),
                #endregion

                #region Window
                new GeneralViewModel("Window", new List<TabContentModel>()
                {
                new TabContentModel("View", new ViewView()),
                new TabContentModel("Resolution", new ResolutionView() ),
                }),
                #endregion

                #region Advanced
                new GeneralViewModel("Advanced", new List<TabContentModel>()
                {               
                new TabContentModel("Advanced 1", new Advanced1View()),
                new TabContentModel("Advanced 2", new Advanced2View()),
                new TabContentModel("Advanced 3", new Advanced3View()),
                new TabContentModel("Advanced 4", new Advanced4View()),
                }),
                #endregion

            };
        }
    }
}

