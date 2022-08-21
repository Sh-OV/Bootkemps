using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
    class OurServer
    {
        TcpListener server;

        public OurServer()
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 5555); // IPAdress - тип данных, функция Parse преобразоваывает строку в IPAdress
            server.Start();

            LoopClients();
        }
        void LoopClients()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();

                Thread thread = new Thread(() => HandleClient(client));
                thread.Start();
            }
        }
        void HandleClient(TcpClient client)
        {
            StreamReader sReader = new StreamReader(client.GetStream(),Encoding.UTF8); // получение данных от клиента по потоку
            StreamWriter sWriter = new StreamWriter(client.GetStream(),Encoding.UTF8); // отправка данных клиенту по потоку

            while (true)
            {
                string? massege = sReader.ReadLine();
                Console.WriteLine($"Клиент написал - {massege}");

                Console.WriteLine("Дайте сообщение клиенту: ");
                string? answer = Console.ReadLine();
                sWriter.WriteLine(answer);
                sWriter.Flush();
            }
        }
    }

}