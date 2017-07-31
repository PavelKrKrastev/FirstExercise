using NemetschekFirstAssigment.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NemetschekFirstAssigment.Views;
using System;

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

        public string ProblemLabel
        {
            get { return "File not loaded correctly"; }
        }
        public MainViewModel()
        {
            try
            {
                AllModels = new ObservableCollection<object>
            {
                #region General
                new GeneralViewModel(GeneralName, new List<object>()
                {
                    new GeneralViewModel(GeneralTab1Name, new OptionsView()),
                    new GeneralViewModel(GeneralTab2Name, new PreferencesView()),
                    new GeneralViewModel(GeneralTab3Name, new SettingsView()),
                }),
                #endregion

                #region Tools
                new GeneralViewModel(ToolsName, new List<object>()
                {
                    new GeneralViewModel(ToolsTabName, new ToolsView())
                }),
                #endregion

                #region Window
                new GeneralViewModel(WindowName, new List<object>()
                {
                    new GeneralViewModel(WindowTab1Name, new ViewView()),
                    new GeneralViewModel(WindowTab2Name, new ResolutionView() ),
                }),
                #endregion

                #region Advanced
                new GeneralViewModel(AdvancedName, new List<object>()
                {               
                    new GeneralViewModel(AdvancedTab1Name, new Advanced1View()),
                    new GeneralViewModel(AdvancedTab2Name, new Advanced2View()),
                    new GeneralViewModel(AdvancedTab3Name, new Advanced3View()),
                    new GeneralViewModel(AdvancedTab4Name, new Advanced4View()),
                }),
                #endregion

            };
            }

            catch (NullReferenceException)
            {

            }
        }
    }
}

