namespace NemetschekFirstAssigment.Models
{
    class GeneralModel
    {
        public string Name { get; set; }
        public object TabContent { get; set; }

        public GeneralModel(string Name, object TabContent)
        {
            this.Name = Name;
            this.TabContent = TabContent;
        }
    }

}