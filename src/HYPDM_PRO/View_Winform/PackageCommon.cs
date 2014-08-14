using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

namespace View_Winform
{
    class PackageCommon
    {
        
        /// <summary>
        /// 设置表格视图样式
        /// </summary>
        /// <param name="gridview"></param>
        public static void SettingGridView(GridView view, params bool[] values)
        {
            view.OptionsBehavior.Editable = false;                              //是否允许编辑
            view.OptionsBehavior.EditorShowMode = EditorShowMode.Click;         //指定单元格编辑器是如何激活的模式
            view.OptionsView.ShowColumnHeaders = true;                          //因为有Band列了，所以把ColumnHeader隐藏
            view.OptionsView.ShowGroupPanel = false;                            //如果没必要分组，就把它去掉
            view.OptionsView.EnableAppearanceEvenRow = false;                   //是否启用偶数行外观
            view.OptionsView.EnableAppearanceOddRow = true;                     //是否启用奇数行外观
            view.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;   //是否显示过滤面板
            view.OptionsView.ColumnAutoWidth = false;                           //是否允许自动列宽
            view.OptionsCustomization.AllowColumnMoving = false;                //是否允许移动列
            view.OptionsCustomization.AllowColumnResizing = false;              //是否允许调整列宽
            view.OptionsCustomization.AllowGroup = false;                       //是否允许分组
            view.OptionsCustomization.AllowFilter = false;                      //是否允许过滤
            view.OptionsCustomization.AllowSort = true;                         //是否允许排序
            view.OptionsSelection.EnableAppearanceFocusedCell = false;          //是否焦点显示选中的单元格
            view.OptionsBehavior.Editable = false;                              //是否允许用户编辑单元格
            view.OptionsDetail.EnableMasterViewMode = false;                    //主从表显示的功能是否可用
            view.OptionsDetail.ShowDetailTabs = false;                          //显示一个Tabs
        }

        public static void SettingTreeList(DevExpress.XtraTreeList.TreeList list)
        {
            list.OptionsBehavior.Editable = false;                              //是否允许编辑
            list.OptionsSelection.EnableAppearanceFocusedCell = false;          //设置焦点单元格外观
            list.OptionsView.ShowIndicator = false;                             //是否显示指示器
        }
        
    }
}
