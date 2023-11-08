namespace CateringProject
{
    partial class Customer_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Information));
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label street_AddressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipcodeLabel;
            System.Windows.Forms.Label notesLabel;
            this.orderManagementDataSet = new CateringProject.OrderManagementDataSet();
            this.customerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableTableAdapter = new CateringProject.OrderManagementDataSetTableAdapters.CustomerTableTableAdapter();
            this.tableAdapterManager = new CateringProject.OrderManagementDataSetTableAdapters.TableAdapterManager();
            this.customerTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customerTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderedItemsTableAdapter = new CateringProject.OrderManagementDataSetTableAdapters.OrderedItemsTableAdapter();
            this.customerIDLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.street_AddressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipcodeTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.orderedItems1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderedItems1TableAdapter = new CateringProject.OrderManagementDataSetTableAdapters.OrderedItems1TableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            customerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            street_AddressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipcodeLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingNavigator)).BeginInit();
            this.customerTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedItems1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderManagementDataSet
            // 
            this.orderManagementDataSet.DataSetName = "OrderManagementDataSet";
            this.orderManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableBindingSource
            // 
            this.customerTableBindingSource.DataMember = "CustomerTable";
            this.customerTableBindingSource.DataSource = this.orderManagementDataSet;
            // 
            // customerTableTableAdapter
            // 
            this.customerTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALCMenuTableAdapter = null;
            this.tableAdapterManager.ALCOrderDetailsTableAdapter = null;
            this.tableAdapterManager.ALCOrderSummaryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableTableAdapter = this.customerTableTableAdapter;
            this.tableAdapterManager.OrderedItems1TableAdapter = this.orderedItems1TableAdapter;
            this.tableAdapterManager.OrderedItemsTableAdapter = this.orderedItemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CateringProject.OrderManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableBindingNavigator
            // 
            this.customerTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerTableBindingNavigator.BindingSource = this.customerTableBindingSource;
            this.customerTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.customerTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customerTableBindingNavigatorSaveItem});
            this.customerTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerTableBindingNavigator.Name = "customerTableBindingNavigator";
            this.customerTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerTableBindingNavigator.Size = new System.Drawing.Size(1313, 27);
            this.customerTableBindingNavigator.TabIndex = 0;
            this.customerTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // customerTableBindingNavigatorSaveItem
            // 
            this.customerTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerTableBindingNavigatorSaveItem.Image")));
            this.customerTableBindingNavigatorSaveItem.Name = "customerTableBindingNavigatorSaveItem";
            this.customerTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.customerTableBindingNavigatorSaveItem.Text = "Save Data";
            this.customerTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerTableBindingNavigatorSaveItem_Click);
            // 
            // customerTableDataGridView
            // 
            this.customerTableDataGridView.AutoGenerateColumns = false;
            this.customerTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.customerTableDataGridView.DataSource = this.customerTableBindingSource;
            this.customerTableDataGridView.Location = new System.Drawing.Point(12, 43);
            this.customerTableDataGridView.Name = "customerTableDataGridView";
            this.customerTableDataGridView.RowHeadersWidth = 51;
            this.customerTableDataGridView.RowTemplate.Height = 24;
            this.customerTableDataGridView.Size = new System.Drawing.Size(1180, 308);
            this.customerTableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "customerID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Street Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Street Address";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn6.HeaderText = "City";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn7.HeaderText = "State";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Zipcode";
            this.dataGridViewTextBoxColumn8.HeaderText = "Zipcode";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn9.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // orderedItemsBindingSource
            // 
            this.orderedItemsBindingSource.DataMember = "FK_customerID";
            this.orderedItemsBindingSource.DataSource = this.customerTableBindingSource;
            // 
            // orderedItemsTableAdapter
            // 
            this.orderedItemsTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(67, 382);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(115, 24);
            customerIDLabel.TabIndex = 3;
            customerIDLabel.Text = "customer ID:";
            // 
            // customerIDLabel1
            // 
            this.customerIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "customerID", true));
            this.customerIDLabel1.Location = new System.Drawing.Point(210, 382);
            this.customerIDLabel1.Name = "customerIDLabel1";
            this.customerIDLabel1.Size = new System.Drawing.Size(324, 23);
            this.customerIDLabel1.TabIndex = 4;
            this.customerIDLabel1.Text = "label1";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(67, 412);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(64, 24);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(210, 409);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(324, 32);
            this.nameTextBox.TabIndex = 6;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(67, 450);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(68, 24);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(210, 447);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(324, 32);
            this.phoneTextBox.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(67, 488);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(61, 24);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(210, 485);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(324, 32);
            this.emailTextBox.TabIndex = 10;
            // 
            // street_AddressLabel
            // 
            street_AddressLabel.AutoSize = true;
            street_AddressLabel.Location = new System.Drawing.Point(67, 526);
            street_AddressLabel.Name = "street_AddressLabel";
            street_AddressLabel.Size = new System.Drawing.Size(137, 24);
            street_AddressLabel.TabIndex = 11;
            street_AddressLabel.Text = "Street Address:";
            // 
            // street_AddressTextBox
            // 
            this.street_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Street Address", true));
            this.street_AddressTextBox.Location = new System.Drawing.Point(210, 523);
            this.street_AddressTextBox.Name = "street_AddressTextBox";
            this.street_AddressTextBox.Size = new System.Drawing.Size(324, 32);
            this.street_AddressTextBox.TabIndex = 12;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(67, 564);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(47, 24);
            cityLabel.TabIndex = 13;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(210, 561);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(324, 32);
            this.cityTextBox.TabIndex = 14;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(67, 602);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(58, 24);
            stateLabel.TabIndex = 15;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(210, 599);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(324, 32);
            this.stateTextBox.TabIndex = 16;
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Location = new System.Drawing.Point(67, 640);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new System.Drawing.Size(80, 24);
            zipcodeLabel.TabIndex = 17;
            zipcodeLabel.Text = "Zipcode:";
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Zipcode", true));
            this.zipcodeTextBox.Location = new System.Drawing.Point(210, 637);
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(324, 32);
            this.zipcodeTextBox.TabIndex = 18;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(67, 678);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(64, 24);
            notesLabel.TabIndex = 19;
            notesLabel.Text = "Notes:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(210, 675);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(324, 32);
            this.notesTextBox.TabIndex = 20;
            // 
            // orderedItems1BindingSource
            // 
            this.orderedItems1BindingSource.DataMember = "OrderedItems1";
            this.orderedItems1BindingSource.DataSource = this.orderManagementDataSet;
            // 
            // orderedItems1TableAdapter
            // 
            this.orderedItems1TableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(1020, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 38);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Customer_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 848);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(street_AddressLabel);
            this.Controls.Add(this.street_AddressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(zipcodeLabel);
            this.Controls.Add(this.zipcodeTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.customerTableDataGridView);
            this.Controls.Add(this.customerTableBindingNavigator);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customer_Information";
            this.Text = "Customer_Information";
            this.Load += new System.EventHandler(this.Customer_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingNavigator)).EndInit();
            this.customerTableBindingNavigator.ResumeLayout(false);
            this.customerTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedItems1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OrderManagementDataSet orderManagementDataSet;
        private System.Windows.Forms.BindingSource customerTableBindingSource;
        private OrderManagementDataSetTableAdapters.CustomerTableTableAdapter customerTableTableAdapter;
        private OrderManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customerTableBindingNavigatorSaveItem;
        private OrderManagementDataSetTableAdapters.OrderedItemsTableAdapter orderedItemsTableAdapter;
        private System.Windows.Forms.DataGridView customerTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource orderedItemsBindingSource;
        private System.Windows.Forms.Label customerIDLabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox street_AddressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipcodeTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private OrderManagementDataSetTableAdapters.OrderedItems1TableAdapter orderedItems1TableAdapter;
        private System.Windows.Forms.BindingSource orderedItems1BindingSource;
        private System.Windows.Forms.Button btnExit;
    }
}