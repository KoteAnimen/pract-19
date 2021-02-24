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
    public partial class Search: Form
    {

        public int index;
        public Search()
        {
            InitializeComponent();
        }

        

        private void ТеннесистыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.теннесистыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tennisDataSet);

        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tennisDataSet.Теннесисты". При необходимости она может быть перемещена или удалена.
            this.теннесистыTableAdapter.Fill(this.tennisDataSet.Теннесисты);

        }

        private void Button1_Click(object sender, EventArgs e)
        {            
            index = теннесистыBindingSource.Find("Фамилия", family.Text);
            if (index > -1)
            {
                теннесистыBindingSource.Position = index;                
                Close();
            } 
            else MessageBox.Show("Ничего не найдено.");
        }
    }
}
