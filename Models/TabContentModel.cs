namespace NemetschekFirstAssigment.Models
{
    class TabContentModel
    {
        #region private variables
        private string _name;
        private object _tabContent;
        #endregion

        #region
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public object TabContent
        {
            get { return _tabContent; }
            set { _tabContent = value; }
        }
        #endregion

        public TabContentModel(string Name, object TabContent)
        {
            this.Name = Name;
            this.TabContent = TabContent;
        }

    }

}
