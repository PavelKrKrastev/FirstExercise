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
    class WindowViewModel : BaseViewModel
    {

        private MainModel _window;

        internal MainModel Window
        {
            get { return _window; }
            set
            {
                _window = value;
                RaisePropertyChangedEvent("Window");
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

        private object _viewContent;

        public object ViewContent
        {
            get { return _viewContent; }
            set
            {
                _viewContent = value;
                RaisePropertyChangedEvent("ViewContent");
            }
        }

        private object _resolutionContent;

        public object ResolutionContent
        {
            get { return _resolutionContent; }
            set
            {
                _resolutionContent = value;
                RaisePropertyChangedEvent("ResolutionContent");
            }
        }

        public string Name
        {
            get { return Window.Name; }
            set
            {
                Window.Name = value;
                RaisePropertyChangedEvent("Name");
            }
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
