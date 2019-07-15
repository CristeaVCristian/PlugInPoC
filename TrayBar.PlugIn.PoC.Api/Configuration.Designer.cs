namespace TrayBar.PlugIn.PoC.Api
{
    partial class Configuration
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
            this.lblInvalidPortNumber = new System.Windows.Forms.Label();
            this.btnSubmitPort = new System.Windows.Forms.Button();
            this.txtPortNumber = new System.Windows.Forms.TextBox();
            this.lblPortNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInvalidPortNumber
            // 
            this.lblInvalidPortNumber.AutoSize = true;
            this.lblInvalidPortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPortNumber.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPortNumber.Location = new System.Drawing.Point(179, 147);
            this.lblInvalidPortNumber.Name = "lblInvalidPortNumber";
            this.lblInvalidPortNumber.Size = new System.Drawing.Size(171, 24);
            this.lblInvalidPortNumber.TabIndex = 7;
            this.lblInvalidPortNumber.Text = "Invalid port number";
            this.lblInvalidPortNumber.Visible = false;
            // 
            // btnSubmitPort
            // 
            this.btnSubmitPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitPort.Location = new System.Drawing.Point(193, 174);
            this.btnSubmitPort.Name = "btnSubmitPort";
            this.btnSubmitPort.Size = new System.Drawing.Size(148, 72);
            this.btnSubmitPort.TabIndex = 6;
            this.btnSubmitPort.Text = "Submit";
            this.btnSubmitPort.UseVisualStyleBackColor = true;
            this.btnSubmitPort.Click += new System.EventHandler(this.btnSubmitPort_Click);
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPortNumber.Location = new System.Drawing.Point(285, 88);
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.Size = new System.Drawing.Size(128, 31);
            this.txtPortNumber.TabIndex = 5;
            // 
            // lblPortNumber
            // 
            this.lblPortNumber.AutoSize = true;
            this.lblPortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortNumber.Location = new System.Drawing.Point(135, 88);
            this.lblPortNumber.Name = "lblPortNumber";
            this.lblPortNumber.Size = new System.Drawing.Size(144, 25);
            this.lblPortNumber.TabIndex = 4;
            this.lblPortNumber.Text = "Port Number: ";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 334);
            this.Controls.Add(this.lblInvalidPortNumber);
            this.Controls.Add(this.btnSubmitPort);
            this.Controls.Add(this.txtPortNumber);
            this.Controls.Add(this.lblPortNumber);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvalidPortNumber;
        private System.Windows.Forms.Button btnSubmitPort;
        private System.Windows.Forms.TextBox txtPortNumber;
        private System.Windows.Forms.Label lblPortNumber;
    }
}