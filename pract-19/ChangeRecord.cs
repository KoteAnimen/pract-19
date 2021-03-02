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
    public partial class ChangeRecord : Form
    {
        public ChangeRecord()
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

        private void ChangeRecord_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tennisDataSet.Теннесисты". При необходимости она может быть перемещена или удалена.
            this.теннесистыTableAdapter.FillBy(this.tennisDataSet.Теннесисты, Id.id);
            фамилияTextBox.Text = tennisDataSet.Теннесисты.Rows[0][0].ToString();
            имяTextBox.Text = tennisDataSet.Теннесисты.Rows[0][1].ToString();
            отчествоTextBox.Text = tennisDataSet.Теннесисты.Rows[0][2].ToString();
            полComboBox.Text = tennisDataSet.Теннесисты.Rows[0][3].ToString();
            годРожденияNumericUpDown.Value = Convert.ToInt32(tennisDataSet.Теннесисты.Rows[0][4]);
            фамилияТренераTextBox.Text = tennisDataSet.Теннесисты.Rows[0][5].ToString();
            имяТренераTextBox.Text = tennisDataSet.Теннесисты.Rows[0][6].ToString();
            отчествотренераTextBox.Text = tennisDataSet.Теннесисты.Rows[0][7].ToString();
            рейтинг1ГодаTextBox.Text = tennisDataSet.Теннесисты.Rows[0][8].ToString();
            рейтинг2ГодаTextBox.Text = tennisDataSet.Теннесисты.Rows[0][9].ToString();
            рейтинг3ГодаTextBox.Text = tennisDataSet.Теннесисты.Rows[0][10].ToString();
            рейтинг4ГодаTextBox.Text = tennisDataSet.Теннесисты.Rows[0][11].ToString();
            рейтинг5ГодаTextBox.Text = tennisDataSet.Теннесисты.Rows[0][12].ToString();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
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
                теннесистыTableAdapter.UpdateRecord(фамилияTextBox.Text, имяTextBox.Text, отчествоTextBox.Text, полComboBox.Text, (short)годРожденияNumericUpDown.Value, фамилияТренераTextBox.Text, имяТренераTextBox.Text, отчествотренераTextBox.Text, странаTextBox.Text, Convert.ToDecimal(рейтинг1ГодаTextBox.Text), Convert.ToDecimal(рейтинг2ГодаTextBox.Text), Convert.ToDecimal(рейтинг3ГодаTextBox.Text), Convert.ToDecimal(рейтинг4ГодаTextBox.Text), Convert.ToDecimal(рейтинг5ГодаTextBox.Text));                
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
