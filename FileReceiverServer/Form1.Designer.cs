namespace FileReceiverServer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblStatus;  
        private System.Windows.Forms.ListBox lbConnections;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbConnections = new System.Windows.Forms.ListBox();

            // Form
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.MinimumSize = new System.Drawing.Size(560, 340);
            this.Name = "Form1";
            this.Text = "File Receiver (Server)";
            this.Load += new System.EventHandler(this.Form1_Load);

        
            this.lblCaption.AutoSize = true;
            this.lblCaption.Location = new System.Drawing.Point(18, 18);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(51, 15);
            this.lblCaption.Text = "My IP  :";

            
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                   | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(72, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(510, 20);
            this.lblStatus.Text = "-";

            
            this.lbConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                   | System.Windows.Forms.AnchorStyles.Left)
                                   | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConnections.FormattingEnabled = true;
            this.lbConnections.ItemHeight = 15;
            this.lbConnections.Location = new System.Drawing.Point(18, 52);
            this.lbConnections.Name = "lbConnections";
            this.lbConnections.Size = new System.Drawing.Size(564, 289);
            
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lbConnections);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
