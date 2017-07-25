using NemetschekFirstAssigment.Models;
using NemetschekFirstAssigment.ViewModels;
using System.Collections.Generic;

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
