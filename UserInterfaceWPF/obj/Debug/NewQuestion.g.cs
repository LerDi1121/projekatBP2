#pragma checksum "..\..\NewQuestion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EA85E221D90153DDB5BBC4A40F325F2622193A43EFB0A3FBE82FDD94E9CF0159"
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
using UserInterfaceWPF;


namespace UserInterfaceWPF {
    
    
    /// <summary>
    /// NewQuestion
    /// </summary>
    public partial class NewQuestion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\NewQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbText;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\NewQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCA;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\NewQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbWA1;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\NewQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbWA2;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\NewQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbWA3;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\NewQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\NewQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbQLevel;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\NewQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/UserInterfaceWPF;component/newquestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewQuestion.xaml"
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
            this.tbText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbCA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbWA1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbWA2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbWA3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.NumberTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\NewQuestion.xaml"
            this.NumberTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbQLevel = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\NewQuestion.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

