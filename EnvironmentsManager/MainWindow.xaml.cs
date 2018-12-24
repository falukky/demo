using EnvironmentsManager.classes.enums;
using EnvironmentsManager.classes.env;
using EnvironmentsManager.classes.viewmodel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Xml;

namespace EnvironmentsManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ApplicationViewModel applicationViewModel;
        public ObservableCollection<classes.env.Environment> environments { get; set; }
        private bool StateClosed = true;
        public MainWindow()
        {
            InitializeComponent();
            applicationViewModel = new ApplicationViewModel();
            DataContext = applicationViewModel;
            ReadXML();
        }

        private void ReadXML()
        {
            string xml = Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "environment_settings.xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xml);

            XmlNode rootNode = xmlDoc.SelectSingleNode("/environments");
            XmlNodeList xmlNodeList = rootNode.ChildNodes;
            environments = new ObservableCollection<classes.env.Environment>();
            environments.Add(new classes.env.Environment("Select", "", null));
            ObservableCollection<User> users;
            applicationViewModel.Users = new ObservableCollection<User>();

            foreach (XmlNode environmentNode in rootNode.ChildNodes)
            {
                users = new ObservableCollection<User>();
                string name = environmentNode["name"].InnerText.ToUpper();
                string url = environmentNode["url"].InnerText;

                XmlNodeList list = environmentNode.ChildNodes;
                XmlNode usersNode = list[list.Count - 1]; // Users node.

                foreach (XmlNode userTypeNode in usersNode.ChildNodes)
                {
                    string userTypeName = userTypeNode.Name;
                    UserType userType;
                    if (userTypeName == "risk")
                        userType = UserType.Risk;
                    else
                        userType = UserType.Margin;

                    foreach (XmlNode node in userTypeNode.ChildNodes)
                    {
                        User user = new User(node["name"].InnerText, node["password"].InnerText, userType);
                        users.Add(user);
                    }
                }

                classes.env.Environment environment = new classes.env.Environment(name, url, users);
                environments.Add(environment);
            }

            applicationViewModel.Environments = environments;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (StateClosed)
            {
                Storyboard sb = this.FindResource("OpenMenu") as Storyboard;
                sb.Begin();
            }
            else
            {
                Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
                sb.Begin();
            }

            StateClosed = !StateClosed;
        }

        private void SetSelectedEnvironment(string name)
        {
            foreach (classes.env.Environment environment in applicationViewModel.Environments)
            {
                if (environment.Name.ToLower() == name.ToLower())
                {
                    applicationViewModel.SelectedEnvironment = environment;
                    break;
                }
            }

            ListViewUsers.ItemsSource = applicationViewModel.Users;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ComboBoxEnvironment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListViewUsers.ItemsSource = null;
            string environmentName = ComboBoxEnvironment.SelectedItem.ToString();
            SetSelectedEnvironment(environmentName);
        }
    }
}
