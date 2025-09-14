
using System.Collections;

using System.Net;
using System.Net.Sockets;


namespace FileReceiverServer
{
    public partial class Form1 : Form
    {
        private readonly ArrayList _sockets = new ArrayList();
        private TcpListener _listener;
        private readonly object _fileLock = new object();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            lblStatus.Text = "My IP: " + host.AddressList[0];

            var th = new Thread(ListenerThread) { IsBackground = true };
            th.Start();
        }

        private void ListenerThread()
        {
            _listener = new TcpListener(IPAddress.Any, 8080);
            _listener.Start();

            while (true) {
                var socket = _listener.AcceptSocket();
                if (socket.Connected)
                {
                    BeginInvoke(new Action(() =>
                        lbConnections.Items.Add($"{socket.RemoteEndPoint} connected.")));

                    lock (_sockets) _sockets.Add(socket);

                    var th = new Thread(HandlerThread) { IsBackground = true };
                    th.Start();
                }
            }
        }

        private void HandlerThread()
        {
            Socket s;
            lock (_sockets)
            {
                s = (Socket)_sockets[_sockets.Count - 1];
                _sockets.RemoveAt(_sockets.Count - 1);
            }

            using (var ns = new NetworkStream(s))
            {
              
                byte[] intBuf = new byte[4];
                ReadExact(ns, intBuf, 4);
                int nameLen = BitConverter.ToInt32(intBuf, 0);

                byte[] nameBuf = new byte[nameLen];
                ReadExact(ns, nameBuf, nameLen);
                string fileName = System.Text.Encoding.UTF8.GetString(nameBuf);

                byte[] longBuf = new byte[8];
                ReadExact(ns, longBuf, 8);
                long fileLen = BitConverter.ToInt64(longBuf, 0);

              
                string doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string savePath = Path.Combine(doc, fileName);

              
                byte[] buffer = new byte[1024];
                long remaining = fileLen;

                lock (_fileLock) 
                {
                    using (var fs = File.Create(savePath))
                    {
                        while (remaining > 0)
                        {
                            int toRead = (int)Math.Min(buffer.Length, remaining);
                            int read = ns.Read(buffer, 0, toRead);
                            if (read <= 0) break;
                            fs.Write(buffer, 0, read);
                            remaining -= read;
                        }
                    }
                }

                BeginInvoke(new Action(() =>
                    lbConnections.Items.Add($"File written: {savePath}")));
            }
        }

        private static void ReadExact(NetworkStream ns, byte[] buf, int len)
        {
            int offset = 0;
            while (offset < len)
            {
                int read = ns.Read(buf, offset, len - offset);
                if (read <= 0) throw new IOException("Stream ended unexpectedly");
                offset += read;
            }
        }
    }
}
