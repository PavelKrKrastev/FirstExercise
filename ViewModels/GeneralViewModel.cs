using NemetschekFirstAssigment.ViewModels;
using System.Collections.Generic;

namespace NemetschekFirstAssigment.ViewModel
{
    class GeneralViewModel : BaseViewModel
    {
        public string ListContent { get; set; }

        public List<object> Subcategories { get; set; }

        public GeneralViewModel(string ListContent, List<object> Subcategories)
        {
            this.ListContent = ListContent;
            this.Subcategories = Subcategories;
        }

        public string TabName { get; set; }
        public object TabContent { get; set; }

        public GeneralViewModel(string tabName, object tabContent)
        {
            this.TabName = tabName;
            this.TabContent = tabContent;
        }
    }
}
