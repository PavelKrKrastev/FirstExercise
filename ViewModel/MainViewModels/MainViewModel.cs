using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.ViewModel
{
    class MainViewModel
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
        public ObservableCollection<object> AllModels { get; set; }

    }
}
