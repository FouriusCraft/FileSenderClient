using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace FileSenderClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbServer.Text = "localhost";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFilename.Text = openFileDialog1.FileName;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbFilename.Text))
            {
                MessageBox.Show("Pilih file dulu.");
                return;
            }

            byte[] fileBuffer = File.ReadAllBytes(tbFilename.Text);

            try
            {
                using (var client = new TcpClient(tbServer.Text, 8080))
                using (var ns = client.GetStream())
                {
                    byte[] nameBytes = Encoding.UTF8.GetBytes(Path.GetFileName(tbFilename.Text));
                    byte[] nameLen = BitConverter.GetBytes(nameBytes.Length);
                    byte[] fileLen = BitConverter.GetBytes((long)fileBuffer.Length);

                    ns.Write(nameLen, 0, nameLen.Length);
                    ns.Write(nameBytes, 0, nameBytes.Length);
                    ns.Write(fileLen, 0, fileLen.Length);

                    ns.Write(fileBuffer, 0, fileBuffer.Length);
                }

                MessageBox.Show("File terkirim.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal kirim: " + ex.Message);
            }
        }
    }
}