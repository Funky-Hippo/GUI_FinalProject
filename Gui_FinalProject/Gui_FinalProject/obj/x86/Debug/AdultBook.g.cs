﻿#pragma checksum "C:\Users\Kyle Gillette\source\repos\GUI_FinalProject\Gui_FinalProject\Gui_FinalProject\AdultBook.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "497F516AEC698DD28D22C62EBEAF4BF572C426930CA5CD8A2A0AF15DE0E286E5"
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
    partial class AdultBook : 
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
            case 2: // AdultBook.xaml line 14
                {
                    this.media = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3: // AdultBook.xaml line 36
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.PauseButton_Click;
                }
                break;
            case 4: // AdultBook.xaml line 40
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.PlayButton_Click;
                }
                break;
            case 5: // AdultBook.xaml line 44
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.HomeButton_Click;
                }
                break;
            case 6: // AdultBook.xaml line 48
                {
                    this.previousbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.previousbutton).Click += this.PreviousButton_Click;
                }
                break;
            case 7: // AdultBook.xaml line 52
                {
                    this.forwardbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.forwardbutton).Click += this.ForwardButton_Click;
                }
                break;
            case 8: // AdultBook.xaml line 56
                {
                    this.adultflipview = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                    ((global::Windows.UI.Xaml.Controls.FlipView)this.adultflipview).SelectionChanged += this.FlipView_SelectionChanged;
                }
                break;
            case 9: // AdultBook.xaml line 19
                {
                    this.volumeSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.volumeSlider).ValueChanged += this.VolumeSlider_ValueChanged;
                }
                break;
            case 10: // AdultBook.xaml line 29
                {
                    global::Windows.UI.Xaml.Controls.Slider element10 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)element10).ValueChanged += this.AudioSpeedSlider_ValueChanged;
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

