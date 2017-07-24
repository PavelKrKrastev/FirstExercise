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
    class ToolsViewModel : BaseViewModel
    {

        private MainModel _tools;

        public MainModel Tools
        {
            get { return _tools; }
            set
            {
                _tools = value;
                RaisePropertyChangedEvent("Tools");
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

        private object _toolsContent;

        public object ToolsContent
        {
            get { return _toolsContent; }
            set
            {
                _toolsContent = value;
                RaisePropertyChangedEvent("ToolsContent");
            }
        }

        public string Name
        {
            get { return Tools.Name; }
            set
            {
                Tools.Name = value;
                RaisePropertyChangedEvent("Name");
            }
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
