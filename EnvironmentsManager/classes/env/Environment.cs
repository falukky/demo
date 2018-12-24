using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EnvironmentsManager.classes.env
{
    public class Environment
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public ObservableCollection<User> Users { get; set; }

        public Environment(string name, string url, ObservableCollection<User> users)
        {
            Name = name;
            URL = url;
            Users = users;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
