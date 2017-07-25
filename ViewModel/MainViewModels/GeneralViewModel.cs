using NemetschekFirstAssigment.Model;
using NemetschekFirstAssigment.View;
using NemetschekFirstAssigment.ViewModel.MainViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.ViewModel
{
    class GeneralViewModel : BaseViewModel
    {
        public MainModel GenralModel { get; set; }
        public List<TabContentModel> Subcategories { get; set; }

        public string Name { get; set; }

        public GeneralViewModel(string Name, List<TabContentModel> Subcategories)
        {
            this.Name = Name;
            this.Subcategories = Subcategories;

        }
    }
}
