using System.ComponentModel;
using System.Xml.Linq;

namespace NemetschekFirstAssigment.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private static string xmlUrl = "C://Users//Pavel Krastev//Desktop//Exc1//FirstExercise//Information.xml";

        public XDocument Doc = XDocument.Load(xmlUrl);

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
