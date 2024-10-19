using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBank;
using Newtonsoft.Json;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Добавляем обработчики событий для кнопок
            buttonAdd.Click += ButtonAdd_Click;
            buttonGet.Click += ButtonGet_Click;
            buttonDelete.Click += ButtonDelete_Click;
            buttonUpdate.Click += ButtonUpdate_Click;
        }

        // Буфер для входящих данных
        private byte[] buffer = new byte[10240];

        // Настройки сервера
        private IPHostEntry ipHost = Dns.GetHostEntry("localhost");
        private IPAddress ipAddr;
        private IPEndPoint ipEndPoint;
        private Socket senderSocket;

        private void InitializeSocket()
        {
            // Устанавливаем удаленную точку для сокета
            ipAddr = ipHost.AddressList[0];
            ipEndPoint = new IPEndPoint(ipAddr, 11000);
            senderSocket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            senderSocket.Connect(ipEndPoint);
        }
        private void CloseSocket()
        {
            senderSocket.Shutdown(SocketShutdown.Both);
            senderSocket.Close();
        }
        private void SendRequest(BankRequest request)
        {
            InitializeSocket();

            string jsonRequest = JsonConvert.SerializeObject(request);
            byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);

            // Отправляем данные через сокет
            senderSocket.Send(msg);

            // Получаем ответ от сервера
            int bytesRec = senderSocket.Receive(buffer);
            string jsonResponse = Encoding.UTF8.GetString(buffer, 0, bytesRec);

            // Показываем ответ в поле результатов
            textBoxResult.Text = jsonResponse;

            CloseSocket();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Создаем запрос на добавление банка
            BankRequest request = new BankRequest
            {
                Type = BankRequestType.Add,
                Key = textBoxKey.Text,
                Bank = new Bank
                {
                    Title = textBoxTitle.Text,
                    Country = textBoxCountry.Text,
                    Address = textBoxAddress.Text
                }
            };

            // Отправляем запрос
            SendRequest(request);
        }
        private void ButtonGet_Click(object sender, EventArgs e)
        {
            // Создаем запрос на получение банка
            BankRequest request = new BankRequest
            {
                Type = BankRequestType.Get,
                Key = textBoxKey.Text
            };

            // Отправляем запрос
            SendRequest(request);
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // Создаем запрос на удаление банка
            BankRequest request = new BankRequest
            {
                Type = BankRequestType.Remove,
                Key = textBoxKey.Text
            };

            // Отправляем запрос
            SendRequest(request);
        }
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            // Создаем запрос на обновление банка
            BankRequest request = new BankRequest
            {
                Type = BankRequestType.Update,
                Key = textBoxKey.Text,
                Bank = new Bank
                {
                    Title = textBoxTitle.Text,
                    Country = textBoxCountry.Text,
                    Address = textBoxAddress.Text
                }
            };

            // Отправляем запрос
            SendRequest(request);
        }

    }

}
