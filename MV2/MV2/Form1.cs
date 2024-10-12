using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV2
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private const int port = 11000; // Порт для UDP

        public Form1()
        {
            InitializeComponent();
            ownIp.Text = GetLocalIPAddress(); // Виводить власне IP
            StartListener(); // Стартує сервер для прийому повідомлень
        }

        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void StartListener()
        {
            udpClient = new UdpClient(port);
            Task.Run(() => ReceiveMessages());
        }

        private async Task ReceiveMessages()
        {
            while (true)
            {
                var result = await udpClient.ReceiveAsync();
                var message = Encoding.UTF8.GetString(result.Buffer);
                // Додаємо перевірку, щоб не відображати власні повідомлення
                if (!message.StartsWith("Me:")) // Не відображаємо повідомлення, якщо воно від нас
                {
                    Invoke(new Action(() => DisplayMessage(message)));
                }
            }
        }

        private void DisplayMessage(string message)
        {
            messagesTextBox.AppendText(message + Environment.NewLine);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = textField.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                // Відправляємо повідомлення без префікса "Me:"
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.Send(data, data.Length, ipField.Text, port);

                // Відображаємо ваше повідомлення у вікні чату
                DisplayMessage($"Me: {message}");
                textField.Clear(); // Очищаємо поле введення після надсилання
            }
        }
    }
}
