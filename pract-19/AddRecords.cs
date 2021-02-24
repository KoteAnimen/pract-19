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
    public partial class AddRecords : Form
    {
        public AddRecords()
        {
            InitializeComponent();
        }

        private void теннесистыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.теннесистыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tennisDataSet);

        }

        private void теннесистыBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.теннесистыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tennisDataSet);

        }

        private void AddRecords_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tennisDataSet.Теннесисты". При необходимости она может быть перемещена или удалена.            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (фамилияTextBox.Text == "")
            {
                MessageBox.Show("Введите фамилию", "Ошибка");
                return;
            } 
            if (имяTextBox.Text == "")
            {
                MessageBox.Show("Введите имя", "Ошибка");
                return;
            } 
            if (полComboBox.Text != "Муж" && полComboBox.Text != "Жен")
            {
                MessageBox.Show("Укажите пол", "Ошибка");
                return;
            }
            if (странаTextBox.Text == "")
            {
                MessageBox.Show("Введите страну", "Ошибка");
                return;
            }
            try
            {
                теннесистыTableAdapter.Insert(фамилияTextBox.Text, имяTextBox.Text, отчествоTextBox.Text, полComboBox.Text, (short)годРожденияNumericUpDown.Value, фамилияТренераTextBox.Text, имяТренераTextBox.Text, отчествотренераTextBox.Text, странаTextBox.Text, Convert.ToDouble(рейтинг1ГодаTextBox.Text), Convert.ToDouble(рейтинг2ГодаTextBox.Text), Convert.ToDouble(рейтинг3ГодаTextBox.Text), Convert.ToDouble(рейтинг4ГодаTextBox.Text), Convert.ToDouble(рейтинг5ГодаTextBox.Text));                
                Close();
            }
            catch
            {
                MessageBox.Show("Некорректно заполнен рейтинг теннесиста", "Ошибка");
                return;
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
            
    }
}
