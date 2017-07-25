namespace NemetschekFirstAssigment.Models
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

        public TabContentModel(string Name, object TabContent)
        {
            this.Name = Name;
            this.TabContent = TabContent;
        }

    }

}
