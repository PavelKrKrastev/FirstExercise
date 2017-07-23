using NemetschekFirstAssigment.Model;
using NemetschekFirstAssigment.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.ViewModel
{
    class WindowViewModel
    {

        public MainModel Window { get; set; }

        public ObservableCollection<TabContentModel> Subcategories { get; set; }

        public object ViewContent { get; set; }

        public object ResolutionContent { get; set; }

        public string Name
        {
            get { return Window.Name; }
            set { Window.Name = value; }
        }

        public WindowViewModel()
        {
            ViewContent = new ViewView();

            ResolutionContent = new ResolutionView();

            this.Subcategories = new ObservableCollection<TabContentModel>
            {
                new TabContentModel() {Name = "View", TabContent = ViewContent},
                new TabContentModel() {Name = "Resolution", TabContent = ResolutionContent },
            };

            Window = new MainModel { Name = "Window", TabSubcategory = Subcategories };
        }

    }
}
