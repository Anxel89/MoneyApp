﻿#pragma checksum "..\..\TransHistPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DC3B333D093B1B7F232CDEF9C748DAE285433790"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MoneyTransfer657;
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


namespace MoneyTransfer657 {
    
    
    /// <summary>
    /// TransHistPage
    /// </summary>
    public partial class TransHistPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\TransHistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label transHistMainLabel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\TransHistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mainMenu1Button;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\TransHistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Separator transHistSeparator;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\TransHistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox sentRecListBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\TransHistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox buySoldListBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\TransHistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sentRecivedTextBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\TransHistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sentRecSearchButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\TransHistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TransEXData;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\TransHistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox buySellTextBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\TransHistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buySellSearchButton;
        
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
            System.Uri resourceLocater = new System.Uri("/MoneyTransfer657;component/transhistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TransHistPage.xaml"
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
            this.transHistMainLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.mainMenu1Button = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\TransHistPage.xaml"
            this.mainMenu1Button.Click += new System.Windows.RoutedEventHandler(this.mainMenu1Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.transHistSeparator = ((System.Windows.Controls.Separator)(target));
            return;
            case 4:
            this.sentRecListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.buySoldListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.sentRecivedTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.sentRecSearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\TransHistPage.xaml"
            this.sentRecSearchButton.Click += new System.Windows.RoutedEventHandler(this.sentRecSearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TransEXData = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\TransHistPage.xaml"
            this.TransEXData.Click += new System.Windows.RoutedEventHandler(this.TransEXData_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buySellTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.buySellSearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\TransHistPage.xaml"
            this.buySellSearchButton.Click += new System.Windows.RoutedEventHandler(this.sentRecSearchButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

