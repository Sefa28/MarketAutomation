namespace MarketAutomation.Forms
{
    partial class FormGetProductRefund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGetProductRefund));
            this.GetProductData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnListsProducts = new DevExpress.XtraEditors.SimpleButton();
            this.BtnConfirmProductReturn = new DevExpress.XtraEditors.SimpleButton();
            this.TextCustomerName = new System.Windows.Forms.TextBox();
            this.TextShoppingDate = new System.Windows.Forms.DateTimePicker();
            this.TextReasonForReturn = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GetProductData)).BeginInit();
            this.SuspendLayout();
            // 
            // GetProductData
            // 
            this.GetProductData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GetProductData.Location = new System.Drawing.Point(3, 12);
            this.GetProductData.Name = "GetProductData";
            this.GetProductData.RowTemplate.Height = 24;
            this.GetProductData.Size = new System.Drawing.Size(816, 458);
            this.GetProductData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(841, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(841, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shopping Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(841, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Reason for Return";
            // 
            // BtnListsProducts
            // 
            this.BtnListsProducts.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListsProducts.Appearance.Options.UseFont = true;
            this.BtnListsProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListsProducts.ImageOptions.Image")));
            this.BtnListsProducts.Location = new System.Drawing.Point(836, 362);
            this.BtnListsProducts.Name = "BtnListsProducts";
            this.BtnListsProducts.Size = new System.Drawing.Size(268, 80);
            this.BtnListsProducts.TabIndex = 5;
            this.BtnListsProducts.Text = "Lists Products";
            this.BtnListsProducts.Click += new System.EventHandler(this.BtnListsProducts_Click);
            // 
            // BtnConfirmProductReturn
            // 
            this.BtnConfirmProductReturn.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmProductReturn.Appearance.Options.UseFont = true;
            this.BtnConfirmProductReturn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfirmProductReturn.ImageOptions.Image")));
            this.BtnConfirmProductReturn.Location = new System.Drawing.Point(1128, 362);
            this.BtnConfirmProductReturn.Name = "BtnConfirmProductReturn";
            this.BtnConfirmProductReturn.Size = new System.Drawing.Size(300, 80);
            this.BtnConfirmProductReturn.TabIndex = 6;
            this.BtnConfirmProductReturn.Text = "Confirm Product\r\n Return";
            this.BtnConfirmProductReturn.Click += new System.EventHandler(this.BtnConfirmProductReturn_Click);
            // 
            // TextCustomerName
            // 
            this.TextCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCustomerName.Location = new System.Drawing.Point(1128, 33);
            this.TextCustomerName.Name = "TextCustomerName";
            this.TextCustomerName.Size = new System.Drawing.Size(300, 39);
            this.TextCustomerName.TabIndex = 8;
            // 
            // TextShoppingDate
            // 
            this.TextShoppingDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextShoppingDate.Location = new System.Drawing.Point(1128, 85);
            this.TextShoppingDate.Name = "TextShoppingDate";
            this.TextShoppingDate.Size = new System.Drawing.Size(300, 39);
            this.TextShoppingDate.TabIndex = 9;
            // 
            // TextReasonForReturn
            // 
            this.TextReasonForReturn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextReasonForReturn.Location = new System.Drawing.Point(1128, 150);
            this.TextReasonForReturn.Name = "TextReasonForReturn";
            this.TextReasonForReturn.Size = new System.Drawing.Size(300, 96);
            this.TextReasonForReturn.TabIndex = 10;
            this.TextReasonForReturn.Text = "";
            // 
            // FormGetProductRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 473);
            this.Controls.Add(this.TextReasonForReturn);
            this.Controls.Add(this.TextShoppingDate);
            this.Controls.Add(this.TextCustomerName);
            this.Controls.Add(this.BtnConfirmProductReturn);
            this.Controls.Add(this.BtnListsProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetProductData);
            this.Name = "FormGetProductRefund";
            this.Text = "FormGetProductRefund";
            ((System.ComponentModel.ISupportInitialize)(this.GetProductData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GetProductData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton BtnListsProducts;
        private DevExpress.XtraEditors.SimpleButton BtnConfirmProductReturn;
        private System.Windows.Forms.TextBox TextCustomerName;
        private System.Windows.Forms.DateTimePicker TextShoppingDate;
        private System.Windows.Forms.RichTextBox TextReasonForReturn;
    }
}