using NemetschekFirstAssigment.Model;
using NemetschekFirstAssigment.View;
using NemetschekFirstAssigment.ViewModel.MainViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.ViewModel
{
    class ToolsViewModel : BaseViewModel
    {
        public MainModel Tools { get; set; }

        public List<TabContentModel> Subcategories { get; set; }


        public string Name
        {
            get { return Tools.Name; }
            set { Tools.Name = value;}
        }

        public ToolsViewModel()
        {
            this.Subcategories = new List<TabContentModel>
            {
                new TabContentModel() {Name = "Tools", TabContent =  new ToolsView()},
            };
            Tools = new MainModel { Name = "Tools", TabSubcategory = Subcategories };
        }

    }
}
