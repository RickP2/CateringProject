namespace Catering_Project_Update
{
    partial class Form8
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
            System.Windows.Forms.Label item_NameLabel;
            System.Windows.Forms.Label item_TypeLabel;
            System.Windows.Forms.Label item_PriceLabel;
            System.Windows.Forms.Label order_IDLabel;
            System.Windows.Forms.Label customer_IDLabel;
            System.Windows.Forms.Label item_NameLabel1;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label order_PriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnSide = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.Item_Qty = new System.Windows.Forms.NumericUpDown();
            this.lblQty = new System.Windows.Forms.Label();
            this.food_orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.food_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Catering_Project_Update.Database1DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.food_orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.food_orderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Item_Name = new System.Windows.Forms.Label();
            this.Item_Type = new System.Windows.Forms.Label();
            this.Item_Price = new System.Windows.Forms.Label();
            this.Item_Notes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.order_IDLabel1 = new System.Windows.Forms.Label();
            this.Customer_ID = new System.Windows.Forms.TextBox();
            this.Order_Item_Name = new System.Windows.Forms.TextBox();
            this.Order_Item_Qty = new System.Windows.Forms.TextBox();
            this.Order_Item_Price = new System.Windows.Forms.TextBox();
            this.food_orderTableAdapter = new Catering_Project_Update.Database1DataSetTableAdapters.food_orderTableAdapter();
            this.tableAdapterManager = new Catering_Project_Update.Database1DataSetTableAdapters.TableAdapterManager();
            this.menuTableAdapter = new Catering_Project_Update.Database1DataSetTableAdapters.menuTableAdapter();
            item_NameLabel = new System.Windows.Forms.Label();
            item_TypeLabel = new System.Windows.Forms.Label();
            item_PriceLabel = new System.Windows.Forms.Label();
            order_IDLabel = new System.Windows.Forms.Label();
            customer_IDLabel = new System.Windows.Forms.Label();
            item_NameLabel1 = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            order_PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Item_Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_orderBindingNavigator)).BeginInit();
            this.food_orderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.food_orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // item_NameLabel
            // 
            item_NameLabel.AutoSize = true;
            item_NameLabel.Location = new System.Drawing.Point(573, 258);
            item_NameLabel.Name = "item_NameLabel";
            item_NameLabel.Size = new System.Drawing.Size(107, 24);
            item_NameLabel.TabIndex = 77;
            item_NameLabel.Text = "Item Name:";
            // 
            // item_TypeLabel
            // 
            item_TypeLabel.AutoSize = true;
            item_TypeLabel.Location = new System.Drawing.Point(573, 282);
            item_TypeLabel.Name = "item_TypeLabel";
            item_TypeLabel.Size = new System.Drawing.Size(97, 24);
            item_TypeLabel.TabIndex = 79;
            item_TypeLabel.Text = "Item Type:";
            // 
            // item_PriceLabel
            // 
            item_PriceLabel.AutoSize = true;
            item_PriceLabel.Location = new System.Drawing.Point(573, 306);
            item_PriceLabel.Name = "item_PriceLabel";
            item_PriceLabel.Size = new System.Drawing.Size(98, 24);
            item_PriceLabel.TabIndex = 81;
            item_PriceLabel.Text = "Item Price:";
            // 
            // order_IDLabel
            // 
            order_IDLabel.AutoSize = true;
            order_IDLabel.Location = new System.Drawing.Point(12, 484);
            order_IDLabel.Name = "order_IDLabel";
            order_IDLabel.Size = new System.Drawing.Size(83, 24);
            order_IDLabel.TabIndex = 85;
            order_IDLabel.Text = "order ID:";
            order_IDLabel.Visible = false;
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Location = new System.Drawing.Point(12, 514);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(118, 24);
            customer_IDLabel.TabIndex = 87;
            customer_IDLabel.Text = "Customer ID:";
            customer_IDLabel.Visible = false;
            // 
            // item_NameLabel1
            // 
            item_NameLabel1.AutoSize = true;
            item_NameLabel1.Location = new System.Drawing.Point(12, 552);
            item_NameLabel1.Name = "item_NameLabel1";
            item_NameLabel1.Size = new System.Drawing.Size(107, 24);
            item_NameLabel1.TabIndex = 89;
            item_NameLabel1.Text = "Item Name:";
            item_NameLabel1.Visible = false;
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(12, 590);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(44, 24);
            qtyLabel.TabIndex = 91;
            qtyLabel.Text = "Qty:";
            qtyLabel.Visible = false;
            // 
            // order_PriceLabel
            // 
            order_PriceLabel.AutoSize = true;
            order_PriceLabel.Location = new System.Drawing.Point(12, 628);
            order_PriceLabel.Name = "order_PriceLabel";
            order_PriceLabel.Size = new System.Drawing.Size(108, 24);
            order_PriceLabel.TabIndex = 93;
            order_PriceLabel.Text = "Order Price:";
            order_PriceLabel.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMenu.Location = new System.Drawing.Point(869, 30);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(141, 38);
            this.btnMenu.TabIndex = 47;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(869, 74);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 38);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDessert.Location = new System.Drawing.Point(861, 555);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(141, 38);
            this.btnDessert.TabIndex = 64;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.UseVisualStyleBackColor = true;
            this.btnDessert.Visible = false;
            // 
            // btnSide
            // 
            this.btnSide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSide.Location = new System.Drawing.Point(861, 599);
            this.btnSide.Name = "btnSide";
            this.btnSide.Size = new System.Drawing.Size(141, 38);
            this.btnSide.TabIndex = 65;
            this.btnSide.Text = "Side";
            this.btnSide.UseVisualStyleBackColor = true;
            this.btnSide.Visible = false;
            // 
            // btnMain
            // 
            this.btnMain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMain.Location = new System.Drawing.Point(861, 511);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(141, 38);
            this.btnMain.TabIndex = 66;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Visible = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(577, 484);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 38);
            this.button4.TabIndex = 67;
            this.button4.Text = "Add to Order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowAll.Location = new System.Drawing.Point(861, 643);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(141, 38);
            this.btnShowAll.TabIndex = 68;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Visible = false;
            // 
            // Item_Qty
            // 
            this.Item_Qty.Location = new System.Drawing.Point(621, 333);
            this.Item_Qty.Name = "Item_Qty";
            this.Item_Qty.Size = new System.Drawing.Size(120, 32);
            this.Item_Qty.TabIndex = 75;
            this.Item_Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(571, 336);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(44, 24);
            this.lblQty.TabIndex = 76;
            this.lblQty.Text = "Qty:";
            // 
            // food_orderBindingNavigator
            // 
            this.food_orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.food_orderBindingNavigator.BindingSource = this.food_orderBindingSource;
            this.food_orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.food_orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.food_orderBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.food_orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.food_orderBindingNavigatorSaveItem});
            this.food_orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.food_orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.food_orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.food_orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.food_orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.food_orderBindingNavigator.Name = "food_orderBindingNavigator";
            this.food_orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.food_orderBindingNavigator.Size = new System.Drawing.Size(1030, 27);
            this.food_orderBindingNavigator.TabIndex = 77;
            this.food_orderBindingNavigator.Text = "bindingNavigator1";
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
            // food_orderBindingSource
            // 
            this.food_orderBindingSource.DataMember = "food_order";
            this.food_orderBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // food_orderBindingNavigatorSaveItem
            // 
            this.food_orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.food_orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("food_orderBindingNavigatorSaveItem.Image")));
            this.food_orderBindingNavigatorSaveItem.Name = "food_orderBindingNavigatorSaveItem";
            this.food_orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.food_orderBindingNavigatorSaveItem.Text = "Save Data";
            this.food_orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.food_orderBindingNavigatorSaveItem_Click);
            // 
            // food_orderDataGridView
            // 
            this.food_orderDataGridView.AutoGenerateColumns = false;
            this.food_orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.food_orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.food_orderDataGridView.DataSource = this.food_orderBindingSource;
            this.food_orderDataGridView.Location = new System.Drawing.Point(12, 32);
            this.food_orderDataGridView.Name = "food_orderDataGridView";
            this.food_orderDataGridView.RowHeadersWidth = 51;
            this.food_orderDataGridView.RowTemplate.Height = 24;
            this.food_orderDataGridView.Size = new System.Drawing.Size(677, 220);
            this.food_orderDataGridView.TabIndex = 77;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "order_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "order_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Item_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Item_Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn5.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Order_Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Order_Price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn7.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // menuDataGridView
            // 
            this.menuDataGridView.AutoGenerateColumns = false;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.menuDataGridView.DataSource = this.menuBindingSource;
            this.menuDataGridView.Location = new System.Drawing.Point(12, 258);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.RowHeadersWidth = 51;
            this.menuDataGridView.RowTemplate.Height = 24;
            this.menuDataGridView.Size = new System.Drawing.Size(553, 220);
            this.menuDataGridView.TabIndex = 77;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "menuID";
            this.dataGridViewTextBoxColumn8.HeaderText = "menuID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Item Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Item Type";
            this.dataGridViewTextBoxColumn10.HeaderText = "Item Type";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Item Price";
            this.dataGridViewTextBoxColumn11.HeaderText = "Item Price";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn12.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "menu";
            this.menuBindingSource.DataSource = this.database1DataSet;
            // 
            // Item_Name
            // 
            this.Item_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "Item Name", true));
            this.Item_Name.Location = new System.Drawing.Point(686, 258);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(100, 23);
            this.Item_Name.TabIndex = 78;
            this.Item_Name.Text = "label1";
            // 
            // Item_Type
            // 
            this.Item_Type.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "Item Type", true));
            this.Item_Type.Location = new System.Drawing.Point(686, 282);
            this.Item_Type.Name = "Item_Type";
            this.Item_Type.Size = new System.Drawing.Size(100, 23);
            this.Item_Type.TabIndex = 80;
            this.Item_Type.Text = "label1";
            // 
            // Item_Price
            // 
            this.Item_Price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "Item Price", true));
            this.Item_Price.Location = new System.Drawing.Point(686, 306);
            this.Item_Price.Name = "Item_Price";
            this.Item_Price.Size = new System.Drawing.Size(100, 23);
            this.Item_Price.TabIndex = 82;
            this.Item_Price.Text = "0";
            // 
            // Item_Notes
            // 
            this.Item_Notes.Location = new System.Drawing.Point(643, 375);
            this.Item_Notes.Multiline = true;
            this.Item_Notes.Name = "Item_Notes";
            this.Item_Notes.Size = new System.Drawing.Size(219, 103);
            this.Item_Notes.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 84;
            this.label1.Text = "Notes:";
            // 
            // btnNext
            // 
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNext.Location = new System.Drawing.Point(869, 118);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(141, 38);
            this.btnNext.TabIndex = 85;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // order_IDLabel1
            // 
            this.order_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_orderBindingSource, "order_ID", true));
            this.order_IDLabel1.Location = new System.Drawing.Point(136, 484);
            this.order_IDLabel1.Name = "order_IDLabel1";
            this.order_IDLabel1.Size = new System.Drawing.Size(100, 23);
            this.order_IDLabel1.TabIndex = 86;
            this.order_IDLabel1.Text = "label2";
            this.order_IDLabel1.Visible = false;
            // 
            // Customer_ID
            // 
            this.Customer_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_orderBindingSource, "Customer_ID", true));
            this.Customer_ID.Location = new System.Drawing.Point(136, 511);
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.Size = new System.Drawing.Size(215, 32);
            this.Customer_ID.TabIndex = 88;
            this.Customer_ID.Visible = false;
            // 
            // Order_Item_Name
            // 
            this.Order_Item_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_orderBindingSource, "Item_Name", true));
            this.Order_Item_Name.Location = new System.Drawing.Point(136, 549);
            this.Order_Item_Name.Name = "Order_Item_Name";
            this.Order_Item_Name.Size = new System.Drawing.Size(215, 32);
            this.Order_Item_Name.TabIndex = 90;
            this.Order_Item_Name.Visible = false;
            // 
            // Order_Item_Qty
            // 
            this.Order_Item_Qty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_orderBindingSource, "Qty", true));
            this.Order_Item_Qty.Location = new System.Drawing.Point(136, 587);
            this.Order_Item_Qty.Name = "Order_Item_Qty";
            this.Order_Item_Qty.Size = new System.Drawing.Size(215, 32);
            this.Order_Item_Qty.TabIndex = 92;
            this.Order_Item_Qty.Visible = false;
            // 
            // Order_Item_Price
            // 
            this.Order_Item_Price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_orderBindingSource, "Order_Price", true));
            this.Order_Item_Price.Location = new System.Drawing.Point(136, 625);
            this.Order_Item_Price.Name = "Order_Item_Price";
            this.Order_Item_Price.Size = new System.Drawing.Size(215, 32);
            this.Order_Item_Price.TabIndex = 94;
            this.Order_Item_Price.Visible = false;
            // 
            // food_orderTableAdapter
            // 
            this.food_orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.food_orderTableAdapter = this.food_orderTableAdapter;
            this.tableAdapterManager.menuTableAdapter = this.menuTableAdapter;
            this.tableAdapterManager.orders1TableAdapter = null;
            this.tableAdapterManager.orders2TableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Catering_Project_Update.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 772);
            this.Controls.Add(order_IDLabel);
            this.Controls.Add(this.order_IDLabel1);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.Customer_ID);
            this.Controls.Add(item_NameLabel1);
            this.Controls.Add(this.Order_Item_Name);
            this.Controls.Add(qtyLabel);
            this.Controls.Add(this.Order_Item_Qty);
            this.Controls.Add(order_PriceLabel);
            this.Controls.Add(this.Order_Item_Price);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Item_Notes);
            this.Controls.Add(item_NameLabel);
            this.Controls.Add(this.Item_Name);
            this.Controls.Add(item_TypeLabel);
            this.Controls.Add(this.Item_Type);
            this.Controls.Add(item_PriceLabel);
            this.Controls.Add(this.Item_Price);
            this.Controls.Add(this.menuDataGridView);
            this.Controls.Add(this.food_orderDataGridView);
            this.Controls.Add(this.food_orderBindingNavigator);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.Item_Qty);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnSide);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMenu);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form8";
            this.Text = "Add Items";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Item_Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_orderBindingNavigator)).EndInit();
            this.food_orderBindingNavigator.ResumeLayout(false);
            this.food_orderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.food_orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnSide;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.NumericUpDown Item_Qty;
        private System.Windows.Forms.Label lblQty;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource food_orderBindingSource;
        private Database1DataSetTableAdapters.food_orderTableAdapter food_orderTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator food_orderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton food_orderBindingNavigatorSaveItem;
        private Database1DataSetTableAdapters.menuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridView food_orderDataGridView;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private System.Windows.Forms.DataGridView menuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label Item_Name;
        private System.Windows.Forms.Label Item_Type;
        private System.Windows.Forms.Label Item_Price;
        private System.Windows.Forms.TextBox Item_Notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label order_IDLabel1;
        private System.Windows.Forms.TextBox Customer_ID;
        private System.Windows.Forms.TextBox Order_Item_Name;
        private System.Windows.Forms.TextBox Order_Item_Qty;
        private System.Windows.Forms.TextBox Order_Item_Price;
    }
}