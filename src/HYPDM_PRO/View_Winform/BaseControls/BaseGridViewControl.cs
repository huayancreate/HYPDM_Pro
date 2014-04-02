using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;

namespace View_Winform.BaseControls
{
    public class BaseGridViewControl : GridView
    {
        public static GridView BaseGridViewControlSetting(GridView gridView, bool autoWidth)
        {
            gridView.OptionsView.ColumnAutoWidth = autoWidth;
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsView.ShowIndicator = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.FocusRectStyle = DrawFocusRectStyle.None;
            gridView.BestFitColumns();
            return gridView;
        }
    }
}
