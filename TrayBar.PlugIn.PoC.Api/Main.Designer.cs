namespace TrayBar.PlugIn.PoC.Api
{
    partial class Main
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
            this.lblStatusDispaly = new System.Windows.Forms.Label();
            this.lblVersionDisplay = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnOpenConfiguration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatusDispaly
            // 
            this.lblStatusDispaly.AutoSize = true;
            this.lblStatusDispaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusDispaly.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStatusDispaly.Location = new System.Drawing.Point(249, 180);
            this.lblStatusDispaly.Name = "lblStatusDispaly";
            this.lblStatusDispaly.Size = new System.Drawing.Size(424, 29);
            this.lblStatusDispaly.TabIndex = 11;
            this.lblStatusDispaly.Text = "Open configuration to start the web api";
            // 
            // lblVersionDisplay
            // 
            this.lblVersionDisplay.AutoSize = true;
            this.lblVersionDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVersionDisplay.Location = new System.Drawing.Point(249, 132);
            this.lblVersionDisplay.Name = "lblVersionDisplay";
            this.lblVersionDisplay.Size = new System.Drawing.Size(174, 29);
            this.lblVersionDisplay.TabIndex = 10;
            this.lblVersionDisplay.Text = "15.9.28307.718";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(158, 180);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 29);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(142, 132);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(101, 29);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "Version:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(119, 43);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(562, 55);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Tray Bar Application PoC";
            // 
            // btnOpenConfiguration
            // 
            this.btnOpenConfiguration.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnOpenConfiguration.Location = new System.Drawing.Point(301, 319);
            this.btnOpenConfiguration.Name = "btnOpenConfiguration";
            this.btnOpenConfiguration.Size = new System.Drawing.Size(190, 88);
            this.btnOpenConfiguration.TabIndex = 6;
            this.btnOpenConfiguration.Text = "Open Configuration";
            this.btnOpenConfiguration.UseVisualStyleBackColor = true;
            this.btnOpenConfiguration.Click += new System.EventHandler(this.btnOpenConfiguration_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatusDispaly);
            this.Controls.Add(this.lblVersionDisplay);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnOpenConfiguration);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatusDispaly;
        private System.Windows.Forms.Label lblVersionDisplay;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnOpenConfiguration;
    }
}

