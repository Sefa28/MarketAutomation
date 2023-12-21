namespace MarketAutomation.Forms
{
    partial class FormAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduct));
            this.CmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextProductId = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelNumberofRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnNewAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.TextExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.TextProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductData = new System.Windows.Forms.DataGridView();
            this.textNumberOfPieces = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductData)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbBoxCategory
            // 
            this.CmbBoxCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxCategory.FormattingEnabled = true;
            this.CmbBoxCategory.Location = new System.Drawing.Point(1114, 283);
            this.CmbBoxCategory.Name = "CmbBoxCategory";
            this.CmbBoxCategory.Size = new System.Drawing.Size(300, 40);
            this.CmbBoxCategory.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(838, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 32);
            this.label7.TabIndex = 59;
            this.label7.Text = "Category";
            // 
            // TextProductId
            // 
            this.TextProductId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProductId.Location = new System.Drawing.Point(1114, 23);
            this.TextProductId.Mask = "00000";
            this.TextProductId.Name = "TextProductId";
            this.TextProductId.Size = new System.Drawing.Size(300, 39);
            this.TextProductId.TabIndex = 58;
            this.TextProductId.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(838, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 32);
            this.label6.TabIndex = 57;
            this.label6.Text = "Product Identity";
            // 
            // LabelNumberofRecords
            // 
            this.LabelNumberofRecords.AutoSize = true;
            this.LabelNumberofRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberofRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelNumberofRecords.Location = new System.Drawing.Point(1130, 340);
            this.LabelNumberofRecords.Name = "LabelNumberofRecords";
            this.LabelNumberofRecords.Size = new System.Drawing.Size(85, 32);
            this.LabelNumberofRecords.TabIndex = 56;
            this.LabelNumberofRecords.Text = "_____";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(838, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 32);
            this.label5.TabIndex = 55;
            this.label5.Text = "Number of Records";
            // 
            // BtnNewAddProduct
            // 
            this.BtnNewAddProduct.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewAddProduct.Appearance.Options.UseFont = true;
            this.BtnNewAddProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewAddProduct.ImageOptions.Image")));
            this.BtnNewAddProduct.Location = new System.Drawing.Point(1008, 385);
            this.BtnNewAddProduct.Name = "BtnNewAddProduct";
            this.BtnNewAddProduct.Size = new System.Drawing.Size(325, 80);
            this.BtnNewAddProduct.TabIndex = 52;
            this.BtnNewAddProduct.Text = "New Add Product";
            this.BtnNewAddProduct.Click += new System.EventHandler(this.BtnNewAddProduct_Click);
            // 
            // TextExpirationDate
            // 
            this.TextExpirationDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextExpirationDate.Location = new System.Drawing.Point(1114, 234);
            this.TextExpirationDate.Name = "TextExpirationDate";
            this.TextExpirationDate.Size = new System.Drawing.Size(300, 39);
            this.TextExpirationDate.TabIndex = 50;
            // 
            // TextProductName
            // 
            this.TextProductName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProductName.Location = new System.Drawing.Point(1114, 76);
            this.TextProductName.Name = "TextProductName";
            this.TextProductName.Size = new System.Drawing.Size(300, 39);
            this.TextProductName.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(838, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 32);
            this.label3.TabIndex = 47;
            this.label3.Text = "Expiration Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(838, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Number Of Pieces";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(838, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Product Name";
            // 
            // ProductData
            // 
            this.ProductData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductData.Location = new System.Drawing.Point(9, 7);
            this.ProductData.Name = "ProductData";
            this.ProductData.RowTemplate.Height = 24;
            this.ProductData.Size = new System.Drawing.Size(816, 458);
            this.ProductData.TabIndex = 44;
            // 
            // textNumberOfPieces
            // 
            this.textNumberOfPieces.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumberOfPieces.Location = new System.Drawing.Point(1114, 126);
            this.textNumberOfPieces.Name = "textNumberOfPieces";
            this.textNumberOfPieces.Size = new System.Drawing.Size(300, 39);
            this.textNumberOfPieces.TabIndex = 61;
            // 
            // textPrice
            // 
            this.textPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrice.Location = new System.Drawing.Point(1114, 179);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(300, 39);
            this.textPrice.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(838, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 32);
            this.label4.TabIndex = 62;
            this.label4.Text = "Price";
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 473);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNumberOfPieces);
            this.Controls.Add(this.CmbBoxCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextProductId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelNumberofRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnNewAddProduct);
            this.Controls.Add(this.TextExpirationDate);
            this.Controls.Add(this.TextProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductData);
            this.Name = "FormAddProduct";
            this.Text = "FormAddProduct";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbBoxCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TextProductId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelNumberofRecords;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton BtnNewAddProduct;
        private System.Windows.Forms.DateTimePicker TextExpirationDate;
        private System.Windows.Forms.TextBox TextProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductData;
        private System.Windows.Forms.TextBox textNumberOfPieces;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label4;
    }
}