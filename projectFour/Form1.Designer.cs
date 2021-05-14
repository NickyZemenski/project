namespace AssignmentFour
{
    partial class Form1
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
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.lvlInventory = new System.Windows.Forms.Label();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnSaveProducts = new System.Windows.Forms.Button();
            this.rtbProductsDescription = new System.Windows.Forms.RichTextBox();
            this.txtboxProductPrice = new System.Windows.Forms.TextBox();
            this.txtboxProductName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbProcedures = new System.Windows.Forms.GroupBox();
            this.btnDeleteProcedure = new System.Windows.Forms.Button();
            this.txtboxMinutes = new System.Windows.Forms.TextBox();
            this.btnUpdateProcedure = new System.Windows.Forms.Button();
            this.btnSaveProcedure = new System.Windows.Forms.Button();
            this.txtboxProcedureDescription = new System.Windows.Forms.RichTextBox();
            this.txtboxProcedurePrice = new System.Windows.Forms.TextBox();
            this.txtboxProcedureName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.gbProducts.SuspendLayout();
            this.gbProcedures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.ItemHeight = 16;
            this.lstInventory.Location = new System.Drawing.Point(39, 78);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(272, 308);
            this.lstInventory.TabIndex = 0;
            this.lstInventory.SelectedIndexChanged += new System.EventHandler(this.lstInventory_SelectedIndexChanged);
            // 
            // lvlInventory
            // 
            this.lvlInventory.AutoSize = true;
            this.lvlInventory.Location = new System.Drawing.Point(39, 55);
            this.lvlInventory.Name = "lvlInventory";
            this.lvlInventory.Size = new System.Drawing.Size(111, 17);
            this.lvlInventory.TabIndex = 1;
            this.lvlInventory.Text = "Entire Inventory:";
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.btnDeleteProduct);
            this.gbProducts.Controls.Add(this.btnUpdateProduct);
            this.gbProducts.Controls.Add(this.btnSaveProducts);
            this.gbProducts.Controls.Add(this.rtbProductsDescription);
            this.gbProducts.Controls.Add(this.txtboxProductPrice);
            this.gbProducts.Controls.Add(this.txtboxProductName);
            this.gbProducts.Controls.Add(this.lblPrice);
            this.gbProducts.Controls.Add(this.lblDescription);
            this.gbProducts.Controls.Add(this.lblName);
            this.gbProducts.Location = new System.Drawing.Point(372, 55);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(416, 169);
            this.gbProducts.TabIndex = 2;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Products:";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(260, 127);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(90, 36);
            this.btnDeleteProduct.TabIndex = 8;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(148, 127);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(106, 36);
            this.btnUpdateProduct.TabIndex = 7;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnSaveProducts
            // 
            this.btnSaveProducts.Location = new System.Drawing.Point(52, 127);
            this.btnSaveProducts.Name = "btnSaveProducts";
            this.btnSaveProducts.Size = new System.Drawing.Size(90, 36);
            this.btnSaveProducts.TabIndex = 6;
            this.btnSaveProducts.Text = "Save";
            this.btnSaveProducts.UseVisualStyleBackColor = true;
            this.btnSaveProducts.Click += new System.EventHandler(this.btnSaveProducts_Click);
            // 
            // rtbProductsDescription
            // 
            this.rtbProductsDescription.Location = new System.Drawing.Point(104, 47);
            this.rtbProductsDescription.Name = "rtbProductsDescription";
            this.rtbProductsDescription.Size = new System.Drawing.Size(231, 46);
            this.rtbProductsDescription.TabIndex = 5;
            this.rtbProductsDescription.Text = "";
            // 
            // txtboxProductPrice
            // 
            this.txtboxProductPrice.Location = new System.Drawing.Point(104, 99);
            this.txtboxProductPrice.Name = "txtboxProductPrice";
            this.txtboxProductPrice.Size = new System.Drawing.Size(231, 22);
            this.txtboxProductPrice.TabIndex = 4;
            // 
            // txtboxProductName
            // 
            this.txtboxProductName.Location = new System.Drawing.Point(104, 22);
            this.txtboxProductName.Name = "txtboxProductName";
            this.txtboxProductName.Size = new System.Drawing.Size(231, 22);
            this.txtboxProductName.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(49, 104);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 47);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // gbProcedures
            // 
            this.gbProcedures.Controls.Add(this.btnDeleteProcedure);
            this.gbProcedures.Controls.Add(this.txtboxMinutes);
            this.gbProcedures.Controls.Add(this.btnUpdateProcedure);
            this.gbProcedures.Controls.Add(this.btnSaveProcedure);
            this.gbProcedures.Controls.Add(this.txtboxProcedureDescription);
            this.gbProcedures.Controls.Add(this.txtboxProcedurePrice);
            this.gbProcedures.Controls.Add(this.txtboxProcedureName);
            this.gbProcedures.Controls.Add(this.label4);
            this.gbProcedures.Controls.Add(this.label1);
            this.gbProcedures.Controls.Add(this.label2);
            this.gbProcedures.Controls.Add(this.label3);
            this.gbProcedures.Location = new System.Drawing.Point(372, 246);
            this.gbProcedures.Name = "gbProcedures";
            this.gbProcedures.Size = new System.Drawing.Size(416, 192);
            this.gbProcedures.TabIndex = 3;
            this.gbProcedures.TabStop = false;
            this.gbProcedures.Text = "Procedures:";
            // 
            // btnDeleteProcedure
            // 
            this.btnDeleteProcedure.Location = new System.Drawing.Point(274, 156);
            this.btnDeleteProcedure.Name = "btnDeleteProcedure";
            this.btnDeleteProcedure.Size = new System.Drawing.Size(90, 36);
            this.btnDeleteProcedure.TabIndex = 11;
            this.btnDeleteProcedure.Text = "Delete";
            this.btnDeleteProcedure.UseVisualStyleBackColor = true;
            this.btnDeleteProcedure.Click += new System.EventHandler(this.btnDeleteProcedure_Click);
            // 
            // txtboxMinutes
            // 
            this.txtboxMinutes.Location = new System.Drawing.Point(104, 131);
            this.txtboxMinutes.Name = "txtboxMinutes";
            this.txtboxMinutes.Size = new System.Drawing.Size(231, 22);
            this.txtboxMinutes.TabIndex = 10;
            // 
            // btnUpdateProcedure
            // 
            this.btnUpdateProcedure.Location = new System.Drawing.Point(162, 156);
            this.btnUpdateProcedure.Name = "btnUpdateProcedure";
            this.btnUpdateProcedure.Size = new System.Drawing.Size(106, 36);
            this.btnUpdateProcedure.TabIndex = 10;
            this.btnUpdateProcedure.Text = "Update";
            this.btnUpdateProcedure.UseVisualStyleBackColor = true;
            this.btnUpdateProcedure.Click += new System.EventHandler(this.btnUpdateProcedure_Click);
            // 
            // btnSaveProcedure
            // 
            this.btnSaveProcedure.Location = new System.Drawing.Point(66, 156);
            this.btnSaveProcedure.Name = "btnSaveProcedure";
            this.btnSaveProcedure.Size = new System.Drawing.Size(90, 36);
            this.btnSaveProcedure.TabIndex = 9;
            this.btnSaveProcedure.Text = "Save";
            this.btnSaveProcedure.UseVisualStyleBackColor = true;
            this.btnSaveProcedure.Click += new System.EventHandler(this.btnSaveProcedure_Click);
            // 
            // txtboxProcedureDescription
            // 
            this.txtboxProcedureDescription.Location = new System.Drawing.Point(104, 55);
            this.txtboxProcedureDescription.Name = "txtboxProcedureDescription";
            this.txtboxProcedureDescription.Size = new System.Drawing.Size(231, 46);
            this.txtboxProcedureDescription.TabIndex = 9;
            this.txtboxProcedureDescription.Text = "";
            // 
            // txtboxProcedurePrice
            // 
            this.txtboxProcedurePrice.Location = new System.Drawing.Point(104, 107);
            this.txtboxProcedurePrice.Name = "txtboxProcedurePrice";
            this.txtboxProcedurePrice.Size = new System.Drawing.Size(231, 22);
            this.txtboxProcedurePrice.TabIndex = 8;
            // 
            // txtboxProcedureName
            // 
            this.txtboxProcedureName.Location = new System.Drawing.Point(104, 30);
            this.txtboxProcedureName.Name = "txtboxProcedureName";
            this.txtboxProcedureName.Size = new System.Drawing.Size(231, 22);
            this.txtboxProcedureName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Minutes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(39, 392);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gbProcedures);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.lvlInventory);
            this.Controls.Add(this.lstInventory);
            this.Name = "Form1";
            this.Text = "Beauty shop";
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            this.gbProcedures.ResumeLayout(false);
            this.gbProcedures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.Label lvlInventory;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.GroupBox gbProcedures;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxProductPrice;
        private System.Windows.Forms.TextBox txtboxProductName;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnSaveProducts;
        private System.Windows.Forms.RichTextBox rtbProductsDescription;
        private System.Windows.Forms.Button btnDeleteProcedure;
        private System.Windows.Forms.TextBox txtboxMinutes;
        private System.Windows.Forms.Button btnUpdateProcedure;
        private System.Windows.Forms.Button btnSaveProcedure;
        private System.Windows.Forms.RichTextBox txtboxProcedureDescription;
        private System.Windows.Forms.TextBox txtboxProcedurePrice;
        private System.Windows.Forms.TextBox txtboxProcedureName;
        private System.Windows.Forms.Label lblError;
    }
}

