using NemetschekFirstAssigment.Model;
using NemetschekFirstAssigment.View;
using NemetschekFirstAssigment.ViewModel.MainViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.ViewModel
{
    class AdvancedViewModel : BaseViewModel
    {
        public MainModel Advanced { get; set; }
        public List<TabContentModel> Subcategories { get; set; }

        public string Name { get; set; }
        public AdvancedViewModel()
        {
            Advanced = new MainModel
            { Name = "Advanced",TabSubcategory = new List<TabContentModel> 
                {                
                new TabContentModel() {Name = "Advanced 1", TabContent = new Advanced1View()},
                new TabContentModel() {Name = "Advanced 2", TabContent = new Advanced2View()},
                new TabContentModel() {Name = "Advanced 3", TabContent = new Advanced3View()},
                new TabContentModel() {Name = "Advanced 4", TabContent = new Advanced4View()},
                }
            };

            Subcategories = Advanced.TabSubcategory;
            Name = Advanced.Name;
        }

    }
}
