using NemetschekFirstAssigment.Model;
using NemetschekFirstAssigment.View;
using NemetschekFirstAssigment.ViewModel.MainViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.ViewModel
{
    class AdvancedViewModel : BaseViewModel
    {
        private MainModel _advanced;
        public MainModel Advanced
        {
            get { return _advanced; }
            set
            {
                _advanced = value;
                RaisePropertyChangedEvent("Advanced");
            }
        }
        private ObservableCollection<TabContentModel> _subcategories;
        public ObservableCollection<TabContentModel> Subcategories
        {
            get { return _subcategories; }
            set
            {
                _subcategories = value;
                RaisePropertyChangedEvent("Subcategories");
            }
        }

        private object _advanced1Content;

        public object Advanced1Content
        {
            get { return _advanced1Content; }
            set
            {
                _advanced1Content = value;
                RaisePropertyChangedEvent("Advanced1Content");
            }
        }

        private object _advanced2Content;

        public object Advanced2Content
        {
            get { return _advanced2Content; }
            set
            {
                _advanced2Content = value;
                RaisePropertyChangedEvent("Advanced2Content");
            }
        }

        private object _advanced3Content;

        public object Advanced3Content
        {
            get { return _advanced3Content; }
            set
            {
                _advanced3Content = value;
                RaisePropertyChangedEvent("Advanced3Content");
            }
        }

        private object _advanced4Content;

        public object Advanced4Content
        {
            get { return _advanced4Content; }
            set
            {
                _advanced4Content = value;
                RaisePropertyChangedEvent("Advanced4Content");
            }
        }

        public string Name
        {
            get { return Advanced.Name; }
            set
            {
                Advanced.Name = value;
                RaisePropertyChangedEvent("Name");
            }
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
