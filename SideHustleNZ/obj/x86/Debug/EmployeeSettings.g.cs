﻿#pragma checksum "C:\Users\Ben\source\repos\SideHustleNZ\SideHustleNZ\EmployeeSettings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3C1FCA61C7D7192225561D68A51384345A9775CF251379DAD2D0DEF42EFBABDE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SideHustleNZ
{
    partial class EmployeeSettings : 
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
            case 2: // EmployeeSettings.xaml line 31
                {
                    global::Windows.UI.Xaml.Controls.Image element2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)element2).Tapped += this.Image_Tapped;
                }
                break;
            case 3: // EmployeeSettings.xaml line 35
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Tapped += this.Button_Tapped;
                }
                break;
            case 4: // EmployeeSettings.xaml line 60
                {
                    this.VerifyButton = (global::Windows.UI.Xaml.Controls.Button)(target);
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

