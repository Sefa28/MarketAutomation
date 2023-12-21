namespace MarketAutomation.Forms
{
    partial class FormListSoldProduct
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
            this.SoldProductData = new System.Windows.Forms.DataGridView();
            this.btnSoldProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SoldProductData)).BeginInit();
            this.SuspendLayout();
            // 
            // SoldProductData
            // 
            this.SoldProductData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoldProductData.Location = new System.Drawing.Point(12, 4);
            this.SoldProductData.Name = "SoldProductData";
            this.SoldProductData.RowTemplate.Height = 24;
            this.SoldProductData.Size = new System.Drawing.Size(1052, 457);
            this.SoldProductData.TabIndex = 0;
            // 
            // btnSoldProduct
            // 
            this.btnSoldProduct.Location = new System.Drawing.Point(1124, 123);
            this.btnSoldProduct.Name = "btnSoldProduct";
            this.btnSoldProduct.Size = new System.Drawing.Size(272, 188);
            this.btnSoldProduct.TabIndex = 1;
            this.btnSoldProduct.Text = "button1";
            this.btnSoldProduct.UseVisualStyleBackColor = true;
            this.btnSoldProduct.Click += new System.EventHandler(this.btnSoldProduct_Click);
            // 
            // FormListSoldProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 473);
            this.Controls.Add(this.btnSoldProduct);
            this.Controls.Add(this.SoldProductData);
            this.Name = "FormListSoldProduct";
            this.Text = "FormListSoldProduct";
            ((System.ComponentModel.ISupportInitialize)(this.SoldProductData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SoldProductData;
        private System.Windows.Forms.Button btnSoldProduct;
    }
}