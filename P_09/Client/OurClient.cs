using System.Net.Sockets;
using System.Text;

namespace Client
{
    class OurClient
    {
        private TcpClient client;
        private StreamWriter sWriter;   // поток, который читает данные
        private StreamReader sReader;   // поток, который получает данные

        public OurClient()
        {
            client = new TcpClient("127.0.0.1", 5555);                      // ip адрес (собственного компьютера - для всех компов подходит), номер порта
            sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);  // отправка данных клиента по потоку
            sReader = new StreamReader(client.GetStream(), Encoding.UTF8);  // получение данных от клиента по потоку

            HandleCommunicacion();
        }

        void HandleCommunicacion()
        {
            while (true)            // бесконечный цикл, чтобы не пропало соединение
            {
                Console.Write("> ");
                string? massege = Console.ReadLine();
                sWriter.WriteLine(massege);
                sWriter.Flush();

                string answerServer = sReader.ReadLine();
                Console.WriteLine($"Сервер ответил -> {answerServer}");
            }
        }
    }
}