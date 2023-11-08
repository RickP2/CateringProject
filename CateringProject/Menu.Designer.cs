namespace CateringProject
{
    partial class Menu
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
            this.btnCustomerInformation = new System.Windows.Forms.Button();
            this.btnMenuEdit = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnOrderInformation = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCustomerInformation = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblOrderInformation = new System.Windows.Forms.Label();
            this.lblMenuEdit = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomerInformation
            // 
            this.btnCustomerInformation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCustomerInformation.Location = new System.Drawing.Point(620, 118);
            this.btnCustomerInformation.Name = "btnCustomerInformation";
            this.btnCustomerInformation.Size = new System.Drawing.Size(177, 38);
            this.btnCustomerInformation.TabIndex = 7;
            this.btnCustomerInformation.Text = "Customer Info";
            this.btnCustomerInformation.UseVisualStyleBackColor = true;
            this.btnCustomerInformation.Click += new System.EventHandler(this.btnCustomerInformation_Click);
            // 
            // btnMenuEdit
            // 
            this.btnMenuEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMenuEdit.Location = new System.Drawing.Point(620, 339);
            this.btnMenuEdit.Name = "btnMenuEdit";
            this.btnMenuEdit.Size = new System.Drawing.Size(177, 38);
            this.btnMenuEdit.TabIndex = 8;
            this.btnMenuEdit.Text = "Edit Menu";
            this.btnMenuEdit.UseVisualStyleBackColor = true;
            this.btnMenuEdit.Click += new System.EventHandler(this.btnMenuEdit_Click);
            // 
            // btnReports
            // 
            this.btnReports.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(620, 416);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(177, 38);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnOrderInformation
            // 
            this.btnOrderInformation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrderInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderInformation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderInformation.Location = new System.Drawing.Point(620, 261);
            this.btnOrderInformation.Name = "btnOrderInformation";
            this.btnOrderInformation.Size = new System.Drawing.Size(177, 38);
            this.btnOrderInformation.TabIndex = 10;
            this.btnOrderInformation.Text = "Orders Info";
            this.btnOrderInformation.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrder.Location = new System.Drawing.Point(620, 191);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(177, 38);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Place An Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(847, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 38);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCustomerInformation
            // 
            this.lblCustomerInformation.AutoSize = true;
            this.lblCustomerInformation.Location = new System.Drawing.Point(87, 125);
            this.lblCustomerInformation.Name = "lblCustomerInformation";
            this.lblCustomerInformation.Size = new System.Drawing.Size(505, 24);
            this.lblCustomerInformation.TabIndex = 13;
            this.lblCustomerInformation.Text = "Add new customers or look up and edit existing customers.";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(240, 198);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(352, 24);
            this.lblOrder.TabIndex = 14;
            this.lblOrder.Text = "Place a new catering or A La Carte order. ";
            // 
            // lblOrderInformation
            // 
            this.lblOrderInformation.AutoSize = true;
            this.lblOrderInformation.Location = new System.Drawing.Point(336, 268);
            this.lblOrderInformation.Name = "lblOrderInformation";
            this.lblOrderInformation.Size = new System.Drawing.Size(256, 24);
            this.lblOrderInformation.TabIndex = 15;
            this.lblOrderInformation.Text = "Edit or delete existing orders.";
            // 
            // lblMenuEdit
            // 
            this.lblMenuEdit.AutoSize = true;
            this.lblMenuEdit.Location = new System.Drawing.Point(309, 346);
            this.lblMenuEdit.Name = "lblMenuEdit";
            this.lblMenuEdit.Size = new System.Drawing.Size(283, 24);
            this.lblMenuEdit.TabIndex = 16;
            this.lblMenuEdit.Text = "Add, edit, or Delete menu items.";
            this.lblMenuEdit.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Location = new System.Drawing.Point(128, 423);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(464, 24);
            this.lblReports.TabIndex = 17;
            this.lblReports.Text = "Generate various reports for ordering ingredients, etc.";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.lblMenuEdit);
            this.Controls.Add(this.lblOrderInformation);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblCustomerInformation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnOrderInformation);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnMenuEdit);
            this.Controls.Add(this.btnCustomerInformation);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerInformation;
        private System.Windows.Forms.Button btnMenuEdit;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnOrderInformation;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCustomerInformation;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblOrderInformation;
        private System.Windows.Forms.Label lblMenuEdit;
        private System.Windows.Forms.Label lblReports;
    }
}