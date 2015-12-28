namespace WindowsFormsApplicationJurnal
{
    partial class Stud
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
            this.forTimpDataSet1 = new WindowsFormsApplicationJurnal.ForTimpDataSet1();
            this.группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыTableAdapter = new WindowsFormsApplicationJurnal.ForTimpDataSet1TableAdapters.ГруппыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplicationJurnal.ForTimpDataSet1TableAdapters.TableAdapterManager();
            this.forTimpDataSet2 = new WindowsFormsApplicationJurnal.ForTimpDataSet2();
            this.группыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.группыTableAdapter1 = new WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.ГруппыTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.TableAdapterManager();
            this.группыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter = new WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.ПользователиTableAdapter();
            this.пользователиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предметTableAdapter = new WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.ПредметTableAdapter();
            this.предметDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // forTimpDataSet1
            // 
            this.forTimpDataSet1.DataSetName = "ForTimpDataSet1";
            this.forTimpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // группыBindingSource
            // 
            this.группыBindingSource.DataMember = "Группы";
            this.группыBindingSource.DataSource = this.forTimpDataSet1;
            // 
            // группыTableAdapter
            // 
            this.группыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplicationJurnal.ForTimpDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГруппыTableAdapter = this.группыTableAdapter;
            this.tableAdapterManager.ПаролиTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ПредметTableAdapter = null;
            this.tableAdapterManager.СГПTableAdapter = null;
            // 
            // forTimpDataSet2
            // 
            this.forTimpDataSet2.DataSetName = "ForTimpDataSet2";
            this.forTimpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // группыBindingSource1
            // 
            this.группыBindingSource1.DataMember = "Группы";
            this.группыBindingSource1.DataSource = this.forTimpDataSet2;
            // 
            // группыTableAdapter1
            // 
            this.группыTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ГруппыTableAdapter = this.группыTableAdapter1;
            this.tableAdapterManager1.ПаролиTableAdapter = null;
            this.tableAdapterManager1.ПользователиTableAdapter = this.пользователиTableAdapter;
            this.tableAdapterManager1.ПредметTableAdapter = this.предметTableAdapter;
            this.tableAdapterManager1.СГПTableAdapter = null;
            // 
            // группыDataGridView
            // 
            this.группыDataGridView.AllowUserToAddRows = false;
            this.группыDataGridView.AllowUserToDeleteRows = false;
            this.группыDataGridView.AutoGenerateColumns = false;
            this.группыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.группыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.группыDataGridView.DataSource = this.группыBindingSource1;
            this.группыDataGridView.Location = new System.Drawing.Point(12, 40);
            this.группыDataGridView.Name = "группыDataGridView";
            this.группыDataGridView.ReadOnly = true;
            this.группыDataGridView.Size = new System.Drawing.Size(444, 79);
            this.группыDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_группы";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_группы";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Группа";
            this.dataGridViewTextBoxColumn2.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_предмета";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_предмета";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Оценка";
            this.dataGridViewTextBoxColumn4.HeaderText = "Оценка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.forTimpDataSet2;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // пользователиDataGridView
            // 
            this.пользователиDataGridView.AllowUserToAddRows = false;
            this.пользователиDataGridView.AllowUserToDeleteRows = false;
            this.пользователиDataGridView.AutoGenerateColumns = false;
            this.пользователиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пользователиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9});
            this.пользователиDataGridView.DataSource = this.пользователиBindingSource;
            this.пользователиDataGridView.Location = new System.Drawing.Point(12, 148);
            this.пользователиDataGridView.Name = "пользователиDataGridView";
            this.пользователиDataGridView.ReadOnly = true;
            this.пользователиDataGridView.Size = new System.Drawing.Size(444, 104);
            this.пользователиDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id_пользователя";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id_пользователя";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn6.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn7.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn8.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Преподаватель";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Преподаватель";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Группа";
            this.dataGridViewTextBoxColumn9.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // предметBindingSource
            // 
            this.предметBindingSource.DataMember = "Предмет";
            this.предметBindingSource.DataSource = this.forTimpDataSet2;
            // 
            // предметTableAdapter
            // 
            this.предметTableAdapter.ClearBeforeFill = true;
            // 
            // предметDataGridView
            // 
            this.предметDataGridView.AllowUserToAddRows = false;
            this.предметDataGridView.AllowUserToDeleteRows = false;
            this.предметDataGridView.AutoGenerateColumns = false;
            this.предметDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.предметDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.предметDataGridView.DataSource = this.предметBindingSource;
            this.предметDataGridView.Location = new System.Drawing.Point(12, 279);
            this.предметDataGridView.Name = "предметDataGridView";
            this.предметDataGridView.ReadOnly = true;
            this.предметDataGridView.Size = new System.Drawing.Size(444, 90);
            this.предметDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Id_предмета";
            this.dataGridViewTextBoxColumn10.HeaderText = "Id_предмета";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn11.HeaderText = "Название";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Группы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пользователи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Предметы";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            this.менюToolStripMenuItem.ToolTipText = "Это меню";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Stud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 390);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.предметDataGridView);
            this.Controls.Add(this.пользователиDataGridView);
            this.Controls.Add(this.группыDataGridView);
            this.Name = "Stud";
            this.Text = "Stud";
            this.Load += new System.EventHandler(this.Stud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ForTimpDataSet1 forTimpDataSet1;
        private System.Windows.Forms.BindingSource группыBindingSource;
        private ForTimpDataSet1TableAdapters.ГруппыTableAdapter группыTableAdapter;
        private ForTimpDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private ForTimpDataSet2 forTimpDataSet2;
        private System.Windows.Forms.BindingSource группыBindingSource1;
        private ForTimpDataSet2TableAdapters.ГруппыTableAdapter группыTableAdapter1;
        private ForTimpDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private ForTimpDataSet2TableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.DataGridView группыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private ForTimpDataSet2TableAdapters.ПредметTableAdapter предметTableAdapter;
        private System.Windows.Forms.DataGridView пользователиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource предметBindingSource;
        private System.Windows.Forms.DataGridView предметDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}