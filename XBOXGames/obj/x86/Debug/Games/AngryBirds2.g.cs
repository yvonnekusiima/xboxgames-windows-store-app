﻿#pragma checksum "C:\Users\Yvonne Kusiima\Desktop\SCHOOL\APTECH\Semester 3\C#\Windows Applications\XBOXGames\XBOXGames\Games\AngryBirds2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "908B27681047DE7C30F2B242B19950A219B0660CA9F0E9BA435DB5D6004C500B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XBOXGames.Games
{
    partial class AngryBirds2 : 
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
            case 2: // Games\AngryBirds2.xaml line 19
                {
                    this.sidebar = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 3: // Games\AngryBirds2.xaml line 106
                {
                    this.previewvideo = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 4: // Games\AngryBirds2.xaml line 107
                {
                    this.playvideo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.playvideo).Click += this.playvideo_Click;
                }
                break;
            case 5: // Games\AngryBirds2.xaml line 110
                {
                    this.pausevideo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.pausevideo).Click += this.pausevideo_Click;
                }
                break;
            case 6: // Games\AngryBirds2.xaml line 20
                {
                    this.back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.back).Click += this.back_Click;
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

