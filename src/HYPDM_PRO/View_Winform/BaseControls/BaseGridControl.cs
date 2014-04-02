using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View_Winform.BaseControls
{
    public class BaseGridControl : DevExpress.XtraGrid.GridControl
    {
        public BaseGridControl(GridControl grid, bool autoWidth)
        {
            GridView gridView = grid.MainView as GridView;
            //gridView.OptionsView.ColumnAutoWidth = autoWidth;
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            //gridView.OptionsView.ShowIndicator = false;
            //gridView.OptionsView.ShowGroupPanel = false;
            //gridView.FocusRectStyle = DrawFocusRectStyle.None;
            //gridView.BestFitColumns();
        }
    }
}
