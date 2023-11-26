namespace Catering_Project_Update
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label order_IDLabel;
            System.Windows.Forms.Label customer_IDLabel;
            System.Windows.Forms.Label item_NameLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label order_PriceLabel;
            System.Windows.Forms.Label notesLabel;
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.database1DataSet = new Catering_Project_Update.Database1DataSet();
            this.food_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food_orderTableAdapter = new Catering_Project_Update.Database1DataSetTableAdapters.food_orderTableAdapter();
            this.tableAdapterManager = new Catering_Project_Update.Database1DataSetTableAdapters.TableAdapterManager();
            this.food_orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.food_orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.food_orderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_IDLabel1 = new System.Windows.Forms.Label();
            this.customer_IDTextBox = new System.Windows.Forms.TextBox();
            this.item_NameTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.order_PriceTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            order_IDLabel = new System.Windows.Forms.Label();
            customer_IDLabel = new System.Windows.Forms.Label();
            item_NameLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            order_PriceLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_orderBindingNavigator)).BeginInit();
            this.food_orderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.food_orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMenu.Location = new System.Drawing.Point(855, 32);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(141, 38);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(855, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 62);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear Textboxes";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // food_orderBindingSource
            // 
            this.food_orderBindingSource.DataMember = "food_order";
            this.food_orderBindingSource.DataSource = this.database1DataSet;
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
            this.tableAdapterManager.menuTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Catering_Project_Update.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.food_orderBindingNavigator.Size = new System.Drawing.Size(1008, 27);
            this.food_orderBindingNavigator.TabIndex = 34;
            this.food_orderBindingNavigator.Text = "bindingNavigator1";
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
            // food_orderBindingNavigatorSaveItem
            // 
            this.food_orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.food_orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("food_orderBindingNavigatorSaveItem.Image")));
            this.food_orderBindingNavigatorSaveItem.Name = "food_orderBindingNavigatorSaveItem";
            this.food_orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
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
            this.food_orderDataGridView.Size = new System.Drawing.Size(801, 274);
            this.food_orderDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "order_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "order_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // order_IDLabel
            // 
            order_IDLabel.AutoSize = true;
            order_IDLabel.Location = new System.Drawing.Point(12, 345);
            order_IDLabel.Name = "order_IDLabel";
            order_IDLabel.Size = new System.Drawing.Size(83, 24);
            order_IDLabel.TabIndex = 34;
            order_IDLabel.Text = "order ID:";
            // 
            // order_IDLabel1
            // 
            this.order_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_orderBindingSource, "order_ID", true));
            this.order_IDLabel1.Location = new System.Drawing.Point(136, 345);
            this.order_IDLabel1.Name = "order_IDLabel1";
            this.order_IDLabel1.Size = new System.Drawing.Size(100, 23);
            this.order_IDLabel1.TabIndex = 35;
            this.order_IDLabel1.Text = "label1";
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Location = new System.Drawing.Point(12, 375);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(118, 24);
            customer_IDLabel.TabIndex = 36;
            customer_IDLabel.Text = "Customer ID:";
            // 
            // customer_IDTextBox
            // 
            this.customer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_orderBindingSource, "Customer_ID", true));
            this.customer_IDTextBox.Location = new System.Drawing.Point(136, 372);
            this.customer_IDTextBox.Name = "customer_IDTextBox";
            this.customer_IDTextBox.Size = new System.Drawing.Size(189, 32);
            this.customer_IDTextBox.TabIndex = 37;
            // 
            // item_NameLabel
            // 
            item_NameLabel.AutoSize = true;
            item_NameLabel.Location = new System.Drawing.Point(12, 413);
            item_NameLabel.Name = "item_NameLabel";
            item_NameLabel.Size = new System.Drawing.Size(107, 24);
            item_NameLabel.TabIndex = 38;
            item_NameLabel.Text = "Item Name:";
            // 
            // item_NameTextBox
            // 
            this.item_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_orderBindingSource, "Item_Name", true));
            this.item_NameTextBox.Location = new System.Drawing.Point(136, 410);
            this.item_NameTextBox.Name = "item_NameTextBox";
            this.item_NameTextBox.Size = new System.Drawing.Size(189, 32);
            this.item_NameTextBox.TabIndex = 39;
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(12, 451);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(44, 24);
            qtyLabel.TabIndex = 40;
            qtyLabel.Text = "Qty:";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_orderBindingSource, "Qty", true));
            this.qtyTextBox.Location = new System.Drawing.Point(136, 448);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(189, 32);
            this.qtyTextBox.TabIndex = 41;
            // 
            // order_PriceLabel
            // 
            order_PriceLabel.AutoSize = true;
            order_PriceLabel.Location = new System.Drawing.Point(12, 489);
            order_PriceLabel.Name = "order_PriceLabel";
            order_PriceLabel.Size = new System.Drawing.Size(108, 24);
            order_PriceLabel.TabIndex = 42;
            order_PriceLabel.Text = "Order Price:";
            // 
            // order_PriceTextBox
            // 
            this.order_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_orderBindingSource, "Order_Price", true));
            this.order_PriceTextBox.Location = new System.Drawing.Point(136, 486);
            this.order_PriceTextBox.Name = "order_PriceTextBox";
            this.order_PriceTextBox.Size = new System.Drawing.Size(189, 32);
            this.order_PriceTextBox.TabIndex = 43;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(12, 527);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(64, 24);
            notesLabel.TabIndex = 44;
            notesLabel.Text = "Notes:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_orderBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(136, 524);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(189, 147);
            this.notesTextBox.TabIndex = 45;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 725);
            this.Controls.Add(order_IDLabel);
            this.Controls.Add(this.order_IDLabel1);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.customer_IDTextBox);
            this.Controls.Add(item_NameLabel);
            this.Controls.Add(this.item_NameTextBox);
            this.Controls.Add(qtyLabel);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(order_PriceLabel);
            this.Controls.Add(this.order_PriceTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.food_orderDataGridView);
            this.Controls.Add(this.food_orderBindingNavigator);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMenu);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Edit Orders";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_orderBindingNavigator)).EndInit();
            this.food_orderBindingNavigator.ResumeLayout(false);
            this.food_orderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.food_orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnClear;
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
        private System.Windows.Forms.DataGridView food_orderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label order_IDLabel1;
        private System.Windows.Forms.TextBox customer_IDTextBox;
        private System.Windows.Forms.TextBox item_NameTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox order_PriceTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
    }
}