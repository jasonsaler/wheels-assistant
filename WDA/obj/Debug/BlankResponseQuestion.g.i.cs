﻿#pragma checksum "..\..\BlankResponseQuestion.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "29766C3C3C745A00FDD3D1BB154EB3CD"
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
        
        
        #line 15 "..\..\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid wholeGrid;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox questionNumber;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid deletIconBackground;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image deletIcon;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox naCheckbox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid holderGrid;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AnswerGrid;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox responseText;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid QuestionGrid;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\BlankResponseQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox questionTextInput;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\BlankResponseQuestion.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WheelsDataAssistant;component/blankresponsequestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BlankResponseQuestion.xaml"
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
            this.wholeGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.questionNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.deletIconBackground = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.deletIcon = ((System.Windows.Controls.Image)(target));
            
            #line 58 "..\..\BlankResponseQuestion.xaml"
            this.deletIcon.MouseEnter += new System.Windows.Input.MouseEventHandler(this.CloseButton_MouseOver);
            
            #line default
            #line hidden
            
            #line 59 "..\..\BlankResponseQuestion.xaml"
            this.deletIcon.MouseLeave += new System.Windows.Input.MouseEventHandler(this.CloseButton_MouseLeave);
            
            #line default
            #line hidden
            
            #line 60 "..\..\BlankResponseQuestion.xaml"
            this.deletIcon.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.CloseButton_MouseUP);
            
            #line default
            #line hidden
            return;
            case 5:
            this.naCheckbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 72 "..\..\BlankResponseQuestion.xaml"
            this.naCheckbox.Checked += new System.Windows.RoutedEventHandler(this.NACheckBox_GotChecked);
            
            #line default
            #line hidden
            
            #line 73 "..\..\BlankResponseQuestion.xaml"
            this.naCheckbox.Unchecked += new System.Windows.RoutedEventHandler(this.NACheckBox_GotUnchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.holderGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.AnswerGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.responseText = ((System.Windows.Controls.TextBox)(target));
            
            #line 110 "..\..\BlankResponseQuestion.xaml"
            this.responseText.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.ResponseBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 111 "..\..\BlankResponseQuestion.xaml"
            this.responseText.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.ResponseBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.QuestionGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.questionTextInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 143 "..\..\BlankResponseQuestion.xaml"
            this.questionTextInput.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.newQuestionBox_gotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 144 "..\..\BlankResponseQuestion.xaml"
            this.questionTextInput.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.newQuestionBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            this.questionTextOutput = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

