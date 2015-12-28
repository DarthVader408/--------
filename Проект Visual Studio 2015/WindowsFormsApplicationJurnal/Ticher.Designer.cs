namespace WindowsFormsApplicationJurnal
{
    partial class Ticher
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
            System.Windows.Forms.Label id_группыLabel;
            System.Windows.Forms.Label группаLabel;
            System.Windows.Forms.Label id_предметаLabel;
            System.Windows.Forms.Label оценкаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticher));
            this.forTimpDataSet = new WindowsFormsApplicationJurnal.ForTimpDataSet();
            this.группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыTableAdapter = new WindowsFormsApplicationJurnal.ForTimpDataSetTableAdapters.ГруппыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplicationJurnal.ForTimpDataSetTableAdapters.TableAdapterManager();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter = new WindowsFormsApplicationJurnal.ForTimpDataSetTableAdapters.ПользователиTableAdapter();
            this.предметBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предметTableAdapter = new WindowsFormsApplicationJurnal.ForTimpDataSetTableAdapters.ПредметTableAdapter();
            this.сГПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сГПTableAdapter = new WindowsFormsApplicationJurnal.ForTimpDataSetTableAdapters.СГПTableAdapter();
            this.forTimpDataSet2 = new WindowsFormsApplicationJurnal.ForTimpDataSet2();
            this.пользователиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter1 = new WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.ПользователиTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.TableAdapterManager();
            this.пользователиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.группыTableAdapter1 = new WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.ГруппыTableAdapter();
            this.id_группыTextBox = new System.Windows.Forms.TextBox();
            this.группаTextBox = new System.Windows.Forms.TextBox();
            this.id_предметаTextBox = new System.Windows.Forms.TextBox();
            this.оценкаTextBox = new System.Windows.Forms.TextBox();
            this.предметBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.предметTableAdapter1 = new WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.ПредметTableAdapter();
            this.предметDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.соревнованияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            id_группыLabel = new System.Windows.Forms.Label();
            группаLabel = new System.Windows.Forms.Label();
            id_предметаLabel = new System.Windows.Forms.Label();
            оценкаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сГПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // forTimpDataSet
            // 
            this.forTimpDataSet.DataSetName = "ForTimpDataSet";
            this.forTimpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // группыBindingSource
            // 
            this.группыBindingSource.DataMember = "Группы";
            this.группыBindingSource.DataSource = this.forTimpDataSet;
            // 
            // группыTableAdapter
            // 
            this.группыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplicationJurnal.ForTimpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГруппыTableAdapter = this.группыTableAdapter;
            this.tableAdapterManager.ПаролиTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = this.пользователиTableAdapter;
            this.tableAdapterManager.ПредметTableAdapter = this.предметTableAdapter;
            this.tableAdapterManager.СГПTableAdapter = this.сГПTableAdapter;
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
            // предметBindingSource
            // 
            this.предметBindingSource.DataMember = "Предмет";
            this.предметBindingSource.DataSource = this.forTimpDataSet;
            // 
            // предметTableAdapter
            // 
            this.предметTableAdapter.ClearBeforeFill = true;
            // 
            // сГПBindingSource
            // 
            this.сГПBindingSource.DataMember = "СГП";
            this.сГПBindingSource.DataSource = this.forTimpDataSet;
            // 
            // сГПTableAdapter
            // 
            this.сГПTableAdapter.ClearBeforeFill = true;
            // 
            // forTimpDataSet2
            // 
            this.forTimpDataSet2.DataSetName = "ForTimpDataSet2";
            this.forTimpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользователиBindingSource1
            // 
            this.пользователиBindingSource1.DataMember = "Пользователи";
            this.пользователиBindingSource1.DataSource = this.forTimpDataSet2;
            // 
            // пользователиTableAdapter1
            // 
            this.пользователиTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplicationJurnal.ForTimpDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ГруппыTableAdapter = this.группыTableAdapter1;
            this.tableAdapterManager1.ПаролиTableAdapter = null;
            this.tableAdapterManager1.ПользователиTableAdapter = this.пользователиTableAdapter1;
            this.tableAdapterManager1.ПредметTableAdapter = this.предметTableAdapter1;
            this.tableAdapterManager1.СГПTableAdapter = null;
            // 
            // пользователиDataGridView
            // 
            this.пользователиDataGridView.AllowUserToAddRows = false;
            this.пользователиDataGridView.AllowUserToDeleteRows = false;
            this.пользователиDataGridView.AutoGenerateColumns = false;
            this.пользователиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пользователиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.пользователиDataGridView.DataSource = this.пользователиBindingSource1;
            this.пользователиDataGridView.Location = new System.Drawing.Point(12, 160);
            this.пользователиDataGridView.Name = "пользователиDataGridView";
            this.пользователиDataGridView.ReadOnly = true;
            this.пользователиDataGridView.Size = new System.Drawing.Size(606, 113);
            this.пользователиDataGridView.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Преподаватель";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Преподаватель";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Группа";
            this.dataGridViewTextBoxColumn5.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
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
            // id_группыLabel
            // 
            id_группыLabel.AutoSize = true;
            id_группыLabel.Location = new System.Drawing.Point(21, 47);
            id_группыLabel.Name = "id_группыLabel";
            id_группыLabel.Size = new System.Drawing.Size(57, 13);
            id_группыLabel.TabIndex = 1;
            id_группыLabel.Text = "id группы:";
            // 
            // id_группыTextBox
            // 
            this.id_группыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группыBindingSource1, "id_группы", true));
            this.id_группыTextBox.Location = new System.Drawing.Point(98, 44);
            this.id_группыTextBox.Name = "id_группыTextBox";
            this.id_группыTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_группыTextBox.TabIndex = 2;
            // 
            // группаLabel
            // 
            группаLabel.AutoSize = true;
            группаLabel.Location = new System.Drawing.Point(21, 73);
            группаLabel.Name = "группаLabel";
            группаLabel.Size = new System.Drawing.Size(45, 13);
            группаLabel.TabIndex = 3;
            группаLabel.Text = "Группа:";
            // 
            // группаTextBox
            // 
            this.группаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группыBindingSource1, "Группа", true));
            this.группаTextBox.Location = new System.Drawing.Point(98, 70);
            this.группаTextBox.Name = "группаTextBox";
            this.группаTextBox.Size = new System.Drawing.Size(100, 20);
            this.группаTextBox.TabIndex = 4;
            // 
            // id_предметаLabel
            // 
            id_предметаLabel.AutoSize = true;
            id_предметаLabel.Location = new System.Drawing.Point(21, 99);
            id_предметаLabel.Name = "id_предметаLabel";
            id_предметаLabel.Size = new System.Drawing.Size(71, 13);
            id_предметаLabel.TabIndex = 5;
            id_предметаLabel.Text = "Id предмета:";
            // 
            // id_предметаTextBox
            // 
            this.id_предметаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группыBindingSource1, "Id_предмета", true));
            this.id_предметаTextBox.Location = new System.Drawing.Point(98, 96);
            this.id_предметаTextBox.Name = "id_предметаTextBox";
            this.id_предметаTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_предметаTextBox.TabIndex = 6;
            // 
            // оценкаLabel
            // 
            оценкаLabel.AutoSize = true;
            оценкаLabel.Location = new System.Drawing.Point(21, 125);
            оценкаLabel.Name = "оценкаLabel";
            оценкаLabel.Size = new System.Drawing.Size(48, 13);
            оценкаLabel.TabIndex = 7;
            оценкаLabel.Text = "Оценка:";
            // 
            // оценкаTextBox
            // 
            this.оценкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группыBindingSource1, "Оценка", true));
            this.оценкаTextBox.Location = new System.Drawing.Point(98, 122);
            this.оценкаTextBox.Name = "оценкаTextBox";
            this.оценкаTextBox.Size = new System.Drawing.Size(100, 20);
            this.оценкаTextBox.TabIndex = 8;
            // 
            // предметBindingSource1
            // 
            this.предметBindingSource1.DataMember = "Предмет";
            this.предметBindingSource1.DataSource = this.forTimpDataSet2;
            // 
            // предметTableAdapter1
            // 
            this.предметTableAdapter1.ClearBeforeFill = true;
            // 
            // предметDataGridView
            // 
            this.предметDataGridView.AllowUserToAddRows = false;
            this.предметDataGridView.AllowUserToDeleteRows = false;
            this.предметDataGridView.AutoGenerateColumns = false;
            this.предметDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.предметDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.предметDataGridView.DataSource = this.предметBindingSource1;
            this.предметDataGridView.Location = new System.Drawing.Point(350, 44);
            this.предметDataGridView.Name = "предметDataGridView";
            this.предметDataGridView.ReadOnly = true;
            this.предметDataGridView.Size = new System.Drawing.Size(268, 98);
            this.предметDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id_предмета";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id_предмета";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn7.HeaderText = "Название";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.группыBindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.соревнованияBindingNavigatorSaveItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(630, 25);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // соревнованияBindingNavigatorSaveItem
            // 
            this.соревнованияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.соревнованияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("соревнованияBindingNavigatorSaveItem.Image")));
            this.соревнованияBindingNavigatorSaveItem.Name = "соревнованияBindingNavigatorSaveItem";
            this.соревнованияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.соревнованияBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(223, 47);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(108, 91);
            this.button1.TabIndex = 11;
            this.button1.Text = "ОБНОВИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ticher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.предметDataGridView);
            this.Controls.Add(id_группыLabel);
            this.Controls.Add(this.id_группыTextBox);
            this.Controls.Add(группаLabel);
            this.Controls.Add(this.группаTextBox);
            this.Controls.Add(id_предметаLabel);
            this.Controls.Add(this.id_предметаTextBox);
            this.Controls.Add(оценкаLabel);
            this.Controls.Add(this.оценкаTextBox);
            this.Controls.Add(this.пользователиDataGridView);
            this.Name = "Ticher";
            this.Text = "Ticher";
            this.Load += new System.EventHandler(this.Ticher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сГПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forTimpDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ForTimpDataSet forTimpDataSet;
        private System.Windows.Forms.BindingSource группыBindingSource;
        private ForTimpDataSetTableAdapters.ГруппыTableAdapter группыTableAdapter;
        private ForTimpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ForTimpDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private ForTimpDataSetTableAdapters.ПредметTableAdapter предметTableAdapter;
        private System.Windows.Forms.BindingSource предметBindingSource;
        private ForTimpDataSetTableAdapters.СГПTableAdapter сГПTableAdapter;
        private System.Windows.Forms.BindingSource сГПBindingSource;
        private ForTimpDataSet2 forTimpDataSet2;
        private System.Windows.Forms.BindingSource пользователиBindingSource1;
        private ForTimpDataSet2TableAdapters.ПользователиTableAdapter пользователиTableAdapter1;
        private ForTimpDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private ForTimpDataSet2TableAdapters.ГруппыTableAdapter группыTableAdapter1;
        private System.Windows.Forms.DataGridView пользователиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource группыBindingSource1;
        private ForTimpDataSet2TableAdapters.ПредметTableAdapter предметTableAdapter1;
        private System.Windows.Forms.TextBox id_группыTextBox;
        private System.Windows.Forms.TextBox группаTextBox;
        private System.Windows.Forms.TextBox id_предметаTextBox;
        private System.Windows.Forms.TextBox оценкаTextBox;
        private System.Windows.Forms.BindingSource предметBindingSource1;
        private System.Windows.Forms.DataGridView предметDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton соревнованияBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
    }
}