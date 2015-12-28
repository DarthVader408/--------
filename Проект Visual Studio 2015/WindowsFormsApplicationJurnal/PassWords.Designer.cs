namespace WindowsFormsApplicationJurnal
{
    partial class PassWords
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
            this.forTimpDataSet = new WindowsFormsApplicationJurnal.ForTimpDataSet();
            this.паролиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.паролиTableAdapter = new WindowsFormsApplicationJurnal.ForTimpDataSetTableAdapters.ПаролиTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplicationJurnal.ForTimpDataSetTableAdapters.TableAdapterManager();
            this.forTimpDataSet2 = new WindowsFormsApplicationJurnal.ForTimpDataSet2();
            this.паролиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.паролиTableAdapter1 = new WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.ПаролиTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.TableAdapterManager();
            this.паролиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.паролиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.паролиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.паролиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // forTimpDataSet
            // 
            this.forTimpDataSet.DataSetName = "ForTimpDataSet";
            this.forTimpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // паролиBindingSource
            // 
            this.паролиBindingSource.DataMember = "Пароли";
            this.паролиBindingSource.DataSource = this.forTimpDataSet;
            // 
            // паролиTableAdapter
            // 
            this.паролиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplicationJurnal.ForTimpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГруппыTableAdapter = null;
            this.tableAdapterManager.ПаролиTableAdapter = this.паролиTableAdapter;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ПредметTableAdapter = null;
            this.tableAdapterManager.СГПTableAdapter = null;
            // 
            // forTimpDataSet2
            // 
            this.forTimpDataSet2.DataSetName = "ForTimpDataSet2";
            this.forTimpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // паролиBindingSource1
            // 
            this.паролиBindingSource1.DataMember = "Пароли";
            this.паролиBindingSource1.DataSource = this.forTimpDataSet2;
            // 
            // паролиTableAdapter1
            // 
            this.паролиTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ГруппыTableAdapter = null;
            this.tableAdapterManager1.ПаролиTableAdapter = this.паролиTableAdapter1;
            this.tableAdapterManager1.ПользователиTableAdapter = null;
            this.tableAdapterManager1.ПредметTableAdapter = null;
            this.tableAdapterManager1.СГПTableAdapter = null;
            // 
            // паролиDataGridView
            // 
            this.паролиDataGridView.AllowUserToAddRows = false;
            this.паролиDataGridView.AllowUserToDeleteRows = false;
            this.паролиDataGridView.AutoGenerateColumns = false;
            this.паролиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.паролиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.паролиDataGridView.DataSource = this.паролиBindingSource1;
            this.паролиDataGridView.Location = new System.Drawing.Point(12, 25);
            this.паролиDataGridView.Name = "паролиDataGridView";
            this.паролиDataGridView.ReadOnly = true;
            this.паролиDataGridView.Size = new System.Drawing.Size(363, 250);
            this.паролиDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_пользователя";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_пользователя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Логин";
            this.dataGridViewTextBoxColumn2.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Пароль";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "СИСТЕМНЫЙ АДМИНИСТРАТОР";
            // 
            // PassWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.паролиDataGridView);
            this.Name = "PassWords";
            this.Text = "PassWords";
            this.Load += new System.EventHandler(this.PassWords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.паролиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.паролиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.паролиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ForTimpDataSet forTimpDataSet;
        private System.Windows.Forms.BindingSource паролиBindingSource;
        private ForTimpDataSetTableAdapters.ПаролиTableAdapter паролиTableAdapter;
        private ForTimpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ForTimpDataSet2 forTimpDataSet2;
        private System.Windows.Forms.BindingSource паролиBindingSource1;
        private ForTimpDataSet2TableAdapters.ПаролиTableAdapter паролиTableAdapter1;
        private ForTimpDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView паролиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
    }
}