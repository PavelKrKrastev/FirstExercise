using NemetschekFirstAssigment.Model;
using NemetschekFirstAssigment.View;
using NemetschekFirstAssigment.ViewModel.MainViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.ViewModel
{
    class WindowViewModel : BaseViewModel
    {

        public MainModel Window { get; set; }

        public List<TabContentModel> Subcategories { get; set; }

        public string Name
        {
            get { return Window.Name; }
            set{ Window.Name = value; }
        }

        public WindowViewModel()
        {
            this.Subcategories = new List<TabContentModel>
            {
                new TabContentModel() {Name = "View", TabContent =  new ViewView()},
                new TabContentModel() {Name = "Resolution", TabContent = new ResolutionView() },
            };

            Window = new MainModel { Name = "Window", TabSubcategory = Subcategories };
        }

    }
}
