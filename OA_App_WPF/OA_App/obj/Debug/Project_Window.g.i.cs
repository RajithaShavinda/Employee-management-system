﻿#pragma checksum "..\..\Project_Window.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8863E75A6F28BF9DC58536627B35235F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace OA_App {
    
    
    /// <summary>
    /// Project_Window
    /// </summary>
    public partial class Project_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 24 "..\..\Project_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Add_Project;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Project_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Emp_stats;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Project_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Exit;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Project_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox My_Data_List;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Project_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboGetMonth;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Project_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Project_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\Project_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MenuItem;
        
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
            System.Uri resourceLocater = new System.Uri("/OA_App;component/project_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Project_Window.xaml"
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
            this.btn_Add_Project = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Project_Window.xaml"
            this.btn_Add_Project.Click += new System.Windows.RoutedEventHandler(this.btn_Add_Project_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_Emp_stats = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Project_Window.xaml"
            this.btn_Emp_stats.Click += new System.Windows.RoutedEventHandler(this.btn_Emp_stats_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_Exit = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Project_Window.xaml"
            this.btn_Exit.Click += new System.Windows.RoutedEventHandler(this.btn_Exit_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.My_Data_List = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.cboGetMonth = ((System.Windows.Controls.ComboBox)(target));
            
            #line 71 "..\..\Project_Window.xaml"
            this.cboGetMonth.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboGetMonth_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\Project_Window.xaml"
            this.txtSearch.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtSearch_KeyDown_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\Project_Window.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MenuItem = ((System.Windows.Controls.Menu)(target));
            return;
            case 10:
            
            #line 80 "..\..\Project_Window.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_1);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 81 "..\..\Project_Window.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_2);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 82 "..\..\Project_Window.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 63 "..\..\Project_Window.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_View_Click_1);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

