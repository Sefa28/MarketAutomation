namespace MarketAutomation.Forms
{
    partial class FormAddStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddStaff));
            this.LabelNumberofRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.BtnAddStaff = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBirthDate = new System.Windows.Forms.DateTimePicker();
            this.TextStaffName = new System.Windows.Forms.TextBox();
            this.TextStaffPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffData = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.TextIdentity = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbBoxGraduationInfo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StaffData)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNumberofRecords
            // 
            this.LabelNumberofRecords.AutoSize = true;
            this.LabelNumberofRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberofRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelNumberofRecords.Location = new System.Drawing.Point(1126, 334);
            this.LabelNumberofRecords.Name = "LabelNumberofRecords";
            this.LabelNumberofRecords.Size = new System.Drawing.Size(85, 32);
            this.LabelNumberofRecords.TabIndex = 39;
            this.LabelNumberofRecords.Text = "_____";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(834, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "Number of Records";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(1259, 230);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(137, 36);
            this.radioButtonFemale.TabIndex = 37;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(1110, 232);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(101, 36);
            this.radioButtonMale.TabIndex = 36;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // BtnAddStaff
            // 
            this.BtnAddStaff.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddStaff.Appearance.Options.UseFont = true;
            this.BtnAddStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddStaff.ImageOptions.Image")));
            this.BtnAddStaff.Location = new System.Drawing.Point(994, 385);
            this.BtnAddStaff.Name = "BtnAddStaff";
            this.BtnAddStaff.Size = new System.Drawing.Size(300, 80);
            this.BtnAddStaff.TabIndex = 35;
            this.BtnAddStaff.Text = "Add Staff";
            this.BtnAddStaff.Click += new System.EventHandler(this.BtnAddStaff_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(834, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Gender";
            // 
            // TextBirthDate
            // 
            this.TextBirthDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBirthDate.Location = new System.Drawing.Point(1110, 180);
            this.TextBirthDate.Name = "TextBirthDate";
            this.TextBirthDate.Size = new System.Drawing.Size(300, 39);
            this.TextBirthDate.TabIndex = 33;
            // 
            // TextStaffName
            // 
            this.TextStaffName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextStaffName.Location = new System.Drawing.Point(1110, 76);
            this.TextStaffName.Name = "TextStaffName";
            this.TextStaffName.Size = new System.Drawing.Size(300, 39);
            this.TextStaffName.TabIndex = 32;
            // 
            // TextStaffPhoneNumber
            // 
            this.TextStaffPhoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextStaffPhoneNumber.Location = new System.Drawing.Point(1110, 126);
            this.TextStaffPhoneNumber.Mask = "(999) 000-0000";
            this.TextStaffPhoneNumber.Name = "TextStaffPhoneNumber";
            this.TextStaffPhoneNumber.Size = new System.Drawing.Size(300, 39);
            this.TextStaffPhoneNumber.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(834, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 30;
            this.label3.Text = "BirthDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(834, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(834, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Staff Name";
            // 
            // StaffData
            // 
            this.StaffData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffData.Location = new System.Drawing.Point(5, 7);
            this.StaffData.Name = "StaffData";
            this.StaffData.RowTemplate.Height = 24;
            this.StaffData.Size = new System.Drawing.Size(816, 458);
            this.StaffData.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(834, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 32);
            this.label6.TabIndex = 40;
            this.label6.Text = "Identity";
            // 
            // TextIdentity
            // 
            this.TextIdentity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIdentity.Location = new System.Drawing.Point(1110, 23);
            this.TextIdentity.Mask = "00000000000";
            this.TextIdentity.Name = "TextIdentity";
            this.TextIdentity.Size = new System.Drawing.Size(300, 39);
            this.TextIdentity.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(834, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 32);
            this.label7.TabIndex = 42;
            this.label7.Text = "Graduation Info";
            // 
            // CmbBoxGraduationInfo
            // 
            this.CmbBoxGraduationInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxGraduationInfo.FormattingEnabled = true;
            this.CmbBoxGraduationInfo.Location = new System.Drawing.Point(1110, 279);
            this.CmbBoxGraduationInfo.Name = "CmbBoxGraduationInfo";
            this.CmbBoxGraduationInfo.Size = new System.Drawing.Size(300, 40);
            this.CmbBoxGraduationInfo.TabIndex = 43;
            // 
            // FormAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 473);
            this.Controls.Add(this.CmbBoxGraduationInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextIdentity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelNumberofRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.BtnAddStaff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBirthDate);
            this.Controls.Add(this.TextStaffName);
            this.Controls.Add(this.TextStaffPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StaffData);
            this.Name = "FormAddStaff";
            this.Text = "FormAddStaff";
            this.Load += new System.EventHandler(this.FormAddStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNumberofRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private DevExpress.XtraEditors.SimpleButton BtnAddStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TextBirthDate;
        private System.Windows.Forms.TextBox TextStaffName;
        private System.Windows.Forms.MaskedTextBox TextStaffPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StaffData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TextIdentity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbBoxGraduationInfo;
    }
}