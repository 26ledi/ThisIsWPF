﻿#pragma checksum "..\..\..\WindowResult.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D06ADFEE702542915F1D04273BFDD9B12A12D6CC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Controls.Ribbon;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// WindowResult
    /// </summary>
    public partial class WindowResult : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\WindowResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton BlazerRadio;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\WindowResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioJeans;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\WindowResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioSkirt;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\WindowResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxTissu;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\WindowResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSize;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\WindowResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxColor;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\WindowResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubmitButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\WindowResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResetButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\WindowResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MenuButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/windowresult.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowResult.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BlazerRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 11 "..\..\..\WindowResult.xaml"
            this.BlazerRadio.Checked += new System.Windows.RoutedEventHandler(this.SubmitButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RadioJeans = ((System.Windows.Controls.RadioButton)(target));
            
            #line 12 "..\..\..\WindowResult.xaml"
            this.RadioJeans.Checked += new System.Windows.RoutedEventHandler(this.SubmitButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RadioSkirt = ((System.Windows.Controls.RadioButton)(target));
            
            #line 13 "..\..\..\WindowResult.xaml"
            this.RadioSkirt.Checked += new System.Windows.RoutedEventHandler(this.SubmitButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBoxTissu = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TextBoxSize = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TextBoxColor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.SubmitButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\WindowResult.xaml"
            this.SubmitButton.Click += new System.Windows.RoutedEventHandler(this.SubmitButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ResetButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\WindowResult.xaml"
            this.ResetButton.Click += new System.Windows.RoutedEventHandler(this.ResetButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MenuButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\WindowResult.xaml"
            this.MenuButton.Click += new System.Windows.RoutedEventHandler(this.MenuButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

