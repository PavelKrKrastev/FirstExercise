using System.Collections.Generic;
using System.Collections.ObjectModel;

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

        private List<TabContentModel> _tabSubcategory;

        public List<TabContentModel> TabSubcategory
        {
            get { return _tabSubcategory; }
            set { _tabSubcategory = value; }
        }

    }
}
