﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CCB2D9F46552B29E95EBE9A46E2312128648E3F2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DragDrop;
using Prism.Interactivity;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
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


namespace DragDrop.Views {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 77 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvDrag;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvDrop;
        
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
            System.Uri resourceLocater = new System.Uri("/DragDrop;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            this.lvDrag = ((System.Windows.Controls.ListView)(target));
            
            #line 83 "..\..\..\Views\MainWindow.xaml"
            this.lvDrag.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.lvDrag_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\Views\MainWindow.xaml"
            this.lvDrag.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.lvDrag_PreviewMouseMove);
            
            #line default
            #line hidden
            
            #line 85 "..\..\..\Views\MainWindow.xaml"
            this.lvDrag.MouseMove += new System.Windows.Input.MouseEventHandler(this.lvDrag_MouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lvDrop = ((System.Windows.Controls.ListView)(target));
            
            #line 144 "..\..\..\Views\MainWindow.xaml"
            this.lvDrop.DragEnter += new System.Windows.DragEventHandler(this.lvDrop_DragEnter);
            
            #line default
            #line hidden
            
            #line 145 "..\..\..\Views\MainWindow.xaml"
            this.lvDrop.DragLeave += new System.Windows.DragEventHandler(this.lvDrop_DragLeave);
            
            #line default
            #line hidden
            
            #line 146 "..\..\..\Views\MainWindow.xaml"
            this.lvDrop.Drop += new System.Windows.DragEventHandler(this.lvDrop_Drop);
            
            #line default
            #line hidden
            
            #line 147 "..\..\..\Views\MainWindow.xaml"
            this.lvDrop.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.lvDrop_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 148 "..\..\..\Views\MainWindow.xaml"
            this.lvDrop.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lvDrop_MouseDown);
            
            #line default
            #line hidden
            
            #line 149 "..\..\..\Views\MainWindow.xaml"
            this.lvDrop.MouseMove += new System.Windows.Input.MouseEventHandler(this.lvDrop_MouseMove);
            
            #line default
            #line hidden
            
            #line 150 "..\..\..\Views\MainWindow.xaml"
            this.lvDrop.DragOver += new System.Windows.DragEventHandler(this.lvDrop_DragOver);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 173 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).Drop += new System.Windows.DragEventHandler(this.Grid_Drop);
            
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
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 2:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseMoveEvent;
            
            #line 88 "..\..\..\Views\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.ListViewItem_MouseMove);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

