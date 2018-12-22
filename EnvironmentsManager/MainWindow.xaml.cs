using EnvironmentsManager.classes.enums;
using EnvironmentsManager.classes.env;
using EnvironmentsManager.classes.viewmodel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            string xml = @"C:\Users\raviv\OneDrive\Desktop\settings.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xml);

            XmlNode rootNode = xmlDoc.SelectSingleNode("/environments");
            XmlNodeList xmlNodeList = rootNode.ChildNodes;
            environments = new ObservableCollection<classes.env.Environment>();
            ObservableCollection<User> users;
            applicationViewModel.Users = new ObservableCollection<User>();

            foreach (XmlNode environmentNode in rootNode.ChildNodes)
            {
                users = new ObservableCollection<User>();
                string name = environmentNode["name"].InnerText;
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
                        //applicationViewModel.Users.Add(user);
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

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void CheckBoxRV_Checked(object sender, RoutedEventArgs e)
        {
            CheckBoxPDK.IsChecked = false;
            CheckBoxORD.IsChecked = false;
            CheckBoxORD1.IsChecked = false;
            CheckBoxAT.IsChecked = false;

            ListViewUsers.ItemsSource = null;
            applicationViewModel.Users = applicationViewModel.Environments[0].Users;
            ListViewUsers.ItemsSource = applicationViewModel.Users;

            applicationViewModel.SelectedEnvironment = applicationViewModel.Environments[0];
        }

        private void CheckBoxRV_Unchecked(object sender, RoutedEventArgs e)
        {
            ListViewUsers.ItemsSource = null;
        }

        private void CheckBoxPDK_Checked(object sender, RoutedEventArgs e)
        {
            CheckBoxRV.IsChecked = false;
            CheckBoxORD.IsChecked = false;
            CheckBoxORD1.IsChecked = false;
            CheckBoxAT.IsChecked = false;
            ListViewUsers.ItemsSource = null;
            applicationViewModel.Users = applicationViewModel.Environments[1].Users;
            ListViewUsers.ItemsSource = applicationViewModel.Users;

            applicationViewModel.SelectedEnvironment = applicationViewModel.Environments[1];
        }

        private void CheckBoxPDK_Unchecked(object sender, RoutedEventArgs e)
        {
            ListViewUsers.ItemsSource = null;
        }

        private void CheckBoxORD_Checked(object sender, RoutedEventArgs e)
        {
            CheckBoxRV.IsChecked = false;
            CheckBoxPDK.IsChecked = false;
            CheckBoxORD1.IsChecked = false;
            CheckBoxAT.IsChecked = false;
        }

        private void CheckBoxORD_Unchecked(object sender, RoutedEventArgs e)
        {
            ListViewUsers.ItemsSource = null;
        }

        private void CheckBoxORD1_Checked(object sender, RoutedEventArgs e)
        {
            CheckBoxRV.IsChecked = false;
            CheckBoxPDK.IsChecked = false;
            CheckBoxORD.IsChecked = false;
            CheckBoxAT.IsChecked = false;
        }

        private void CheckBoxORD1_Unchecked(object sender, RoutedEventArgs e)
        {
            ListViewUsers.ItemsSource = null;
        }

        private void CheckBoxAT_Checked(object sender, RoutedEventArgs e)
        {
            CheckBoxRV.IsChecked = false;
            CheckBoxPDK.IsChecked = false;
            CheckBoxORD.IsChecked = false;
            CheckBoxORD1.IsChecked = false;
        }

        private void CheckBoxAT_Unchecked(object sender, RoutedEventArgs e)
        {
            ListViewUsers.ItemsSource = null;
        }
    }
}
