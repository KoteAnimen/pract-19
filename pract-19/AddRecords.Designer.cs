namespace pract_19
{
    partial class AddRecords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label годРожденияLabel;
            System.Windows.Forms.Label фамилияТренераLabel;
            System.Windows.Forms.Label имяТренераLabel;
            System.Windows.Forms.Label отчествотренераLabel;
            System.Windows.Forms.Label странаLabel;
            System.Windows.Forms.Label рейтинг1ГодаLabel;
            System.Windows.Forms.Label рейтинг2ГодаLabel;
            System.Windows.Forms.Label рейтинг3ГодаLabel;
            System.Windows.Forms.Label рейтинг4ГодаLabel;
            System.Windows.Forms.Label рейтинг5ГодаLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tennisDataSet = new pract_19.TennisDataSet();
            this.теннесистыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.теннесистыTableAdapter = new pract_19.TennisDataSetTableAdapters.ТеннесистыTableAdapter();
            this.tableAdapterManager = new pract_19.TennisDataSetTableAdapters.TableAdapterManager();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.полComboBox = new System.Windows.Forms.ComboBox();
            this.годРожденияNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.фамилияТренераTextBox = new System.Windows.Forms.TextBox();
            this.имяТренераTextBox = new System.Windows.Forms.TextBox();
            this.отчествотренераTextBox = new System.Windows.Forms.TextBox();
            this.странаTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.рейтинг1ГодаTextBox = new System.Windows.Forms.TextBox();
            this.рейтинг2ГодаTextBox = new System.Windows.Forms.TextBox();
            this.рейтинг3ГодаTextBox = new System.Windows.Forms.TextBox();
            this.рейтинг4ГодаTextBox = new System.Windows.Forms.TextBox();
            this.рейтинг5ГодаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            годРожденияLabel = new System.Windows.Forms.Label();
            фамилияТренераLabel = new System.Windows.Forms.Label();
            имяТренераLabel = new System.Windows.Forms.Label();
            отчествотренераLabel = new System.Windows.Forms.Label();
            странаLabel = new System.Windows.Forms.Label();
            рейтинг1ГодаLabel = new System.Windows.Forms.Label();
            рейтинг2ГодаLabel = new System.Windows.Forms.Label();
            рейтинг3ГодаLabel = new System.Windows.Forms.Label();
            рейтинг4ГодаLabel = new System.Windows.Forms.Label();
            рейтинг5ГодаLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tennisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.теннесистыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.годРожденияNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(странаLabel);
            this.groupBox1.Controls.Add(this.странаTextBox);
            this.groupBox1.Controls.Add(отчествотренераLabel);
            this.groupBox1.Controls.Add(this.отчествотренераTextBox);
            this.groupBox1.Controls.Add(имяТренераLabel);
            this.groupBox1.Controls.Add(this.имяТренераTextBox);
            this.groupBox1.Controls.Add(фамилияТренераLabel);
            this.groupBox1.Controls.Add(this.фамилияТренераTextBox);
            this.groupBox1.Controls.Add(годРожденияLabel);
            this.groupBox1.Controls.Add(this.годРожденияNumericUpDown);
            this.groupBox1.Controls.Add(полLabel);
            this.groupBox1.Controls.Add(this.полComboBox);
            this.groupBox1.Controls.Add(отчествоLabel);
            this.groupBox1.Controls.Add(this.отчествоTextBox);
            this.groupBox1.Controls.Add(имяLabel);
            this.groupBox1.Controls.Add(this.имяTextBox);
            this.groupBox1.Controls.Add(фамилияLabel);
            this.groupBox1.Controls.Add(this.фамилияTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Анкета спортсмена";
            // 
            // tennisDataSet
            // 
            this.tennisDataSet.DataSetName = "TennisDataSet";
            this.tennisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // теннесистыBindingSource
            // 
            this.теннесистыBindingSource.DataMember = "Теннесисты";
            this.теннесистыBindingSource.DataSource = this.tennisDataSet;
            // 
            // теннесистыTableAdapter
            // 
            this.теннесистыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = pract_19.TennisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ТеннесистыTableAdapter = this.теннесистыTableAdapter;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(18, 37);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 0;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(21, 53);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(100, 20);
            this.фамилияTextBox.TabIndex = 1;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(124, 37);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 2;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(127, 53);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(100, 20);
            this.имяTextBox.TabIndex = 3;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(230, 37);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 4;
            отчествоLabel.Text = "Отчество:";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(233, 53);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(100, 20);
            this.отчествоTextBox.TabIndex = 5;
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(155, 86);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(30, 13);
            полLabel.TabIndex = 6;
            полLabel.Text = "Пол:";
            // 
            // полComboBox
            // 
            this.полComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "Пол", true));
            this.полComboBox.FormattingEnabled = true;
            this.полComboBox.Items.AddRange(new object[] {
            "Муж",
            "Жен"});
            this.полComboBox.Location = new System.Drawing.Point(158, 102);
            this.полComboBox.Name = "полComboBox";
            this.полComboBox.Size = new System.Drawing.Size(72, 21);
            this.полComboBox.TabIndex = 7;
            // 
            // годРожденияLabel
            // 
            годРожденияLabel.AutoSize = true;
            годРожденияLabel.Location = new System.Drawing.Point(18, 86);
            годРожденияLabel.Name = "годРожденияLabel";
            годРожденияLabel.Size = new System.Drawing.Size(82, 13);
            годРожденияLabel.TabIndex = 8;
            годРожденияLabel.Text = "Год Рождения:";
            // 
            // годРожденияNumericUpDown
            // 
            this.годРожденияNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.теннесистыBindingSource, "ГодРождения", true));
            this.годРожденияNumericUpDown.Location = new System.Drawing.Point(21, 102);
            this.годРожденияNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.годРожденияNumericUpDown.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.годРожденияNumericUpDown.Name = "годРожденияNumericUpDown";
            this.годРожденияNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.годРожденияNumericUpDown.TabIndex = 9;
            this.годРожденияNumericUpDown.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // фамилияТренераLabel
            // 
            фамилияТренераLabel.AutoSize = true;
            фамилияТренераLabel.Location = new System.Drawing.Point(18, 184);
            фамилияТренераLabel.Name = "фамилияТренераLabel";
            фамилияТренераLabel.Size = new System.Drawing.Size(105, 13);
            фамилияТренераLabel.TabIndex = 10;
            фамилияТренераLabel.Text = "Фамилия Тренера:";
            // 
            // фамилияТренераTextBox
            // 
            this.фамилияТренераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "ФамилияТренера", true));
            this.фамилияТренераTextBox.Location = new System.Drawing.Point(21, 200);
            this.фамилияТренераTextBox.Name = "фамилияТренераTextBox";
            this.фамилияТренераTextBox.Size = new System.Drawing.Size(100, 20);
            this.фамилияТренераTextBox.TabIndex = 11;
            // 
            // имяТренераLabel
            // 
            имяТренераLabel.AutoSize = true;
            имяТренераLabel.Location = new System.Drawing.Point(124, 184);
            имяТренераLabel.Name = "имяТренераLabel";
            имяТренераLabel.Size = new System.Drawing.Size(78, 13);
            имяТренераLabel.TabIndex = 12;
            имяТренераLabel.Text = "Имя Тренера:";
            // 
            // имяТренераTextBox
            // 
            this.имяТренераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "ИмяТренера", true));
            this.имяТренераTextBox.Location = new System.Drawing.Point(127, 200);
            this.имяТренераTextBox.Name = "имяТренераTextBox";
            this.имяТренераTextBox.Size = new System.Drawing.Size(100, 20);
            this.имяТренераTextBox.TabIndex = 13;
            // 
            // отчествотренераLabel
            // 
            отчествотренераLabel.AutoSize = true;
            отчествотренераLabel.Location = new System.Drawing.Point(230, 184);
            отчествотренераLabel.Name = "отчествотренераLabel";
            отчествотренераLabel.Size = new System.Drawing.Size(103, 13);
            отчествотренераLabel.TabIndex = 14;
            отчествотренераLabel.Text = "Отчество Тренера:";
            // 
            // отчествотренераTextBox
            // 
            this.отчествотренераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "Отчествотренера", true));
            this.отчествотренераTextBox.Location = new System.Drawing.Point(233, 200);
            this.отчествотренераTextBox.Name = "отчествотренераTextBox";
            this.отчествотренераTextBox.Size = new System.Drawing.Size(100, 20);
            this.отчествотренераTextBox.TabIndex = 15;
            // 
            // странаLabel
            // 
            странаLabel.AutoSize = true;
            странаLabel.Location = new System.Drawing.Point(20, 134);
            странаLabel.Name = "странаLabel";
            странаLabel.Size = new System.Drawing.Size(46, 13);
            странаLabel.TabIndex = 16;
            странаLabel.Text = "Страна:";
            // 
            // странаTextBox
            // 
            this.странаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "Страна", true));
            this.странаTextBox.Location = new System.Drawing.Point(21, 150);
            this.странаTextBox.Name = "странаTextBox";
            this.странаTextBox.Size = new System.Drawing.Size(136, 20);
            this.странаTextBox.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(рейтинг5ГодаLabel);
            this.groupBox2.Controls.Add(this.рейтинг5ГодаTextBox);
            this.groupBox2.Controls.Add(рейтинг4ГодаLabel);
            this.groupBox2.Controls.Add(this.рейтинг4ГодаTextBox);
            this.groupBox2.Controls.Add(рейтинг3ГодаLabel);
            this.groupBox2.Controls.Add(this.рейтинг3ГодаTextBox);
            this.groupBox2.Controls.Add(рейтинг2ГодаLabel);
            this.groupBox2.Controls.Add(this.рейтинг2ГодаTextBox);
            this.groupBox2.Controls.Add(рейтинг1ГодаLabel);
            this.groupBox2.Controls.Add(this.рейтинг1ГодаTextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 82);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Рейтинг за 5 лет";
            // 
            // рейтинг1ГодаLabel
            // 
            рейтинг1ГодаLabel.AutoSize = true;
            рейтинг1ГодаLabel.Location = new System.Drawing.Point(6, 27);
            рейтинг1ГодаLabel.Name = "рейтинг1ГодаLabel";
            рейтинг1ГодаLabel.Size = new System.Drawing.Size(100, 13);
            рейтинг1ГодаLabel.TabIndex = 0;
            рейтинг1ГодаLabel.Text = "Рейтинг 1-го года:";
            // 
            // рейтинг1ГодаTextBox
            // 
            this.рейтинг1ГодаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "Рейтинг1Года", true));
            this.рейтинг1ГодаTextBox.Location = new System.Drawing.Point(8, 43);
            this.рейтинг1ГодаTextBox.Name = "рейтинг1ГодаTextBox";
            this.рейтинг1ГодаTextBox.Size = new System.Drawing.Size(100, 20);
            this.рейтинг1ГодаTextBox.TabIndex = 1;
            // 
            // рейтинг2ГодаLabel
            // 
            рейтинг2ГодаLabel.AutoSize = true;
            рейтинг2ГодаLabel.Location = new System.Drawing.Point(111, 29);
            рейтинг2ГодаLabel.Name = "рейтинг2ГодаLabel";
            рейтинг2ГодаLabel.Size = new System.Drawing.Size(100, 13);
            рейтинг2ГодаLabel.TabIndex = 2;
            рейтинг2ГодаLabel.Text = "Рейтинг 2-го года:";
            // 
            // рейтинг2ГодаTextBox
            // 
            this.рейтинг2ГодаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "Рейтинг2Года", true));
            this.рейтинг2ГодаTextBox.Location = new System.Drawing.Point(114, 43);
            this.рейтинг2ГодаTextBox.Name = "рейтинг2ГодаTextBox";
            this.рейтинг2ГодаTextBox.Size = new System.Drawing.Size(100, 20);
            this.рейтинг2ГодаTextBox.TabIndex = 3;
            // 
            // рейтинг3ГодаLabel
            // 
            рейтинг3ГодаLabel.AutoSize = true;
            рейтинг3ГодаLabel.Location = new System.Drawing.Point(217, 27);
            рейтинг3ГодаLabel.Name = "рейтинг3ГодаLabel";
            рейтинг3ГодаLabel.Size = new System.Drawing.Size(100, 13);
            рейтинг3ГодаLabel.TabIndex = 4;
            рейтинг3ГодаLabel.Text = "Рейтинг 3-го года:";
            // 
            // рейтинг3ГодаTextBox
            // 
            this.рейтинг3ГодаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "Рейтинг3Года", true));
            this.рейтинг3ГодаTextBox.Location = new System.Drawing.Point(220, 43);
            this.рейтинг3ГодаTextBox.Name = "рейтинг3ГодаTextBox";
            this.рейтинг3ГодаTextBox.Size = new System.Drawing.Size(100, 20);
            this.рейтинг3ГодаTextBox.TabIndex = 5;
            // 
            // рейтинг4ГодаLabel
            // 
            рейтинг4ГодаLabel.AutoSize = true;
            рейтинг4ГодаLabel.Location = new System.Drawing.Point(323, 27);
            рейтинг4ГодаLabel.Name = "рейтинг4ГодаLabel";
            рейтинг4ГодаLabel.Size = new System.Drawing.Size(100, 13);
            рейтинг4ГодаLabel.TabIndex = 6;
            рейтинг4ГодаLabel.Text = "Рейтинг 4-го года:";
            // 
            // рейтинг4ГодаTextBox
            // 
            this.рейтинг4ГодаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "Рейтинг4Года", true));
            this.рейтинг4ГодаTextBox.Location = new System.Drawing.Point(326, 43);
            this.рейтинг4ГодаTextBox.Name = "рейтинг4ГодаTextBox";
            this.рейтинг4ГодаTextBox.Size = new System.Drawing.Size(100, 20);
            this.рейтинг4ГодаTextBox.TabIndex = 7;
            // 
            // рейтинг5ГодаLabel
            // 
            рейтинг5ГодаLabel.AutoSize = true;
            рейтинг5ГодаLabel.Location = new System.Drawing.Point(429, 28);
            рейтинг5ГодаLabel.Name = "рейтинг5ГодаLabel";
            рейтинг5ГодаLabel.Size = new System.Drawing.Size(100, 13);
            рейтинг5ГодаLabel.TabIndex = 8;
            рейтинг5ГодаLabel.Text = "Рейтинг 5-го года:";
            // 
            // рейтинг5ГодаTextBox
            // 
            this.рейтинг5ГодаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.теннесистыBindingSource, "Рейтинг5Года", true));
            this.рейтинг5ГодаTextBox.Location = new System.Drawing.Point(432, 43);
            this.рейтинг5ГодаTextBox.Name = "рейтинг5ГодаTextBox";
            this.рейтинг5ГодаTextBox.Size = new System.Drawing.Size(100, 20);
            this.рейтинг5ГодаTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(21, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Добавить запись о спортсмене";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(311, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 422);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRecords";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.AddRecords_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tennisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.теннесистыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.годРожденияNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private TennisDataSet tennisDataSet;
        private System.Windows.Forms.BindingSource теннесистыBindingSource;
        private TennisDataSetTableAdapters.ТеннесистыTableAdapter теннесистыTableAdapter;
        private TennisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.NumericUpDown годРожденияNumericUpDown;
        private System.Windows.Forms.ComboBox полComboBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox фамилияТренераTextBox;
        private System.Windows.Forms.TextBox имяТренераTextBox;
        private System.Windows.Forms.TextBox странаTextBox;
        private System.Windows.Forms.TextBox отчествотренераTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox рейтинг2ГодаTextBox;
        private System.Windows.Forms.TextBox рейтинг1ГодаTextBox;
        private System.Windows.Forms.TextBox рейтинг3ГодаTextBox;
        private System.Windows.Forms.TextBox рейтинг5ГодаTextBox;
        private System.Windows.Forms.TextBox рейтинг4ГодаTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}