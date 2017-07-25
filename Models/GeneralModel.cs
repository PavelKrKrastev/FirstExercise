using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.Models
{
    class MainModel
    {
        #region private variables
        private string _name;
        private List<TabContentModel> _tabSubcategory;
        #endregion

        #region public properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<TabContentModel> TabSubcategory
        {
            get { return _tabSubcategory; }
            set { _tabSubcategory = value; }
        }
        #endregion

    }
}
