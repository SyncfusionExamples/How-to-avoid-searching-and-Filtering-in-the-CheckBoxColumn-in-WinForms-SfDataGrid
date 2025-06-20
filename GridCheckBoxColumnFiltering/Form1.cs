using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Renderers;
using Syncfusion.WinForms.GridCommon.ScrollAxis;
using Syncfusion.WinForms.Input;

namespace SfDataGrid_Demo_4_8
{
    public partial class Form1 : Form
    {
        public OrderInfoCollection collections;
        public Form1()
        {
            InitializeComponent();
            this.sfDataGrid.SearchController = new SearchHelperExt(this.sfDataGrid);
            // Include the columns that need to search and filter.
            this.sfDataGrid.SearchController.SearchColumns.Add("OrderID");
            this.sfDataGrid.SearchController.SearchColumns.Add("CustomerID");
            this.sfDataGrid.SearchController.SearchColumns.Add("CustomerName");
            this.sfDataGrid.SearchController.SearchColumns.Add("Country");
            this.sfDataGrid.SearchController.SearchColumns.Add("ShipCity");
            collections = new OrderInfoCollection();
            sfDataGrid.DataSource = collections.Orders;
            sfDataGrid.AllowFiltering = true;
            
        }

        private void OnTextChanged(object sender, System.EventArgs e)
        {
            this.sfDataGrid.SearchController.Search(this.textBox.Text);
        }

        private void OnCheckStateChanged(object sender, System.EventArgs e)
        {
            this.sfDataGrid.SearchController.AllowFiltering = AllowFiltering.Checked;
        }

    }

    public class SearchHelperExt : SearchController
    {
        private SfDataGrid sfDataGrid;
        public SearchHelperExt(SfDataGrid datagrid)
            : base(datagrid)
        {
            this.sfDataGrid = datagrid;
        }

        protected override bool FilterRecords(object dataRow)
        {
            if (string.IsNullOrEmpty(SearchText))
                return true;

            if (sfDataGrid != null && sfDataGrid.View != null && sfDataGrid.TableControl != null && sfDataGrid.Columns != null)
            {
                if (this.Provider == null)
                    Provider = this.sfDataGrid.View.GetPropertyAccessProvider();

                int columnIndex = this.sfDataGrid.TableControl.ResolveToGridVisibleColumnIndex(this.GetFirstColumnIndex(this.sfDataGrid, true));

                for (int i = columnIndex; i < this.sfDataGrid.Columns.Count; i++)
                {
                    var column = this.sfDataGrid.Columns[i];

                    // Skip columns not in SearchColumns
                    if (column == null || (SearchColumns.Count > 0 && !SearchColumns.Contains(column.MappingName)))
                        continue;

                    if (column.ActualWidth != 0.0 && column.Visible)
                    {
                        if (MatchSearchText(column, dataRow))
                            return true;
                    }
                }
            }
            
            return false;
        }

        private int GetFirstColumnIndex(SfDataGrid dataGrid, bool isSearching = false)
        {
            int firstIndex = dataGrid.Columns.IndexOf(dataGrid.Columns.FirstOrDefault(x => x.Visible && x.Width != 0d && (x.AllowFocus || isSearching)));
            if (firstIndex < 0)
                return firstIndex;
            firstIndex += dataGrid.View != null ? dataGrid.View.GroupDescriptions.Count : 0;
            if (dataGrid.ShowPreviewRow) firstIndex += 1;
            if (dataGrid.ShowRowHeader)
                firstIndex += 1;
            return firstIndex;
        }
    }

}
