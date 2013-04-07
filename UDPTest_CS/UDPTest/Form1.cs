using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace UDPTest
{
    public partial class Form1 : Form
    {
        private delegate void Delegate_write(string data);

        // ソケット生成
        private UdpClient udpClientSender = new UdpClient();
        private UdpClient udpClientReciver;
        private IAsyncResult asyncResult;
        public Form1()
        {
            InitializeComponent();
        }

        // 参考
        // http://homepage2.nifty.com/nonnon/SoftSample/CS.NET/SampleUdpIp2.html
        private void Form1_Load(object sender, EventArgs e)
        {
            setIPAddress();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ソケットクローズ
            udpClientSender.Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            // ソケット接続
            string targetIpAddress = targetIPTextBox.Text;
            int targetPort = int.Parse(targetPortTextBox.Text);
            udpClientSender.Connect(targetIpAddress, targetPort);
            //udpClientSender.Connect("192.168.0.255", 4000);

            string message = messageTextBox.Text;
            String encodeName = Encoding.UTF8.BodyName;
            // ソケット送信
            Byte[] data = Encoding.GetEncoding(encodeName).GetBytes(message);
            udpClientSender.Send(data, data.GetLength(0));

            String text = "Send " + targetIpAddress + ":" + targetPort.ToString() + " " + message;

            logTextBox.AppendText(text + "\n");
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            

            // ソケット受信
            IPEndPoint ipAny = new IPEndPoint(IPAddress.Any, 0);
            Byte[] dat = udpClientReciver.EndReceive(AR, ref ipAny);

            String encodeName = Encoding.UTF8.BodyName;
            String text = Encoding.GetEncoding(encodeName).GetString(dat);
            Invoke(new Delegate_write(write), new Object[] { text });
            // ソケット非同期受信(System.AsyncCallback)
            asyncResult = udpClientReciver.BeginReceive(ReceiveCallback, udpClientReciver);
        }

        private void write(string data)
        {
            if (data != null)
            {
                logTextBox.AppendText(data + "\n");
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

            connectButton.Enabled = false;
            recivePortTextBox.Enabled = false;
            int recivePortText = int.Parse(recivePortTextBox.Text);
            udpClientReciver = new UdpClient(recivePortText);//8989
            // ソケット非同期受信(System.AsyncCallback)
            asyncResult = udpClientReciver.BeginReceive(ReceiveCallback, udpClientReciver);
        }

        private void setIPAddress()
        {

            // ヴァーチャルマシンなどを使っていると、複数のIPAddressを持つ場合があります。
            // 正確でない場合があります。

            int count = 0;
            IPAddress resultIPAddress = null;
            string hostname = Dns.GetHostName();
            IPAddress[] ipAddressList = Dns.GetHostAddresses(hostname);
            foreach (IPAddress ipAddress in ipAddressList)
            {
                if (ipAddress.ToString().Length < 16)
                {
                    resultIPAddress = ipAddress;
                    count++;
                }

            }
            if (count == 0)
            {
                label1.Text = "適切なIPAddressが見つかりませんでした";
            }else if(count == 1){
                label1.Text = "IPAddress:" + resultIPAddress.ToString();
            }
            else if (count > 1)
            {
                label1.Text = "複数の16桁未満のIPAddressが見つかりました";
            }


        }


    }
}
