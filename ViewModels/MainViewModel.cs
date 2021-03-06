﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using NemetschekFirstAssigment.Views;
using System.Windows.Input;
using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.ViewModel
{
    public class MainViewModel : GeneralViewModel
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
                new GeneralViewModel(GeneralValue, 0, new List<object>()
                {
                    new GeneralViewModel(GeneralTab1, new OptionsView()),
                    new GeneralViewModel(GeneralTab2, new PreferencesView()),
                    new GeneralViewModel(GeneralTab3, new SettingsView()),
                }),
                #endregion

                #region Tools
                new GeneralViewModel(ToolsValue, 0, new List<object>()
                {
                    new GeneralViewModel(ToolsTab, new ToolsView())
                }),
                #endregion

                #region Window
                new GeneralViewModel(WindowValue, 0, new List<object>()
                {
                    new GeneralViewModel(WindowTab1, new ViewView()),
                    new GeneralViewModel(WindowTab2, new ResolutionView()),
                }),
                #endregion

                #region Advanced
                new GeneralViewModel(AdvancedValue, 0, new List<object>()
                {               
                    new GeneralViewModel(AdvancedTab1, new Advanced1View()),
                    new GeneralViewModel(AdvancedTab2, new Advanced2View()),
                    new GeneralViewModel(AdvancedTab3, new Advanced3View()),
                    new GeneralViewModel(AdvancedTab4, new Advanced4View()),
                }),
                #endregion

            };
        }

        #region Command for window closed
        private ICommand closeWindowCommand;

        public ICommand CloseWindowCommand
        {
            get
            {
                if (closeWindowCommand == null)
                {
                    closeWindowCommand = new CommandsAndINPC(param => this.CloseWindow(), null);
                }
                return closeWindowCommand;
            }
        }
        private void CloseWindow()
        {
            GeneralViewModel.SaveXml(gModel);
        }
        #endregion
    }
}

