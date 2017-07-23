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
    class AdvancedViewModel
    {

        public MainModel Advanced { get; set; }

        public ObservableCollection<TabContentModel> Subcategories { get; set; }

        public object Advanced1Content { get; set; }

        public object Advanced2Content { get; set; }

        public object Advanced3Content { get; set; }

        public object Advanced4Content { get; set; }

        public string Name
        {
            get { return Advanced.Name; }
            set { Advanced.Name = value; }
        }

        public AdvancedViewModel()
        {
            Advanced1Content = new Advanced1View();
            Advanced2Content = new Advanced2View();
            Advanced3Content = new Advanced3View();
            Advanced4Content = new Advanced4View();

            this.Subcategories = new ObservableCollection<TabContentModel>
            {
                new TabContentModel() {Name = "Advanced 1", TabContent = Advanced1Content},
                new TabContentModel() {Name = "Advanced 2", TabContent = Advanced2Content},
                new TabContentModel() {Name = "Advanced 3", TabContent = Advanced3Content},
                new TabContentModel() {Name = "Advanced 4", TabContent = Advanced4Content},
            };
            Advanced = new MainModel { Name = "Advanced", TabSubcategory = Subcategories };
        }

    }
}
