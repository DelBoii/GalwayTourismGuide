﻿

#pragma checksum "C:\Users\ryangordon\Desktop\GalwayTourismGuide.Source-v1.0.0.0\GalwayTourismGuide.WindowsPhone\Controls\YouTubeViewer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C17FF4A20BFCA2529E0EF5D9F6F5C91F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GalwayTourismGuide.Controls
{
    partial class YouTubeViewer : global::Windows.UI.Xaml.Controls.UserControl
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.UserControl LayoutRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualStateGroup PageOrientationStates; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState Landscape; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState Portrait; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.RowDefinition Title; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.RowDefinition BottomMargin; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.WebView WebView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Controls/YouTubeViewer.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            LayoutRoot = (global::Windows.UI.Xaml.Controls.UserControl)this.FindName("LayoutRoot");
            PageOrientationStates = (global::Windows.UI.Xaml.VisualStateGroup)this.FindName("PageOrientationStates");
            Landscape = (global::Windows.UI.Xaml.VisualState)this.FindName("Landscape");
            Portrait = (global::Windows.UI.Xaml.VisualState)this.FindName("Portrait");
            Title = (global::Windows.UI.Xaml.Controls.RowDefinition)this.FindName("Title");
            BottomMargin = (global::Windows.UI.Xaml.Controls.RowDefinition)this.FindName("BottomMargin");
            WebView = (global::Windows.UI.Xaml.Controls.WebView)this.FindName("WebView");
        }
    }
}


