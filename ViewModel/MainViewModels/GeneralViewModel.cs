using NemetschekFirstAssigment.Model;
using NemetschekFirstAssigment.View;
using NemetschekFirstAssigment.ViewModel.UserControlViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.ViewModel
{
    class GeneralViewModel
    {

        public MainModel General { get; set; }

        public ObservableCollection<TabContentModel> Subcategories { get; set; }

        public object OptionsContent { get; set; }

        public object PreferencesContent { get; set; }
        
        public object SettingsContent { get; set; }

        public string Name
        {
            get { return General.Name; }
            set { General.Name = value; }
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

            General = new MainModel { Name = "General", TabSubcategory = Subcategories};
        }

    }
}
