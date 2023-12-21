namespace MarketAutomation.Forms
{
    partial class FormSaveCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaveCustomer));
            this.TextCustomerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.TextCustomerName = new System.Windows.Forms.TextBox();
            this.TextCustomerPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSaveCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelNumberofRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerData)).BeginInit();
            this.SuspendLayout();
            // 
            // TextCustomerBirthdate
            // 
            this.TextCustomerBirthdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCustomerBirthdate.Location = new System.Drawing.Point(1138, 242);
            this.TextCustomerBirthdate.Name = "TextCustomerBirthdate";
            this.TextCustomerBirthdate.Size = new System.Drawing.Size(286, 39);
            this.TextCustomerBirthdate.TabIndex = 20;
            // 
            // TextCustomerName
            // 
            this.TextCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCustomerName.Location = new System.Drawing.Point(1138, 29);
            this.TextCustomerName.Name = "TextCustomerName";
            this.TextCustomerName.Size = new System.Drawing.Size(286, 39);
            this.TextCustomerName.TabIndex = 19;
            // 
            // TextCustomerPhoneNumber
            // 
            this.TextCustomerPhoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCustomerPhoneNumber.Location = new System.Drawing.Point(1138, 99);
            this.TextCustomerPhoneNumber.Mask = "(999) 000-0000";
            this.TextCustomerPhoneNumber.Name = "TextCustomerPhoneNumber";
            this.TextCustomerPhoneNumber.Size = new System.Drawing.Size(286, 39);
            this.TextCustomerPhoneNumber.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(844, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Customer Birthdate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(848, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(848, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer Name";
            // 
            // CustomerData
            // 
            this.CustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerData.Location = new System.Drawing.Point(12, 7);
            this.CustomerData.Name = "CustomerData";
            this.CustomerData.RowTemplate.Height = 24;
            this.CustomerData.Size = new System.Drawing.Size(816, 458);
            this.CustomerData.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(848, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gender";
            // 
            // BtnSaveCustomer
            // 
            this.BtnSaveCustomer.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveCustomer.Appearance.Options.UseFont = true;
            this.BtnSaveCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveCustomer.ImageOptions.Image")));
            this.BtnSaveCustomer.Location = new System.Drawing.Point(999, 369);
            this.BtnSaveCustomer.Name = "BtnSaveCustomer";
            this.BtnSaveCustomer.Size = new System.Drawing.Size(300, 80);
            this.BtnSaveCustomer.TabIndex = 22;
            this.BtnSaveCustomer.Text = "Save Customer";
            this.BtnSaveCustomer.Click += new System.EventHandler(this.BtnSaveCustomer_Click);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(1141, 176);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(101, 36);
            this.radioButtonMale.TabIndex = 23;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(1287, 172);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(137, 36);
            this.radioButtonFemale.TabIndex = 24;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(848, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Number of Records";
            // 
            // LabelNumberofRecords
            // 
            this.LabelNumberofRecords.AutoSize = true;
            this.LabelNumberofRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberofRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelNumberofRecords.Location = new System.Drawing.Point(1135, 310);
            this.LabelNumberofRecords.Name = "LabelNumberofRecords";
            this.LabelNumberofRecords.Size = new System.Drawing.Size(85, 32);
            this.LabelNumberofRecords.TabIndex = 26;
            this.LabelNumberofRecords.Text = "_____";
            // 
            // FormSaveCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 473);
            this.Controls.Add(this.LabelNumberofRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.BtnSaveCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextCustomerBirthdate);
            this.Controls.Add(this.TextCustomerName);
            this.Controls.Add(this.TextCustomerPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerData);
            this.Name = "FormSaveCustomer";
            this.Text = "FormSaveCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker TextCustomerBirthdate;
        private System.Windows.Forms.TextBox TextCustomerName;
        private System.Windows.Forms.MaskedTextBox TextCustomerPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton BtnSaveCustomer;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelNumberofRecords;
        public System.Windows.Forms.DataGridView CustomerData;
    }
}