﻿#pragma checksum "C:\Users\Glenn\Desktop\PackingListApp\PackingList\PackingList\UserControls\UCTasks.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DC6E1BF1171007FA45CB1E7179AE53BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PackingList.UserControls
{
    partial class UCTasks : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.trip = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\UserControls\UCTasks.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.AddItem;
                    #line default
                }
                break;
            case 3:
                {
                    this.lvDataBinding = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element4 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 19 "..\..\..\UserControls\UCTasks.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element4).Click += this.CheckBox_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
