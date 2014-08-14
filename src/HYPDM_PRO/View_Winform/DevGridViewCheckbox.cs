using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using System.Drawing;
using System.Windows.Forms;

namespace View_Winform
{
    /// <summary>
    /// DEV中设置表格视图的复选按钮相关操作
    /// 包含表格点击事件（Click）、表格列标题绘画事件（CustomDrawColumnHeader）、表格数据源改变事件（DataSourceChanged）、表格行单击事件（RowClick），
    /// 分别负责设置_checkstate状态、重画标题栏、设置列属性、设置单击行效果。
    /// 
    /// </summary>
    public class DevGridViewCheckbox
    {
        private bool _checkstate;//标题中复选按钮状态勾选为true,为勾选为false
        private GridColumn _column;//表格中带复选框的标题
        private GridView _view;//表格对象
        public void SettingGridViewCheckBox(GridView view, GridColumn column)
        {
            this._view = view;
            this._column = column;
            _column.OptionsColumn.ShowCaption = false;
            view.Click += GirdViewClick;
            view.CustomDrawColumnHeader += GirdViewCustomDrawColumnHeader;
            view.DataSourceChanged += GridViewDataSourceChanged;
            view.RowClick += GridViewRowClick;
        }

        private void GirdViewClick(object sender, EventArgs e)
        {
            if (ClickGridCheckBox(_view, _checkstate))
            {
                _checkstate = !_checkstate;
            }
        }

        private void GirdViewCustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null && e.Column.FieldName == _column.FieldName)
            {
                e.Info.InnerElements.Clear();
                e.Painter.DrawObject(e.Info);
                DrawCheckBox(e, _checkstate);
                e.Handled = true;
            }
        }

        private void GridViewDataSourceChanged(object sender, EventArgs e)
        {
            if (_column != null)
            {
                _column.OptionsColumn.ShowCaption = false;
                _column.ColumnEdit = new RepositoryItemCheckEdit();
            }
        }

        private void GridViewRowClick(object sender, RowClickEventArgs e)
        {
            bool value = Convert.ToBoolean(_view.GetRowCellValue(e.RowHandle, _column));
            _view.SetRowCellValue(e.RowHandle, _column, !value);
            int sum = 0;
            for (int i = 0; i < _view.RowCount; i++)
            {
                if (Convert.ToBoolean(_view.GetRowCellValue(i, _column)))
                {
                    sum++;
                }
            }
            if (sum == _view.RowCount) _checkstate = true;
            else _checkstate = false;
            _view.RefreshData();
        }

        /// <summary>
        /// 在列头设置为Checkbox样式
        /// </summary>
        /// <param name="e"></param>
        /// <param name="chk"></param>
        private void DrawCheckBox(DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e, bool chk)
        {
            RepositoryItemCheckEdit repositoryCheck = e.Column.ColumnEdit as RepositoryItemCheckEdit;
            if (repositoryCheck != null)
            {
                Graphics g = e.Graphics;
                Rectangle r = e.Bounds;

                DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info;
                DevExpress.XtraEditors.Drawing.CheckEditPainter painter;
                DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args;
                info = repositoryCheck.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;

                painter = repositoryCheck.CreatePainter() as DevExpress.XtraEditors.Drawing.CheckEditPainter;
                info.EditValue = chk;
                info.Bounds = r;
                info.CalcViewInfo(g);
                args = new DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
                painter.Draw(args);
                args.Cache.Dispose();
            }
        }
        /// <summary>
        /// 单击表格空间列头按钮
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="fieldName"></param>
        /// <param name="currentStatus"></param>
        /// <returns></returns>
        public bool ClickGridCheckBox(DevExpress.XtraGrid.Views.Grid.GridView gridView, bool currentStatus)
        {
            bool result = false;
            if (gridView != null)
            {
                gridView.ClearSorting();//禁止排序

                gridView.PostEditor();
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo info;
                Point pt = gridView.GridControl.PointToClient(Control.MousePosition);
                info = gridView.CalcHitInfo(pt);
                if (info.InColumn && info.Column != null && info.Column.FieldName == _column.FieldName)
                {
                    for (int i = 0; i < gridView.RowCount; i++)
                    {
                        gridView.SetRowCellValue(i, _column, !currentStatus);
                    }
                    return true;
                }
            }
            return result;
        }
    }
}
