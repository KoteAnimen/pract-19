namespace pract_19
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.family = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tennisDataSet = new pract_19.TennisDataSet();
            this.теннесистыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.теннесистыTableAdapter = new pract_19.TennisDataSetTableAdapters.ТеннесистыTableAdapter();
            this.tableAdapterManager = new pract_19.TennisDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tennisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.теннесистыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите фамилию спортсмена";
            // 
            // family
            // 
            this.family.Location = new System.Drawing.Point(15, 30);
            this.family.Name = "family";
            this.family.Size = new System.Drawing.Size(183, 20);
            this.family.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 100);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.family);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск спортсмена";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tennisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.теннесистыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox family;
        private System.Windows.Forms.Button button1;
        private TennisDataSet tennisDataSet;
        private System.Windows.Forms.BindingSource теннесистыBindingSource;
        private TennisDataSetTableAdapters.ТеннесистыTableAdapter теннесистыTableAdapter;
        private TennisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}