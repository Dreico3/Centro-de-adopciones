#pragma checksum "..\..\Ventana3.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "98E205D488118DF5495A536D687ED2AC59D00F829E08EBE424A366C425EE83E9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using masco;


namespace masco {
    
    
    /// <summary>
    /// Ventana3
    /// </summary>
    public partial class Ventana3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Ventana3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNombreA;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Ventana3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbApellidoA;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Ventana3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDireccionA;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Ventana3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCiA;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Ventana3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNombreMascota;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Ventana3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPhone;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Ventana3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarA;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Ventana3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/masco;component/ventana3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Ventana3.xaml"
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
            this.tbNombreA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbApellidoA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbDireccionA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbCiA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbNombreMascota = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnAgregarA = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Ventana3.xaml"
            this.btnAgregarA.Click += new System.Windows.RoutedEventHandler(this.btnAgregarA_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Ventana3.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

