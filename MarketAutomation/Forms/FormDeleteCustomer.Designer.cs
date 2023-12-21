namespace MarketAutomation.Forms
{
    partial class FormDeleteCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteCustomer));
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteCustomerData = new System.Windows.Forms.DataGridView();
            this.NumberofRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnFindCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDeleteCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDeleteAllCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDeleteCustomerSelected = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCustomerData)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerName.Location = new System.Drawing.Point(1121, 35);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(300, 39);
            this.TxtCustomerName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(841, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Customer Name";
            // 
            // DeleteCustomerData
            // 
            this.DeleteCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteCustomerData.Location = new System.Drawing.Point(5, 7);
            this.DeleteCustomerData.Name = "DeleteCustomerData";
            this.DeleteCustomerData.RowTemplate.Height = 24;
            this.DeleteCustomerData.Size = new System.Drawing.Size(816, 458);
            this.DeleteCustomerData.TabIndex = 20;
            // 
            // NumberofRecords
            // 
            this.NumberofRecords.AutoSize = true;
            this.NumberofRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NumberofRecords.Location = new System.Drawing.Point(1136, 98);
            this.NumberofRecords.Name = "NumberofRecords";
            this.NumberofRecords.Size = new System.Drawing.Size(85, 32);
            this.NumberofRecords.TabIndex = 28;
            this.NumberofRecords.Text = "_____";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(840, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Number of Records";
            // 
            // BtnFindCustomer
            // 
            this.BtnFindCustomer.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindCustomer.Appearance.Options.UseFont = true;
            this.BtnFindCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFindCustomer.ImageOptions.Image")));
            this.BtnFindCustomer.Location = new System.Drawing.Point(1006, 163);
            this.BtnFindCustomer.Name = "BtnFindCustomer";
            this.BtnFindCustomer.Size = new System.Drawing.Size(338, 69);
            this.BtnFindCustomer.TabIndex = 29;
            this.BtnFindCustomer.Text = "Find Customer";
            this.BtnFindCustomer.Click += new System.EventHandler(this.BtnFindCustomer_Click);
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCustomer.Appearance.Options.UseFont = true;
            this.BtnDeleteCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteCustomer.ImageOptions.Image")));
            this.BtnDeleteCustomer.Location = new System.Drawing.Point(1006, 238);
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(338, 71);
            this.BtnDeleteCustomer.TabIndex = 30;
            this.BtnDeleteCustomer.Text = "Delete Customer";
            this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // BtnDeleteAllCustomer
            // 
            this.BtnDeleteAllCustomer.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteAllCustomer.Appearance.Options.UseFont = true;
            this.BtnDeleteAllCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteAllCustomer.ImageOptions.Image")));
            this.BtnDeleteAllCustomer.Location = new System.Drawing.Point(1006, 392);
            this.BtnDeleteAllCustomer.Name = "BtnDeleteAllCustomer";
            this.BtnDeleteAllCustomer.Size = new System.Drawing.Size(338, 69);
            this.BtnDeleteAllCustomer.TabIndex = 31;
            this.BtnDeleteAllCustomer.Text = "Delete All Customers";
            this.BtnDeleteAllCustomer.Click += new System.EventHandler(this.BtnDeleteAllCustomer_Click);
            // 
            // BtnDeleteCustomerSelected
            // 
            this.BtnDeleteCustomerSelected.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCustomerSelected.Appearance.Options.UseFont = true;
            this.BtnDeleteCustomerSelected.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteCustomerSelected.ImageOptions.Image")));
            this.BtnDeleteCustomerSelected.Location = new System.Drawing.Point(1006, 315);
            this.BtnDeleteCustomerSelected.Name = "BtnDeleteCustomerSelected";
            this.BtnDeleteCustomerSelected.Size = new System.Drawing.Size(338, 71);
            this.BtnDeleteCustomerSelected.TabIndex = 32;
            this.BtnDeleteCustomerSelected.Text = "Delete Customer(Select)";
            this.BtnDeleteCustomerSelected.Click += new System.EventHandler(this.BtnDeleteCustomerSelected_Click);
            // 
            // FormDeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 473);
            this.Controls.Add(this.BtnDeleteCustomerSelected);
            this.Controls.Add(this.BtnDeleteAllCustomer);
            this.Controls.Add(this.BtnDeleteCustomer);
            this.Controls.Add(this.BtnFindCustomer);
            this.Controls.Add(this.NumberofRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteCustomerData);
            this.Name = "FormDeleteCustomer";
            this.Text = "FormDeleteCustomer";
            this.Load += new System.EventHandler(this.FormDeleteCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCustomerData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumberofRecords;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton BtnFindCustomer;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteCustomer;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteAllCustomer;
        public System.Windows.Forms.DataGridView DeleteCustomerData;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteCustomerSelected;
    }
}