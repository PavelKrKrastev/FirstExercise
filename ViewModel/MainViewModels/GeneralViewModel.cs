using NemetschekFirstAssigment.Model;
using NemetschekFirstAssigment.View;
using NemetschekFirstAssigment.ViewModel.MainViewModels;
using NemetschekFirstAssigment.ViewModel.UserControlViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.ViewModel
{
    class GeneralViewModel : BaseViewModel
    {

        private MainModel _general;

        public MainModel General
        {
            get { return _general; }
            set
            {
                _general = value;
                RaisePropertyChangedEvent("General");
            }
        }

        private ObservableCollection<TabContentModel> _subcategories;

        public ObservableCollection<TabContentModel> Subcategories
        {
            get { return _subcategories; }
            set
            {
                _subcategories = value;
                RaisePropertyChangedEvent("Subcategories");
            }
        }

        private object _optionsContent;

        public object OptionsContent
        {
            get { return _optionsContent; }
            set
            {
                _optionsContent = value;
                RaisePropertyChangedEvent("OptionsContent");
            }
        }

        private object _preferencesContent;

        public object PreferencesContent
        {
            get { return _preferencesContent; }
            set
            {
                _preferencesContent = value;
                RaisePropertyChangedEvent("PreferencesContent");
            }
        }

        private object _settingsContent;

        public object SettingsContent
        {
            get { return _settingsContent; }
            set
            {
                _settingsContent = value;
                RaisePropertyChangedEvent("SettingsContent");
            }
        }

        public string Name
        {
            get { return General.Name; }
            set
            {
                General.Name = value;
                RaisePropertyChangedEvent("Name");
            }
        }

        public GeneralViewModel()
        {
            this.OptionsContent = new OptionsView();

            this.PreferencesContent = new PreferencesView();

            this.SettingsContent = new SettingsView();

            this.Subcategories = new ObservableCollection<TabContentModel>
            {
                new TabContentModel() {Name = "Options", TabContent = OptionsContent},
                new TabContentModel() {Name = "Preferences", TabContent = PreferencesContent},
                new TabContentModel() {Name = "Settings", TabContent = SettingsContent},
            };

            General = new MainModel { Name = "General", TabSubcategory = Subcategories };
        }

    }
}
