using NemetschekFirstAssigment.ViewModel.MainViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.ViewModel
{
    class MainViewModel : BaseViewModel
    {

        public MainViewModel()
        {
            AllModels = new ObservableCollection<object>
            {
                new GeneralViewModel(),
                new ToolsViewModel(),
                new WindowViewModel(),
                new AdvancedViewModel(),
            };
        }
        private ObservableCollection<object> _allModels;

        public ObservableCollection<object> AllModels
        {
            get { return _allModels; }
            set
            {
                _allModels = value;
                RaisePropertyChangedEvent("AllModels");
            }
        }

    }
}
