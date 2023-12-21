namespace MarketAutomation.Forms
{
    partial class FormWriteMessageAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWriteMessageAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.TextStaffMessage = new System.Windows.Forms.RichTextBox();
            this.BtnConfirmProductReturn = new DevExpress.XtraEditors.SimpleButton();
            this.TextIdentity = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(292, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Write Message";
            // 
            // TextStaffMessage
            // 
            this.TextStaffMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextStaffMessage.Location = new System.Drawing.Point(561, 59);
            this.TextStaffMessage.Name = "TextStaffMessage";
            this.TextStaffMessage.Size = new System.Drawing.Size(345, 152);
            this.TextStaffMessage.TabIndex = 23;
            this.TextStaffMessage.Text = "";
            // 
            // BtnConfirmProductReturn
            // 
            this.BtnConfirmProductReturn.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmProductReturn.Appearance.Options.UseFont = true;
            this.BtnConfirmProductReturn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfirmProductReturn.ImageOptions.Image")));
            this.BtnConfirmProductReturn.Location = new System.Drawing.Point(588, 336);
            this.BtnConfirmProductReturn.Name = "BtnConfirmProductReturn";
            this.BtnConfirmProductReturn.Size = new System.Drawing.Size(300, 80);
            this.BtnConfirmProductReturn.TabIndex = 24;
            this.BtnConfirmProductReturn.Text = "Send";
            this.BtnConfirmProductReturn.Click += new System.EventHandler(this.BtnConfirmProductReturn_Click);
            // 
            // TextIdentity
            // 
            this.TextIdentity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIdentity.Location = new System.Drawing.Point(561, 242);
            this.TextIdentity.Mask = "00000";
            this.TextIdentity.Name = "TextIdentity";
            this.TextIdentity.Size = new System.Drawing.Size(345, 39);
            this.TextIdentity.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(369, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Identity";
            // 
            // FormWriteMessageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextIdentity);
            this.Controls.Add(this.BtnConfirmProductReturn);
            this.Controls.Add(this.TextStaffMessage);
            this.Controls.Add(this.label1);
            this.Name = "FormWriteMessageAdmin";
            this.Text = "FormWriteMessageAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TextStaffMessage;
        private DevExpress.XtraEditors.SimpleButton BtnConfirmProductReturn;
        private System.Windows.Forms.MaskedTextBox TextIdentity;
        private System.Windows.Forms.Label label2;
    }
}