﻿#pragma checksum "C:\Users\Ben\source\repos\SideHustleNZ\SideHustleNZ\GuestPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D85D6E67B782BC8F97BD4C5C34CDF546B3736DD6DD03074294A9BEA3B053AFFD"
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
    partial class GuestPage : 
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
            case 2: // GuestPage.xaml line 28
                {
                    global::Windows.UI.Xaml.Controls.Image element2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)element2).Tapped += this.HomeButton_Tapped;
                }
                break;
            case 3: // GuestPage.xaml line 44
                {
                    this.TextBlockName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.TextBlockName).DoubleTapped += this.TextBlockName_DoubleTapped;
                }
                break;
            case 4: // GuestPage.xaml line 52
                {
                    this.TextBlockDescription = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.TextBlockDescription).DoubleTapped += this.TextBlockDescription_DoubleTapped;
                }
                break;
            case 5: // GuestPage.xaml line 59
                {
                    this.JobsListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.JobsListBox).SelectionChanged += this.JobsListBox_SelectionChanged;
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.JobsListBox).DoubleTapped += this.JobsListBox_DoubleTapped;
                }
                break;
            case 6: // GuestPage.xaml line 66
                {
                    this.media = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
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

