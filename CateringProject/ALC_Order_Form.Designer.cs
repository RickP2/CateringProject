namespace CateringProject
{
    partial class ALC_Order_Form
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
            System.Windows.Forms.Label lblItemName;
            System.Windows.Forms.Label lblItemType;
            System.Windows.Forms.Label lblItemPrice;
            System.Windows.Forms.Label lblItemNotes;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label street_AddressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipcodeLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label order_DateLabel;
            System.Windows.Forms.Label pick_Up_DateLabel;
            System.Windows.Forms.Label paidLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label aLaCarteMenuIDLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label aLCOrderIDLabel;
            System.Windows.Forms.Label orderIDLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ALC_Order_Form));
            this.btnExit = new System.Windows.Forms.Button();
            this.lstMenuItems = new System.Windows.Forms.ListBox();
            this.aLCMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderManagementDataSet = new CateringProject.OrderManagementDataSet();
            this.orderedItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderedItemsTableAdapter = new CateringProject.OrderManagementDataSetTableAdapters.OrderedItemsTableAdapter();
            this.aLCMenuTableAdapter = new CateringProject.OrderManagementDataSetTableAdapters.ALCMenuTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numAdd = new System.Windows.Forms.NumericUpDown();
            this.lblOrderInstruction = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new CateringProject.OrderManagementDataSetTableAdapters.TableAdapterManager();
            this.aLCOrderDetailsTableAdapter = new CateringProject.OrderManagementDataSetTableAdapters.ALCOrderDetailsTableAdapter();
            this.customerTableTableAdapter = new CateringProject.OrderManagementDataSetTableAdapters.CustomerTableTableAdapter();
            this.lblSelectedItemName = new System.Windows.Forms.Label();
            this.lblSelectedItemType = new System.Windows.Forms.Label();
            this.lblSelectedItemPrice = new System.Windows.Forms.Label();
            this.lblSelectedItemNotes = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.numRemove = new System.Windows.Forms.NumericUpDown();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDepositRequired = new System.Windows.Forms.Label();
            this.customerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.street_AddressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipcodeTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.aLCOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pick_Up_DateMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.paidCheckBox = new System.Windows.Forms.CheckBox();
            this.cmbCustomer = new System.Windows.Forms.Label();
            this.lblSelectedItemID = new System.Windows.Forms.Label();
            this.orderedItems1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderedItems1TableAdapter = new CateringProject.OrderManagementDataSetTableAdapters.OrderedItems1TableAdapter();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblOrderID1 = new System.Windows.Forms.Label();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
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
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            lblItemName = new System.Windows.Forms.Label();
            lblItemType = new System.Windows.Forms.Label();
            lblItemPrice = new System.Windows.Forms.Label();
            lblItemNotes = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            street_AddressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipcodeLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            order_DateLabel = new System.Windows.Forms.Label();
            pick_Up_DateLabel = new System.Windows.Forms.Label();
            paidLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            aLaCarteMenuIDLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            aLCOrderIDLabel = new System.Windows.Forms.Label();
            orderIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aLCMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLCOrderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedItems1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new System.Drawing.Point(466, 775);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new System.Drawing.Size(107, 24);
            lblItemName.TabIndex = 22;
            lblItemName.Text = "Item Name:";
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = true;
            lblItemType.Location = new System.Drawing.Point(466, 799);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new System.Drawing.Size(97, 24);
            lblItemType.TabIndex = 24;
            lblItemType.Text = "Item Type:";
            // 
            // lblItemPrice
            // 
            lblItemPrice.AutoSize = true;
            lblItemPrice.Location = new System.Drawing.Point(466, 823);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new System.Drawing.Size(98, 24);
            lblItemPrice.TabIndex = 26;
            lblItemPrice.Text = "Item Price:";
            // 
            // lblItemNotes
            // 
            lblItemNotes.AutoSize = true;
            lblItemNotes.Location = new System.Drawing.Point(466, 847);
            lblItemNotes.Name = "lblItemNotes";
            lblItemNotes.Size = new System.Drawing.Size(64, 24);
            lblItemNotes.TabIndex = 28;
            lblItemNotes.Text = "Notes:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(23, 361);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(64, 24);
            nameLabel.TabIndex = 39;
            nameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(23, 399);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(68, 24);
            phoneLabel.TabIndex = 41;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(23, 437);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(61, 24);
            emailLabel.TabIndex = 43;
            emailLabel.Text = "Email:";
            // 
            // street_AddressLabel
            // 
            street_AddressLabel.AutoSize = true;
            street_AddressLabel.Location = new System.Drawing.Point(23, 475);
            street_AddressLabel.Name = "street_AddressLabel";
            street_AddressLabel.Size = new System.Drawing.Size(137, 24);
            street_AddressLabel.TabIndex = 45;
            street_AddressLabel.Text = "Street Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(23, 513);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(47, 24);
            cityLabel.TabIndex = 47;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(23, 551);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(58, 24);
            stateLabel.TabIndex = 49;
            stateLabel.Text = "State:";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Location = new System.Drawing.Point(243, 551);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new System.Drawing.Size(80, 24);
            zipcodeLabel.TabIndex = 51;
            zipcodeLabel.Text = "Zipcode:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(23, 593);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(64, 24);
            notesLabel.TabIndex = 53;
            notesLabel.Text = "Notes:";
            // 
            // order_DateLabel
            // 
            order_DateLabel.AutoSize = true;
            order_DateLabel.Location = new System.Drawing.Point(504, 404);
            order_DateLabel.Name = "order_DateLabel";
            order_DateLabel.Size = new System.Drawing.Size(107, 24);
            order_DateLabel.TabIndex = 54;
            order_DateLabel.Text = "Order Date:";
            // 
            // pick_Up_DateLabel
            // 
            pick_Up_DateLabel.AutoSize = true;
            pick_Up_DateLabel.Location = new System.Drawing.Point(504, 489);
            pick_Up_DateLabel.Name = "pick_Up_DateLabel";
            pick_Up_DateLabel.Size = new System.Drawing.Size(120, 24);
            pick_Up_DateLabel.TabIndex = 56;
            pick_Up_DateLabel.Text = "Pick Up Date:";
            // 
            // paidLabel
            // 
            paidLabel.AutoSize = true;
            paidLabel.Location = new System.Drawing.Point(503, 361);
            paidLabel.Name = "paidLabel";
            paidLabel.Size = new System.Drawing.Size(51, 24);
            paidLabel.TabIndex = 58;
            paidLabel.Text = "Paid:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(910, 498);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(115, 24);
            customerIDLabel.TabIndex = 59;
            customerIDLabel.Text = "customer ID:";
            customerIDLabel.Visible = false;
            // 
            // aLaCarteMenuIDLabel
            // 
            aLaCarteMenuIDLabel.AutoSize = true;
            aLaCarteMenuIDLabel.Location = new System.Drawing.Point(910, 546);
            aLaCarteMenuIDLabel.Name = "aLaCarteMenuIDLabel";
            aLaCarteMenuIDLabel.Size = new System.Drawing.Size(174, 24);
            aLaCarteMenuIDLabel.TabIndex = 61;
            aLaCarteMenuIDLabel.Text = "a La Carte Menu ID:";
            aLaCarteMenuIDLabel.Visible = false;
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(910, 570);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(83, 24);
            orderIDLabel.TabIndex = 62;
            orderIDLabel.Text = "order ID:";
            orderIDLabel.Visible = false;
            // 
            // aLCOrderIDLabel
            // 
            aLCOrderIDLabel.AutoSize = true;
            aLCOrderIDLabel.Location = new System.Drawing.Point(910, 522);
            aLCOrderIDLabel.Name = "aLCOrderIDLabel";
            aLCOrderIDLabel.Size = new System.Drawing.Size(116, 24);
            aLCOrderIDLabel.TabIndex = 60;
            aLCOrderIDLabel.Text = "ALCOrder ID:";
            aLCOrderIDLabel.Visible = false;
            // 
            // orderIDLabel1
            // 
            orderIDLabel1.AutoSize = true;
            orderIDLabel1.Location = new System.Drawing.Point(957, 617);
            orderIDLabel1.Name = "orderIDLabel1";
            orderIDLabel1.Size = new System.Drawing.Size(83, 24);
            orderIDLabel1.TabIndex = 63;
            orderIDLabel1.Text = "order ID:";
            orderIDLabel1.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(1018, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 38);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstMenuItems
            // 
            this.lstMenuItems.DataSource = this.aLCMenuBindingSource;
            this.lstMenuItems.DisplayMember = "Item_Name";
            this.lstMenuItems.FormattingEnabled = true;
            this.lstMenuItems.ItemHeight = 24;
            this.lstMenuItems.Location = new System.Drawing.Point(170, 775);
            this.lstMenuItems.Name = "lstMenuItems";
            this.lstMenuItems.Size = new System.Drawing.Size(276, 316);
            this.lstMenuItems.TabIndex = 14;
            // 
            // aLCMenuBindingSource
            // 
            this.aLCMenuBindingSource.DataMember = "ALCMenu";
            this.aLCMenuBindingSource.DataSource = this.orderManagementDataSet;
            // 
            // orderManagementDataSet
            // 
            this.orderManagementDataSet.DataSetName = "OrderManagementDataSet";
            this.orderManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderedItemsBindingSource
            // 
            this.orderedItemsBindingSource.DataMember = "OrderedItems";
            this.orderedItemsBindingSource.DataSource = this.orderManagementDataSet;
            // 
            // OrderedItemsTableAdapter
            // 
            this.OrderedItemsTableAdapter.ClearBeforeFill = true;
            // 
            // aLCMenuTableAdapter
            // 
            this.aLCMenuTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(470, 934);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 32);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numAdd
            // 
            this.numAdd.Location = new System.Drawing.Point(470, 883);
            this.numAdd.Name = "numAdd";
            this.numAdd.Size = new System.Drawing.Size(83, 32);
            this.numAdd.TabIndex = 18;
            this.numAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOrderInstruction
            // 
            this.lblOrderInstruction.AutoSize = true;
            this.lblOrderInstruction.Location = new System.Drawing.Point(205, 748);
            this.lblOrderInstruction.Name = "lblOrderInstruction";
            this.lblOrderInstruction.Size = new System.Drawing.Size(241, 24);
            this.lblOrderInstruction.TabIndex = 20;
            this.lblOrderInstruction.Text = "Choose menu items to add:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(1018, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 38);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALCMenuTableAdapter = this.aLCMenuTableAdapter;
            this.tableAdapterManager.ALCOrderDetailsTableAdapter = this.aLCOrderDetailsTableAdapter;
            this.tableAdapterManager.ALCOrderSummaryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableTableAdapter = this.customerTableTableAdapter;
            this.tableAdapterManager.OrderedItems1TableAdapter = null;
            this.tableAdapterManager.OrderedItemsTableAdapter = this.OrderedItemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CateringProject.OrderManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aLCOrderDetailsTableAdapter
            // 
            this.aLCOrderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableTableAdapter
            // 
            this.customerTableTableAdapter.ClearBeforeFill = true;
            // 
            // lblSelectedItemName
            // 
            this.lblSelectedItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedItemName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLCMenuBindingSource, "Item_Name", true));
            this.lblSelectedItemName.Location = new System.Drawing.Point(579, 775);
            this.lblSelectedItemName.Name = "lblSelectedItemName";
            this.lblSelectedItemName.Size = new System.Drawing.Size(100, 23);
            this.lblSelectedItemName.TabIndex = 23;
            this.lblSelectedItemName.Text = "label1";
            // 
            // lblSelectedItemType
            // 
            this.lblSelectedItemType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedItemType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLCMenuBindingSource, "Item_Type", true));
            this.lblSelectedItemType.Location = new System.Drawing.Point(579, 799);
            this.lblSelectedItemType.Name = "lblSelectedItemType";
            this.lblSelectedItemType.Size = new System.Drawing.Size(100, 23);
            this.lblSelectedItemType.TabIndex = 25;
            this.lblSelectedItemType.Text = "label1";
            // 
            // lblSelectedItemPrice
            // 
            this.lblSelectedItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedItemPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLCMenuBindingSource, "Item_Price", true));
            this.lblSelectedItemPrice.Location = new System.Drawing.Point(579, 823);
            this.lblSelectedItemPrice.Name = "lblSelectedItemPrice";
            this.lblSelectedItemPrice.Size = new System.Drawing.Size(100, 23);
            this.lblSelectedItemPrice.TabIndex = 27;
            this.lblSelectedItemPrice.Text = "label1";
            this.lblSelectedItemPrice.Click += new System.EventHandler(this.lblItemPrice_Click);
            // 
            // lblSelectedItemNotes
            // 
            this.lblSelectedItemNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedItemNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLCMenuBindingSource, "Notes", true));
            this.lblSelectedItemNotes.Location = new System.Drawing.Point(559, 847);
            this.lblSelectedItemNotes.Name = "lblSelectedItemNotes";
            this.lblSelectedItemNotes.Size = new System.Drawing.Size(224, 68);
            this.lblSelectedItemNotes.TabIndex = 29;
            this.lblSelectedItemNotes.Text = "label1";
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 24;
            this.lstOrder.Location = new System.Drawing.Point(878, 775);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(276, 316);
            this.lstOrder.TabIndex = 30;
            // 
            // numRemove
            // 
            this.numRemove.Location = new System.Drawing.Point(789, 883);
            this.numRemove.Name = "numRemove";
            this.numRemove.Size = new System.Drawing.Size(83, 32);
            this.numRemove.TabIndex = 32;
            this.numRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRemove
            // 
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRemove.Location = new System.Drawing.Point(685, 934);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(187, 32);
            this.btnRemove.TabIndex = 31;
            this.btnRemove.Text = "<< Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(874, 748);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Choose menu items to remove:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(685, 980);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 26);
            this.lblPrice.TabIndex = 34;
            this.lblPrice.Text = "$0.00";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPrice.Location = new System.Drawing.Point(685, 1017);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(57, 26);
            this.lblTotalPrice.TabIndex = 35;
            this.lblTotalPrice.Text = "$0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 980);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Added selection price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 1017);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Total order price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 1054);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Deposit required:";
            // 
            // lblDepositRequired
            // 
            this.lblDepositRequired.AutoSize = true;
            this.lblDepositRequired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDepositRequired.Location = new System.Drawing.Point(685, 1054);
            this.lblDepositRequired.Name = "lblDepositRequired";
            this.lblDepositRequired.Size = new System.Drawing.Size(57, 26);
            this.lblDepositRequired.TabIndex = 39;
            this.lblDepositRequired.Text = "$0.00";
            // 
            // customerTableBindingSource
            // 
            this.customerTableBindingSource.DataMember = "CustomerTable";
            this.customerTableBindingSource.DataSource = this.orderManagementDataSet;
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
            this.customerTableDataGridView.Location = new System.Drawing.Point(12, 22);
            this.customerTableDataGridView.Name = "customerTableDataGridView";
            this.customerTableDataGridView.RowHeadersWidth = 51;
            this.customerTableDataGridView.RowTemplate.Height = 24;
            this.customerTableDataGridView.Size = new System.Drawing.Size(1178, 330);
            this.customerTableDataGridView.TabIndex = 39;
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
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(166, 358);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(324, 32);
            this.nameTextBox.TabIndex = 40;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(166, 396);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(157, 32);
            this.phoneTextBox.TabIndex = 42;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(166, 434);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(324, 32);
            this.emailTextBox.TabIndex = 44;
            // 
            // street_AddressTextBox
            // 
            this.street_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Street Address", true));
            this.street_AddressTextBox.Location = new System.Drawing.Point(166, 472);
            this.street_AddressTextBox.Name = "street_AddressTextBox";
            this.street_AddressTextBox.Size = new System.Drawing.Size(324, 32);
            this.street_AddressTextBox.TabIndex = 46;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(166, 510);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(324, 32);
            this.cityTextBox.TabIndex = 48;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(166, 548);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(52, 32);
            this.stateTextBox.TabIndex = 50;
            this.stateTextBox.Text = "NC";
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Zipcode", true));
            this.zipcodeTextBox.Location = new System.Drawing.Point(329, 548);
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(161, 32);
            this.zipcodeTextBox.TabIndex = 52;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(166, 590);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(324, 146);
            this.notesTextBox.TabIndex = 54;
            // 
            // aLCOrderDetailsBindingSource
            // 
            this.aLCOrderDetailsBindingSource.DataMember = "ALCOrderDetails";
            this.aLCOrderDetailsBindingSource.DataSource = this.orderManagementDataSet;
            // 
            // order_DateDateTimePicker
            // 
            this.order_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aLCOrderDetailsBindingSource, "Order_Date", true));
            this.order_DateDateTimePicker.Location = new System.Drawing.Point(636, 400);
            this.order_DateDateTimePicker.Name = "order_DateDateTimePicker";
            this.order_DateDateTimePicker.Size = new System.Drawing.Size(313, 32);
            this.order_DateDateTimePicker.TabIndex = 55;
            // 
            // pick_Up_DateMonthCalendar
            // 
            this.pick_Up_DateMonthCalendar.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.aLCOrderDetailsBindingSource, "Pick_Up_Date", true));
            this.pick_Up_DateMonthCalendar.Location = new System.Drawing.Point(636, 489);
            this.pick_Up_DateMonthCalendar.Name = "pick_Up_DateMonthCalendar";
            this.pick_Up_DateMonthCalendar.TabIndex = 57;
            // 
            // paidCheckBox
            // 
            this.paidCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.aLCOrderDetailsBindingSource, "Paid", true));
            this.paidCheckBox.Location = new System.Drawing.Point(560, 362);
            this.paidCheckBox.Name = "paidCheckBox";
            this.paidCheckBox.Size = new System.Drawing.Size(200, 24);
            this.paidCheckBox.TabIndex = 59;
            this.paidCheckBox.Text = "Yes";
            this.paidCheckBox.UseVisualStyleBackColor = true;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "customerID", true));
            this.cmbCustomer.Location = new System.Drawing.Point(1031, 498);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(100, 23);
            this.cmbCustomer.TabIndex = 60;
            this.cmbCustomer.Text = "label5";
            this.cmbCustomer.Visible = false;
            // 
            // lblSelectedItemID
            // 
            this.lblSelectedItemID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLCMenuBindingSource, "aLaCarteMenuID", true));
            this.lblSelectedItemID.Location = new System.Drawing.Point(1090, 546);
            this.lblSelectedItemID.Name = "lblSelectedItemID";
            this.lblSelectedItemID.Size = new System.Drawing.Size(100, 23);
            this.lblSelectedItemID.TabIndex = 62;
            this.lblSelectedItemID.Text = "label5";
            this.lblSelectedItemID.Visible = false;
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
            // lblOrderID
            // 
            this.lblOrderID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderedItems1BindingSource, "orderID", true));
            this.lblOrderID.Location = new System.Drawing.Point(999, 570);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(100, 23);
            this.lblOrderID.TabIndex = 63;
            this.lblOrderID.Text = "label5";
            this.lblOrderID.Visible = false;
            // 
            // lblOrderID1
            // 
            this.lblOrderID1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLCOrderDetailsBindingSource, "ALCOrderID", true));
            this.lblOrderID1.Location = new System.Drawing.Point(1031, 521);
            this.lblOrderID1.Name = "lblOrderID1";
            this.lblOrderID1.Size = new System.Drawing.Size(100, 23);
            this.lblOrderID1.TabIndex = 61;
            this.lblOrderID1.Text = "label5";
            this.lblOrderID1.Visible = false;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderedItemsBindingSource, "orderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(1046, 614);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(100, 32);
            this.orderIDTextBox.TabIndex = 64;
            this.orderIDTextBox.Visible = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.customerTableBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.toolStripSeparator1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1511, 27);
            this.bindingNavigator1.TabIndex = 65;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // ALC_Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1511, 1224);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(orderIDLabel1);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(aLaCarteMenuIDLabel);
            this.Controls.Add(this.lblSelectedItemID);
            this.Controls.Add(aLCOrderIDLabel);
            this.Controls.Add(this.lblOrderID1);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(order_DateLabel);
            this.Controls.Add(this.order_DateDateTimePicker);
            this.Controls.Add(pick_Up_DateLabel);
            this.Controls.Add(this.pick_Up_DateMonthCalendar);
            this.Controls.Add(paidLabel);
            this.Controls.Add(this.paidCheckBox);
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
            this.Controls.Add(this.lblDepositRequired);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRemove);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(lblItemName);
            this.Controls.Add(this.lblSelectedItemName);
            this.Controls.Add(lblItemType);
            this.Controls.Add(this.lblSelectedItemType);
            this.Controls.Add(lblItemPrice);
            this.Controls.Add(this.lblSelectedItemPrice);
            this.Controls.Add(lblItemNotes);
            this.Controls.Add(this.lblSelectedItemNotes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOrderInstruction);
            this.Controls.Add(this.numAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstMenuItems);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ALC_Order_Form";
            this.Text = "ALC_Order_Form";
            this.Load += new System.EventHandler(this.ALC_Order_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aLCMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLCOrderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedItems1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstMenuItems;
        private OrderManagementDataSet orderManagementDataSet;
        private System.Windows.Forms.BindingSource orderedItemsBindingSource;
        private OrderManagementDataSetTableAdapters.OrderedItemsTableAdapter OrderedItemsTableAdapter;
        private System.Windows.Forms.BindingSource aLCMenuBindingSource;
        private OrderManagementDataSetTableAdapters.ALCMenuTableAdapter aLCMenuTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numAdd;
        private System.Windows.Forms.Label lblOrderInstruction;
        private System.Windows.Forms.Button button1;
        private OrderManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblSelectedItemName;
        private System.Windows.Forms.Label lblSelectedItemType;
        private System.Windows.Forms.Label lblSelectedItemPrice;
        private System.Windows.Forms.Label lblSelectedItemNotes;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.NumericUpDown numRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDepositRequired;
        private OrderManagementDataSetTableAdapters.CustomerTableTableAdapter customerTableTableAdapter;
        private System.Windows.Forms.BindingSource customerTableBindingSource;
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
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox street_AddressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipcodeTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private OrderManagementDataSetTableAdapters.ALCOrderDetailsTableAdapter aLCOrderDetailsTableAdapter;
        private System.Windows.Forms.BindingSource aLCOrderDetailsBindingSource;
        private System.Windows.Forms.DateTimePicker order_DateDateTimePicker;
        private System.Windows.Forms.MonthCalendar pick_Up_DateMonthCalendar;
        private System.Windows.Forms.CheckBox paidCheckBox;
        private System.Windows.Forms.Label cmbCustomer;
        private System.Windows.Forms.Label lblSelectedItemID;
        private System.Windows.Forms.BindingSource orderedItems1BindingSource;
        private OrderManagementDataSetTableAdapters.OrderedItems1TableAdapter orderedItems1TableAdapter;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblOrderID1;
        private System.Windows.Forms.TextBox orderIDTextBox;
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
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}