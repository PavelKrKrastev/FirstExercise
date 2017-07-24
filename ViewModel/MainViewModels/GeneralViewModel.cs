using NemetschekFirstAssigment.Model;
using NemetschekFirstAssigment.View;
using NemetschekFirstAssigment.ViewModel.MainViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.ViewModel
{
    class GeneralViewModel : BaseViewModel
    {
        public MainModel General { get; set; }

        public List<TabContentModel> Subcategories { get; set; }


        public string Name { get; set; }

        public GeneralViewModel()
        {
            this.Subcategories = new List<TabContentModel>
            {
                new TabContentModel() {Name = "Options", TabContent = new OptionsView()},
                new TabContentModel() {Name = "Preferences", TabContent =  new PreferencesView()},
                new TabContentModel() {Name = "Settings", TabContent = new SettingsView()},
            };
            General = new MainModel { Name = "General", TabSubcategory = Subcategories };
            Name = General.Name;
        }

    }
}
