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

        public int Index { get; set; }

        public MainViewModel()
        {
            AllModels = new ObservableCollection<object>
            {
                #region General
                new GeneralViewModel("General", new List<GeneralModel>()
                {
                    new GeneralModel("Options", new OptionsView()),
                    new GeneralModel("Preferences", new PreferencesView()),
                    new GeneralModel("Settings", new SettingsView()),
                }),
                #endregion

                #region Tools
                new GeneralViewModel("Tools", new List<GeneralModel>()
                {
                    new GeneralModel("Tools", new ToolsView())
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

