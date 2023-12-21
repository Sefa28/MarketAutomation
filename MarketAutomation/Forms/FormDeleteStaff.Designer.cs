namespace MarketAutomation.Forms
{
    partial class FormDeleteStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteStaff));
            this.BtnFireEveryone = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGetLaidOff = new DevExpress.XtraEditors.SimpleButton();
            this.BtnFindStaff = new DevExpress.XtraEditors.SimpleButton();
            this.NumberofRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteStaffData = new System.Windows.Forms.DataGridView();
            this.TextStaffName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGetLaidOffSelect = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteStaffData)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFireEveryone
            // 
            this.BtnFireEveryone.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFireEveryone.Appearance.Options.UseFont = true;
            this.BtnFireEveryone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFireEveryone.ImageOptions.Image")));
            this.BtnFireEveryone.Location = new System.Drawing.Point(1006, 392);
            this.BtnFireEveryone.Name = "BtnFireEveryone";
            this.BtnFireEveryone.Size = new System.Drawing.Size(338, 69);
            this.BtnFireEveryone.TabIndex = 41;
            this.BtnFireEveryone.Text = "Fire Everyone";
            this.BtnFireEveryone.Click += new System.EventHandler(this.BtnFireEveryone_Click);
            // 
            // BtnGetLaidOff
            // 
            this.BtnGetLaidOff.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetLaidOff.Appearance.Options.UseFont = true;
            this.BtnGetLaidOff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGetLaidOff.ImageOptions.Image")));
            this.BtnGetLaidOff.Location = new System.Drawing.Point(1006, 235);
            this.BtnGetLaidOff.Name = "BtnGetLaidOff";
            this.BtnGetLaidOff.Size = new System.Drawing.Size(338, 71);
            this.BtnGetLaidOff.TabIndex = 40;
            this.BtnGetLaidOff.Text = "Get Laid Off";
            this.BtnGetLaidOff.Click += new System.EventHandler(this.BtnGetLaidOff_Click);
            // 
            // BtnFindStaff
            // 
            this.BtnFindStaff.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindStaff.Appearance.Options.UseFont = true;
            this.BtnFindStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFindStaff.ImageOptions.Image")));
            this.BtnFindStaff.Location = new System.Drawing.Point(1006, 160);
            this.BtnFindStaff.Name = "BtnFindStaff";
            this.BtnFindStaff.Size = new System.Drawing.Size(338, 69);
            this.BtnFindStaff.TabIndex = 39;
            this.BtnFindStaff.Text = "Find Staff";
            this.BtnFindStaff.Click += new System.EventHandler(this.BtnFindStaff_Click);
            // 
            // NumberofRecords
            // 
            this.NumberofRecords.AutoSize = true;
            this.NumberofRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NumberofRecords.Location = new System.Drawing.Point(1128, 78);
            this.NumberofRecords.Name = "NumberofRecords";
            this.NumberofRecords.Size = new System.Drawing.Size(85, 32);
            this.NumberofRecords.TabIndex = 38;
            this.NumberofRecords.Text = "_____";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(841, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 32);
            this.label5.TabIndex = 37;
            this.label5.Text = "Number of Records";
            // 
            // DeleteStaffData
            // 
            this.DeleteStaffData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteStaffData.Location = new System.Drawing.Point(5, 7);
            this.DeleteStaffData.Name = "DeleteStaffData";
            this.DeleteStaffData.RowTemplate.Height = 24;
            this.DeleteStaffData.Size = new System.Drawing.Size(816, 458);
            this.DeleteStaffData.TabIndex = 32;
            // 
            // TextStaffName
            // 
            this.TextStaffName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextStaffName.Location = new System.Drawing.Point(1121, 12);
            this.TextStaffName.Name = "TextStaffName";
            this.TextStaffName.Size = new System.Drawing.Size(300, 39);
            this.TextStaffName.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(845, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "Staff Name";
            // 
            // BtnGetLaidOffSelect
            // 
            this.BtnGetLaidOffSelect.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetLaidOffSelect.Appearance.Options.UseFont = true;
            this.BtnGetLaidOffSelect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnGetLaidOffSelect.Location = new System.Drawing.Point(1006, 315);
            this.BtnGetLaidOffSelect.Name = "BtnGetLaidOffSelect";
            this.BtnGetLaidOffSelect.Size = new System.Drawing.Size(338, 71);
            this.BtnGetLaidOffSelect.TabIndex = 44;
            this.BtnGetLaidOffSelect.Text = "Get Laid Off(Select)";
            this.BtnGetLaidOffSelect.Click += new System.EventHandler(this.BtnGetLaidOffSelect_Click);
            // 
            // FormDeleteStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 473);
            this.Controls.Add(this.BtnGetLaidOffSelect);
            this.Controls.Add(this.TextStaffName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFireEveryone);
            this.Controls.Add(this.BtnGetLaidOff);
            this.Controls.Add(this.BtnFindStaff);
            this.Controls.Add(this.NumberofRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteStaffData);
            this.Name = "FormDeleteStaff";
            this.Text = "FormDeleteStaff";
            this.Load += new System.EventHandler(this.FormDeleteStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteStaffData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnFireEveryone;
        private DevExpress.XtraEditors.SimpleButton BtnGetLaidOff;
        private DevExpress.XtraEditors.SimpleButton BtnFindStaff;
        private System.Windows.Forms.Label NumberofRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DeleteStaffData;
        private System.Windows.Forms.TextBox TextStaffName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton BtnGetLaidOffSelect;
    }
}