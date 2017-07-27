using System.ComponentModel;
using System.IO;
using System.Xml.Linq;

namespace NemetschekFirstAssigment.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private static string xmlUrl = @"XmlFile\Information.xml";

        public XDocument Doc;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public BaseViewModel()
        {
            try
            {
              Doc = XDocument.Load(xmlUrl);
            }

            catch (FileNotFoundException)
            {
                //TODO
            }
        }
    }
}
