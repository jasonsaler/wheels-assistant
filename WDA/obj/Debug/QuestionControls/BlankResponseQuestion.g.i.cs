﻿#pragma checksum "..\..\..\QuestionControls\BlankResponseQuestion.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "421829AAF2EFA18E37CFE16E948E03DE"
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
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using WheelsDataAssistant;


namespace WheelsDataAssistant {
    
    
    /// <summary>
    /// BlankResponseQuestion
    /// </summary>
    public partial class BlankResponseQuestion : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox questionNumber;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid deletIconBackground;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image deletIcon;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox naCheckbox;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid holderGrid;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AnswerGrid;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox responseText;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid QuestionGrid;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox questionTextInput;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock questionTextOutput;
        
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
            System.Uri resourceLocater = new System.Uri("/WheelsDataAssistant;component/questioncontrols/blankresponsequestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
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
            this.questionNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.deletIconBackground = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.deletIcon = ((System.Windows.Controls.Image)(target));
            
            #line 55 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
            this.deletIcon.MouseEnter += new System.Windows.Input.MouseEventHandler(this.CloseButton_MouseOver);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
            this.deletIcon.MouseLeave += new System.Windows.Input.MouseEventHandler(this.CloseButton_MouseLeave);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\QuestionControls\BlankResponseQuestion.xaml"
            this.deletIcon.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.CloseButton_MouseUP);
            
            #line default
            #line hidden
            return;
            case 4:
            this.naCheckbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.holderGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.AnswerGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.responseText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.QuestionGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.questionTextInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.questionTextOutput = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

