﻿#pragma checksum "..\..\..\DWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "075F6D0A6E482E51FF7CBE4CC67388A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18033
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using SecretSound;
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


namespace SecretSound {
    
    
    /// <summary>
    /// DWindow
    /// </summary>
    public partial class DWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\DWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SecretSound.DWindow Window;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\DWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\DWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_Close;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\DWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_Min;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\DWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_FileSource;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\DWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_FileOutput;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\DWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_FileOutput_Copy;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\DWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SecretSound.Rank MixBitRank;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\DWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar PB;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\DWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_FileSource_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/SecretSound;component/dwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.Window = ((SecretSound.DWindow)(target));
            
            #line 8 "..\..\..\DWindow.xaml"
            this.Window.Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\DWindow.xaml"
            this.Window.MouseMove += new System.Windows.Input.MouseEventHandler(this.Window_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.BT_Close = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\DWindow.xaml"
            this.BT_Close.Click += new System.Windows.RoutedEventHandler(this.BT_Close_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BT_Min = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\DWindow.xaml"
            this.BT_Min.Click += new System.Windows.RoutedEventHandler(this.BT_Min_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 14 "..\..\..\DWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TB_FileSource = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BT_FileOutput = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\DWindow.xaml"
            this.BT_FileOutput.Click += new System.Windows.RoutedEventHandler(this.BT_FileInput_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BT_FileOutput_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\DWindow.xaml"
            this.BT_FileOutput_Copy.Click += new System.Windows.RoutedEventHandler(this.BT_FileOutput_Copy_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MixBitRank = ((SecretSound.Rank)(target));
            return;
            case 10:
            
            #line 46 "..\..\..\DWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 11:
            this.PB = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 12:
            this.TB_FileSource_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
