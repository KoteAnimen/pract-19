using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void теннесистыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.теннесистыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tennisDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tennisDataSet.Теннесисты". При необходимости она может быть перемещена или удалена.
            this.теннесистыTableAdapter.Fill(this.tennisDataSet.Теннесисты);

        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            AddRecords records = new AddRecords();
            records.ShowDialog();
            int row, col;
            row = теннесистыDataGridView.CurrentCell.RowIndex;
            col = теннесистыDataGridView.CurrentCell.ColumnIndex;
            this.теннесистыTableAdapter.Fill(this.tennisDataSet.Теннесисты);
            теннесистыDataGridView.CurrentCell = теннесистыDataGridView[col, row];
        }

        private void SearchChange_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
            теннесистыDataGridView.Rows[search.index].Selected = true;
        }
    }
}
