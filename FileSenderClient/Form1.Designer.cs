namespace FileSenderClient
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.labelServer = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            // Form
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 170);
            this.MinimumSize = new System.Drawing.Size(520, 170);
            this.Name = "Form1";
            this.Text = "File Sender (Client)";

            // labelServer
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(18, 20);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(64, 15);
            this.labelServer.Text = "Server / IP:";

            // tbServer
            this.tbServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServer.Location = new System.Drawing.Point(100, 16);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(440, 23);

            // labelFile
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(18, 58);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(27, 15);
            this.labelFile.Text = "File:";

            // tbFilename
            this.tbFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilename.Location = new System.Drawing.Point(100, 54);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.ReadOnly = true;
            this.tbFilename.Size = new System.Drawing.Size(360, 23);

            // btnBrowse
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(470, 54);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(70, 23);
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

            // btnSend
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(450, 115);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 30);
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // openFileDialog1
            this.openFileDialog1.Title = "Pilih file untuk dikirim";

            // add controls
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSend);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
