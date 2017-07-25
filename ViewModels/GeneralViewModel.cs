using NemetschekFirstAssigment.Models;
using NemetschekFirstAssigment.ViewModels;
using System.Collections.Generic;

namespace NemetschekFirstAssigment.ViewModel
{
    class GeneralViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public List<GeneralModel> Subcategories { get; set; }

        public GeneralViewModel(string Name, List<GeneralModel> Subcategories)
        {
            this.Name = Name;
            this.Subcategories = Subcategories;
        }
    }
}
