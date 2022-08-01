using System.Drawing;
using System.Windows.Forms;

namespace Maximas
{
    class skin
    {
        // style data grids
        public void style(DataGridView dataGrid)
        {
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGrid.RowHeadersWidth = 30;
            dataGrid.RowHeadersVisible = false;

            dataGrid.BackgroundColor = Color.FromArgb(34,34,34);
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            dataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGrid.RowsDefaultCellStyle.ForeColor = Color.White;
            dataGrid.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);

            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGrid.DefaultCellStyle.Font = new Font("Roboto", 9);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 9);
            dataGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Roboto", 9);
        }
    }
}
