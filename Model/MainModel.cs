using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.Model
{
    class MainModel
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private ObservableCollection<TabContentModel> _tabSubcategory;

        public ObservableCollection<TabContentModel> TabSubcategory
        {
            get { return _tabSubcategory; }
            set { _tabSubcategory = value; }
        }

    }
}
