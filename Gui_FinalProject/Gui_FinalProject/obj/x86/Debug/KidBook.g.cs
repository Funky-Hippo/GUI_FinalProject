﻿#pragma checksum "C:\Users\Kyle Gillette\Source\Repos\GUI_FinalProject\Gui_FinalProject\Gui_FinalProject\KidBook.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FF7D890D2DC5A479E186DD2BB52CC224DEE07CA17350CE4645EB28F1F5115B33"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gui_FinalProject
{
    partial class KidBook : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // KidBook.xaml line 13
                {
                    global::Windows.UI.Xaml.Controls.FlipView element2 = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                    ((global::Windows.UI.Xaml.Controls.FlipView)element2).SelectionChanged += this.FlipView_SelectionChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

