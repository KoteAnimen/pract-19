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
            this.теннесистыTableAdapter.Fill(this.tennisDataSet.Теннесисты);            
        }

        private void SearchChange_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
            теннесистыDataGridView.Rows[search.index].Selected = true;            
            ChangeRecord change = new ChangeRecord();
            change.ShowDialog();
            this.теннесистыTableAdapter.Fill(this.tennisDataSet.Теннесисты);
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Удаление записи", "Подтвердите удаление записи", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                теннесистыBindingSource.RemoveCurrent();
                теннесистыTableAdapter.Update(this.tennisDataSet.Теннесисты);
            }
        }

        private void CountWoman_Click(object sender, EventArgs e)
        {
            int count = 0;
            for(int i = 0; i < теннесистыDataGridView.RowCount; i++)
            {
                if(Convert.ToString(теннесистыDataGridView[3, i].Value) == "Жен")
                {
                    count++;
                }
            }
            MessageBox.Show("Количество женщин = " + count, "Количество женщин");
        }

        private void CountMan_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < теннесистыDataGridView.RowCount; i++)
            {
                if (Convert.ToString(теннесистыDataGridView[3, i].Value) == "Муж")
                {
                    count++;                    
                }
            }
            MessageBox.Show("Количество мужчин = " + count, "Количество мужчин");
        }
    }

    public static class Id
    {
        public static string id;
    }
}
