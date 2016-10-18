using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallTheBus.ViewModel
{
    public class BuzzAlerterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _alertMessage;

        public string AlertMessage
        {
            get { return _alertMessage; }
            set
            {
                _alertMessage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AlertMessage)));
            }
        }

    }
}
