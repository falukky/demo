﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "722A2C1AF40DCB6FA9F8C3AB3C877F01F5C93E59"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EnvironmentsManager;
using EnvironmentsManager.Properties;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace EnvironmentsManager {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 74 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderMenu;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonMenu;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectangle;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectangle1;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectangle2;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewMenu;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem ItemHome;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem ItemCreate;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 377 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxEnvironment;
        
        #line default
        #line hidden
        
        
        #line 420 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewUsers;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EnvironmentsManager;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BorderMenu = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.ButtonMenu = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\MainWindow.xaml"
            this.ButtonMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonMenu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.rectangle1 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.rectangle2 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 6:
            this.ListViewMenu = ((System.Windows.Controls.ListView)(target));
            
            #line 166 "..\..\MainWindow.xaml"
            this.ListViewMenu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListViewMenu_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ItemHome = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 8:
            this.ItemCreate = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 9:
            
            #line 204 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 231 "..\..\MainWindow.xaml"
            this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.BtnMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 286 "..\..\MainWindow.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ComboBoxEnvironment = ((System.Windows.Controls.ComboBox)(target));
            
            #line 379 "..\..\MainWindow.xaml"
            this.ComboBoxEnvironment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxEnvironment_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ListViewUsers = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

