namespace WindowsFormsApplicationJurnal
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.паролиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.forTimpDataSet = new WindowsFormsApplicationJurnal.ForTimpDataSet();
            this.паролиTableAdapter = new WindowsFormsApplicationJurnal.ForTimpDataSetTableAdapters.ПаролиTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplicationJurnal.ForTimpDataSetTableAdapters.TableAdapterManager();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter = new WindowsFormsApplicationJurnal.ForTimpDataSetTableAdapters.ПользователиTableAdapter();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxViewPassword = new System.Windows.Forms.CheckBox();
            this.forTimpDataSet1 = new WindowsFormsApplicationJurnal.ForTimpDataSet1();
            this.паролиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.паролиTableAdapter1 = new WindowsFormsApplicationJurnal.ForTimpDataSet1TableAdapters.ПаролиTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApplicationJurnal.ForTimpDataSet1TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.паролиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.паролиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // паролиBindingSource
            // 
            this.паролиBindingSource.DataMember = "Пароли";
            this.паролиBindingSource.DataSource = this.forTimpDataSet;
            // 
            // forTimpDataSet
            // 
            this.forTimpDataSet.DataSetName = "ForTimpDataSet";
            this.forTimpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.forTimpDataSet;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(63, 6);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(63, 40);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "Логин";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 40);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Пароль";
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(12, 89);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 12;
            this.buttonInput.Text = "Войти";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 89);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "В&ыход";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxViewPassword
            // 
            this.checkBoxViewPassword.AutoSize = true;
            this.checkBoxViewPassword.Location = new System.Drawing.Point(15, 66);
            this.checkBoxViewPassword.Name = "checkBoxViewPassword";
            this.checkBoxViewPassword.Size = new System.Drawing.Size(114, 17);
            this.checkBoxViewPassword.TabIndex = 14;
            this.checkBoxViewPassword.Text = "Показать пароль";
            this.checkBoxViewPassword.UseVisualStyleBackColor = true;
            this.checkBoxViewPassword.CheckedChanged += new System.EventHandler(this.checkBoxViewPassword_CheckedChanged);
            // 
            // forTimpDataSet1
            // 
            this.forTimpDataSet1.DataSetName = "ForTimpDataSet1";
            this.forTimpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // паролиBindingSource1
            // 
            this.паролиBindingSource1.DataMember = "Пароли";
            this.паролиBindingSource1.DataSource = this.forTimpDataSet1;
            // 
            // паролиTableAdapter1
            // 
            this.паролиTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplicationJurnal.ForTimpDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ГруппыTableAdapter = null;
            this.tableAdapterManager1.ПаролиTableAdapter = this.паролиTableAdapter1;
            this.tableAdapterManager1.ПользователиTableAdapter = null;
            this.tableAdapterManager1.ПредметTableAdapter = null;
            this.tableAdapterManager1.СГПTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-13, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 18);
            this.button1.TabIndex = 15;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 136);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxViewPassword);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "Login";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.паролиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.паролиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ForTimpDataSet forTimpDataSet;
        private System.Windows.Forms.BindingSource паролиBindingSource;
        private ForTimpDataSetTableAdapters.ПаролиTableAdapter паролиTableAdapter;
        private ForTimpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private ForTimpDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxViewPassword;
        private ForTimpDataSet1 forTimpDataSet1;
        private System.Windows.Forms.BindingSource паролиBindingSource1;
        private ForTimpDataSet1TableAdapters.ПаролиTableAdapter паролиTableAdapter1;
        private ForTimpDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button1;
    }
}

