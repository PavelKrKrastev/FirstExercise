namespace NemetschekFirstAssigment.Models
{
    class GeneralModel
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

        public GeneralModel(string Name, object TabContent)
        {
            this.Name = Name;
            this.TabContent = TabContent;
        }
    }

}