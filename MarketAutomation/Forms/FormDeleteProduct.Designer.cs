namespace MarketAutomation.Forms
{
    partial class FormDeleteProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteProduct));
            this.BtnDeleteAllProduct = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDeleteProductSelect = new DevExpress.XtraEditors.SimpleButton();
            this.BtnFindProduct = new DevExpress.XtraEditors.SimpleButton();
            this.NumberofRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteProductData = new System.Windows.Forms.DataGridView();
            this.TextProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteProductData)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDeleteAllProduct
            // 
            this.BtnDeleteAllProduct.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteAllProduct.Appearance.Options.UseFont = true;
            this.BtnDeleteAllProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteAllProduct.ImageOptions.Image")));
            this.BtnDeleteAllProduct.Location = new System.Drawing.Point(1006, 392);
            this.BtnDeleteAllProduct.Name = "BtnDeleteAllProduct";
            this.BtnDeleteAllProduct.Size = new System.Drawing.Size(338, 69);
            this.BtnDeleteAllProduct.TabIndex = 51;
            this.BtnDeleteAllProduct.Text = "Delete All Product";
            this.BtnDeleteAllProduct.Click += new System.EventHandler(this.BtnDeleteAllProduct_Click);
            // 
            // BtnDeleteProductSelect
            // 
            this.BtnDeleteProductSelect.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteProductSelect.Appearance.Options.UseFont = true;
            this.BtnDeleteProductSelect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteProduct.ImageOptions.Image")));
            this.BtnDeleteProductSelect.Location = new System.Drawing.Point(1006, 315);
            this.BtnDeleteProductSelect.Name = "BtnDeleteProductSelect";
            this.BtnDeleteProductSelect.Size = new System.Drawing.Size(338, 71);
            this.BtnDeleteProductSelect.TabIndex = 50;
            this.BtnDeleteProductSelect.Text = "Delete Product(Select)";
            this.BtnDeleteProductSelect.Click += new System.EventHandler(this.BtnDeleteProductSelect_Click);
            // 
            // BtnFindProduct
            // 
            this.BtnFindProduct.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindProduct.Appearance.Options.UseFont = true;
            this.BtnFindProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFindProduct.ImageOptions.Image")));
            this.BtnFindProduct.Location = new System.Drawing.Point(1006, 163);
            this.BtnFindProduct.Name = "BtnFindProduct";
            this.BtnFindProduct.Size = new System.Drawing.Size(338, 69);
            this.BtnFindProduct.TabIndex = 49;
            this.BtnFindProduct.Text = "Find Product";
            this.BtnFindProduct.Click += new System.EventHandler(this.BtnFindProduct_Click);
            // 
            // NumberofRecords
            // 
            this.NumberofRecords.AutoSize = true;
            this.NumberofRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NumberofRecords.Location = new System.Drawing.Point(1133, 69);
            this.NumberofRecords.Name = "NumberofRecords";
            this.NumberofRecords.Size = new System.Drawing.Size(85, 32);
            this.NumberofRecords.TabIndex = 48;
            this.NumberofRecords.Text = "_____";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(846, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 32);
            this.label5.TabIndex = 47;
            this.label5.Text = "Number of Records";
            // 
            // DeleteProductData
            // 
            this.DeleteProductData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteProductData.Location = new System.Drawing.Point(5, 7);
            this.DeleteProductData.Name = "DeleteProductData";
            this.DeleteProductData.RowTemplate.Height = 24;
            this.DeleteProductData.Size = new System.Drawing.Size(816, 458);
            this.DeleteProductData.TabIndex = 44;
            // 
            // TextProductName
            // 
            this.TextProductName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProductName.Location = new System.Drawing.Point(1122, 7);
            this.TextProductName.Name = "TextProductName";
            this.TextProductName.Size = new System.Drawing.Size(300, 39);
            this.TextProductName.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(846, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 59;
            this.label1.Text = "Product Name";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1006, 238);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(338, 71);
            this.simpleButton1.TabIndex = 61;
            this.simpleButton1.Text = "Delete Product";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FormDeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 473);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.TextProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDeleteAllProduct);
            this.Controls.Add(this.BtnDeleteProductSelect);
            this.Controls.Add(this.BtnFindProduct);
            this.Controls.Add(this.NumberofRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteProductData);
            this.Name = "FormDeleteProduct";
            this.Text = "FormDeleteProduct";
            this.Load += new System.EventHandler(this.FormDeleteProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteProductData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnDeleteAllProduct;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteProductSelect;
        private DevExpress.XtraEditors.SimpleButton BtnFindProduct;
        private System.Windows.Forms.Label NumberofRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DeleteProductData;
        private System.Windows.Forms.TextBox TextProductName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}