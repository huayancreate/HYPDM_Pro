using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraTreeList;
namespace View_Winform.BaseControls
{
    public class BaseTreeListControl : TreeList
    {
        public static TreeList BaseTreeListControlSetting(TreeList treeList, bool showColumns)
        {
            treeList.OptionsBehavior.Editable = false;
            treeList.OptionsView.ShowColumns = showColumns;
            treeList.OptionsView.ShowHorzLines = false;
            treeList.OptionsView.ShowIndicator = false;
            treeList.OptionsView.ShowVertLines = false;
            treeList.LookAndFeel.UseWindowsXPTheme = true;
            treeList.LookAndFeel.UseDefaultLookAndFeel = false;
            treeList.OptionsSelection.EnableAppearanceFocusedCell = false;
            return treeList;
        }
    }
}
