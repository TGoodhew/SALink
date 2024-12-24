namespace SALink
{
    partial class SettingsForm
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
            this.settingLabel = new System.Windows.Forms.Label();
            this.settingsTxtAddress = new System.Windows.Forms.TextBox();
            this.btnSettingsOK = new System.Windows.Forms.Button();
            this.btnSettingsCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingLabel
            // 
            this.settingLabel.AutoSize = true;
            this.settingLabel.Location = new System.Drawing.Point(33, 24);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(82, 13);
            this.settingLabel.TabIndex = 0;
            this.settingLabel.Text = "Device Address";
            // 
            // settingsTxtAddress
            // 
            this.settingsTxtAddress.Location = new System.Drawing.Point(36, 40);
            this.settingsTxtAddress.Name = "settingsTxtAddress";
            this.settingsTxtAddress.Size = new System.Drawing.Size(247, 20);
            this.settingsTxtAddress.TabIndex = 1;
            // 
            // btnSettingsOK
            // 
            this.btnSettingsOK.Location = new System.Drawing.Point(36, 77);
            this.btnSettingsOK.Name = "btnSettingsOK";
            this.btnSettingsOK.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsOK.TabIndex = 2;
            this.btnSettingsOK.Text = "OK";
            this.btnSettingsOK.UseVisualStyleBackColor = true;
            // 
            // btnSettingsCancel
            // 
            this.btnSettingsCancel.Location = new System.Drawing.Point(117, 77);
            this.btnSettingsCancel.Name = "btnSettingsCancel";
            this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsCancel.TabIndex = 3;
            this.btnSettingsCancel.Text = "Cancel";
            this.btnSettingsCancel.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 118);
            this.Controls.Add(this.btnSettingsCancel);
            this.Controls.Add(this.btnSettingsOK);
            this.Controls.Add(this.settingsTxtAddress);
            this.Controls.Add(this.settingLabel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsOnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingLabel;
        private System.Windows.Forms.TextBox settingsTxtAddress;
        private System.Windows.Forms.Button btnSettingsOK;
        private System.Windows.Forms.Button btnSettingsCancel;
    }
}