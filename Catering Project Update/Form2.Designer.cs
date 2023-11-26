namespace Catering_Project_Update
{
    partial class Form2
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
            this.lblMenuEdit = new System.Windows.Forms.Label();
            this.lblOrderInformation = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblCustomerInformation = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnOrderInformation = new System.Windows.Forms.Button();
            this.btnMenuEdit = new System.Windows.Forms.Button();
            this.btnCustomerInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuEdit
            // 
            this.lblMenuEdit.AutoSize = true;
            this.lblMenuEdit.Location = new System.Drawing.Point(375, 400);
            this.lblMenuEdit.Name = "lblMenuEdit";
            this.lblMenuEdit.Size = new System.Drawing.Size(283, 24);
            this.lblMenuEdit.TabIndex = 27;
            this.lblMenuEdit.Text = "Add, edit, or Delete menu items.";
            // 
            // lblOrderInformation
            // 
            this.lblOrderInformation.AutoSize = true;
            this.lblOrderInformation.Location = new System.Drawing.Point(394, 319);
            this.lblOrderInformation.Name = "lblOrderInformation";
            this.lblOrderInformation.Size = new System.Drawing.Size(256, 24);
            this.lblOrderInformation.TabIndex = 26;
            this.lblOrderInformation.Text = "Edit or delete existing orders.";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(318, 249);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(352, 24);
            this.lblOrder.TabIndex = 25;
            this.lblOrder.Text = "Place a new catering or A La Carte order. ";
            // 
            // lblCustomerInformation
            // 
            this.lblCustomerInformation.AutoSize = true;
            this.lblCustomerInformation.Location = new System.Drawing.Point(203, 179);
            this.lblCustomerInformation.Name = "lblCustomerInformation";
            this.lblCustomerInformation.Size = new System.Drawing.Size(505, 24);
            this.lblCustomerInformation.TabIndex = 24;
            this.lblCustomerInformation.Text = "Add new customers or look up and edit existing customers.";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(847, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 38);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(678, 242);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(177, 38);
            this.btnOrder.TabIndex = 22;
            this.btnOrder.Text = "Place An Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnOrderInformation
            // 
            this.btnOrderInformation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrderInformation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderInformation.Location = new System.Drawing.Point(678, 312);
            this.btnOrderInformation.Name = "btnOrderInformation";
            this.btnOrderInformation.Size = new System.Drawing.Size(177, 38);
            this.btnOrderInformation.TabIndex = 21;
            this.btnOrderInformation.Text = "Orders Info";
            this.btnOrderInformation.UseVisualStyleBackColor = true;
            this.btnOrderInformation.Click += new System.EventHandler(this.btnOrderInformation_Click);
            // 
            // btnMenuEdit
            // 
            this.btnMenuEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMenuEdit.Location = new System.Drawing.Point(678, 390);
            this.btnMenuEdit.Name = "btnMenuEdit";
            this.btnMenuEdit.Size = new System.Drawing.Size(177, 38);
            this.btnMenuEdit.TabIndex = 19;
            this.btnMenuEdit.Text = "Edit Menu";
            this.btnMenuEdit.UseVisualStyleBackColor = true;
            this.btnMenuEdit.Click += new System.EventHandler(this.btnMenuEdit_Click);
            // 
            // btnCustomerInformation
            // 
            this.btnCustomerInformation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCustomerInformation.Location = new System.Drawing.Point(678, 169);
            this.btnCustomerInformation.Name = "btnCustomerInformation";
            this.btnCustomerInformation.Size = new System.Drawing.Size(177, 38);
            this.btnCustomerInformation.TabIndex = 18;
            this.btnCustomerInformation.Text = "Customer Info";
            this.btnCustomerInformation.UseVisualStyleBackColor = true;
            this.btnCustomerInformation.Click += new System.EventHandler(this.btnCustomerInformation_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.lblMenuEdit);
            this.Controls.Add(this.lblOrderInformation);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblCustomerInformation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnOrderInformation);
            this.Controls.Add(this.btnMenuEdit);
            this.Controls.Add(this.btnCustomerInformation);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMenuEdit;
        private System.Windows.Forms.Label lblOrderInformation;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblCustomerInformation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnOrderInformation;
        private System.Windows.Forms.Button btnMenuEdit;
        private System.Windows.Forms.Button btnCustomerInformation;
    }
}