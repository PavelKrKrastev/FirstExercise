using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.Model
{
    class TabContentModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private object _tabContent;

        public object TabContent
        {
            get { return _tabContent; }
            set { _tabContent = value; }
        }

    }

}
