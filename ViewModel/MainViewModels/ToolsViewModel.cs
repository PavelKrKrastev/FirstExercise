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
    class ToolsViewModel
    {

        public MainModel Tools { get; set; }

        public TabContentModel SubCategory { get; set; }

        public ObservableCollection<TabContentModel> Subcategories { get; set; }

        public object ToolsContent { get; set; }

        public string Name
        {
            get { return Tools.Name; }
            set { Tools.Name = value; }
        }

        public ToolsViewModel()
        {
            this.ToolsContent = new ToolsView();

            this.Subcategories = new ObservableCollection<TabContentModel>
            {
                new TabContentModel() {Name = "Tools", TabContent = ToolsContent},
            };
            Tools = new MainModel { Name = "Tools", TabSubcategory = Subcategories };
        }

    }
}
