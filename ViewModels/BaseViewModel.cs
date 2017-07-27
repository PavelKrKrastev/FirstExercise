using System.ComponentModel;
using System.Xml.Linq;

namespace NemetschekFirstAssigment.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public XDocument Doc = XDocument.Load(@"XmlFile\Information.xml");

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
