﻿#pragma checksum "C:\Users\Kyle Gillette\Desktop\GUI_Final\Gui_FinalProject\Gui_FinalProject\KidBook.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DC0D99185141D5F02EDA3DBB9592EC65E3B18B6A8492F31577C58B626441BAF5"
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
                    this.kidflipviewer = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                    ((global::Windows.UI.Xaml.Controls.FlipView)this.kidflipviewer).SelectionChanged += this.FlipView_SelectionChanged;
                }
                break;
            case 3: // KidBook.xaml line 26
                {
                    this.media = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 4: // KidBook.xaml line 30
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.PauseButton_Click;
                }
                break;
            case 5: // KidBook.xaml line 34
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.PlayButton_Click;
                }
                break;
            case 6: // KidBook.xaml line 38
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.HomeButton_Click;
                }
                break;
            case 7: // KidBook.xaml line 42
                {
                    this.previousbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.previousbutton).Click += this.previousbutton_Click;
                }
                break;
            case 8: // KidBook.xaml line 46
                {
                    this.forwardbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.forwardbutton).Click += this.forwardbutton_Click;
                }
                break;
            case 9: // KidBook.xaml line 53
                {
                    this.volumeSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.volumeSlider).ValueChanged += this.volumeSlider_ValueChanged;
                }
                break;
            case 10: // KidBook.xaml line 65
                {
                    global::Windows.UI.Xaml.Controls.Slider element10 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)element10).ValueChanged += this.audiospeedSlider_ValueChanged;
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

