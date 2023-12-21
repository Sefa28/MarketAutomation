namespace MarketAutomation.Forms
{
    partial class FormTotalEarn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTotalEarn));
            this.labelLearnTotalEarn = new System.Windows.Forms.Label();
            this.BtnLearnEarn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelLearnTotalEarn
            // 
            this.labelLearnTotalEarn.AutoSize = true;
            this.labelLearnTotalEarn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLearnTotalEarn.ForeColor = System.Drawing.Color.Red;
            this.labelLearnTotalEarn.Location = new System.Drawing.Point(629, 151);
            this.labelLearnTotalEarn.Name = "labelLearnTotalEarn";
            this.labelLearnTotalEarn.Size = new System.Drawing.Size(192, 55);
            this.labelLearnTotalEarn.TabIndex = 0;
            this.labelLearnTotalEarn.Text = "_______";
            // 
            // BtnLearnEarn
            // 
            this.BtnLearnEarn.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLearnEarn.Appearance.Options.UseFont = true;
            this.BtnLearnEarn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLearnEarn.ImageOptions.Image")));
            this.BtnLearnEarn.Location = new System.Drawing.Point(504, 249);
            this.BtnLearnEarn.Name = "BtnLearnEarn";
            this.BtnLearnEarn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnLearnEarn.Size = new System.Drawing.Size(458, 159);
            this.BtnLearnEarn.TabIndex = 1;
            this.BtnLearnEarn.Text = "Learn Total Earn at the \r\nEnd of the Day ";
            this.BtnLearnEarn.Click += new System.EventHandler(this.BtnLearnEarn_Click);
            // 
            // FormTotalEarn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 473);
            this.Controls.Add(this.BtnLearnEarn);
            this.Controls.Add(this.labelLearnTotalEarn);
            this.Name = "FormTotalEarn";
            this.Text = "FormTotalEarn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLearnTotalEarn;
        private DevExpress.XtraEditors.SimpleButton BtnLearnEarn;
    }
}