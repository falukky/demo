using EnvironmentsManager.classes.env;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentsManager.classes.viewmodel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<env.Environment> _environments;
        private ObservableCollection<User> _users;
        private env.Environment _selectedEnvironment;

        public ObservableCollection<env.Environment> Environments
        {
            get { return _environments; }
            set
            {
                _environments = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                NotifyPropertyChanged();
            }
        }

        public env.Environment SelectedEnvironment
        {
            get { return _selectedEnvironment; }
            set
            {
                _selectedEnvironment = value;
                _users = _selectedEnvironment.Users;
                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
