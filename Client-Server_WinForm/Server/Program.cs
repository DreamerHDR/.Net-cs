using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ClassLibraryBank;

namespace Server
{
    class Program
    {
        private static ConcurrentDictionary<string, Bank> _banks = new ConcurrentDictionary<string, Bank>();
        private const string DataFilePath = "banks.json"; // Путь к файлу для сохранения данных

        static void Main(string[] args)
        {
            LoadDataFromFile(); // Загружаем данные при запуске

            // Запускаем поток для автосохранения данных
            Task.Run(() => SaveDataToFile());

            // Устанавливаем для сокета локальную конечную точку
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

            // Создаем сокет Tcp/Ip
            Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);
                Console.WriteLine("Сервер запущен, ожидаем соединения...");

                while (true)
                {
                    // Программа приостанавливается, ожидая входящее соединение
                    Socket socket = sListener.Accept();
                    Task.Run(() => Action(socket));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void LoadDataFromFile()
        {
            if (File.Exists(DataFilePath))
            {
                var json = File.ReadAllText(DataFilePath);
                var banks = JsonConvert.DeserializeObject<ConcurrentDictionary<string, Bank>>(json);
                if (banks != null)
                {
                    foreach (var kvp in banks)
                    {
                        _banks[kvp.Key] = kvp.Value; // Добавляем данные в словарь
                    }
                    Console.WriteLine("Данные загружены из файла.");
                }
            }
            else
            {
                Console.WriteLine("Файл не найден, создается новый справочник.");
            }
        }

        private static void SaveDataToFile()
        {
            while (true)
            {
                Task.Delay(10000).Wait(); // 10 секунд
                var json = JsonConvert.SerializeObject(_banks);
                File.WriteAllText(DataFilePath, json);
                Console.WriteLine("Данные сохранены в файл.");
            }
        }

        private static void Action(Socket socket)
        {
            try
            {
                byte[] bytes = new byte[10240];

                while (true)
                {
                    // Получаем данные от клиента
                    int bytesRec = socket.Receive(bytes);
                    if (bytesRec == 0) break; // Проверка на закрытие соединения

                    string json = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                    Console.WriteLine("Полученный json: " + json); // Выводим полученный json

                    BankResponse response = new BankResponse { IsSuccess = false };

                    try
                    {
                        var request = JsonConvert.DeserializeObject<BankRequest>(json);
                        if (request != null)
                        {
                            response.Key = request.Key;
                            Bank bank;

                            switch (request.Type)
                            {
                                case BankRequestType.Get:
                                    if (_banks.TryGetValue(request.Key, out bank))
                                    {
                                        response.Bank = bank; // Заполняем bank, если найден
                                        response.IsSuccess = true;
                                        Console.WriteLine("Банк найден: " + JsonConvert.SerializeObject(bank)); // Выводим информацию о банке
                                    }
                                    else
                                    {
                                        response.ErrorMessage = "Ключ не найден";
                                        Console.WriteLine(response.ErrorMessage); // Выводим сообщение об ошибке
                                    }
                                    break;

                                case BankRequestType.Add:
                                    if (_banks.TryAdd(request.Key, request.Bank))
                                    {
                                        response.IsSuccess = true;
                                        Console.WriteLine("Банк добавлен: " + JsonConvert.SerializeObject(request.Bank));
                                    }
                                    else
                                    {
                                        response.ErrorMessage = "Банк с таким ключом уже существует";
                                        Console.WriteLine(response.ErrorMessage);
                                    }
                                    break;

                                case BankRequestType.Update:
                                    if (_banks.ContainsKey(request.Key))
                                    {
                                        _banks[request.Key] = request.Bank;
                                        response.IsSuccess = true;
                                        Console.WriteLine("Банк обновлен: " + JsonConvert.SerializeObject(request.Bank));
                                    }
                                    else
                                    {
                                        response.ErrorMessage = "Банк с таким ключом не найден";
                                        Console.WriteLine(response.ErrorMessage);
                                    }
                                    break;

                                case BankRequestType.Remove:
                                    if (_banks.TryRemove(request.Key, out bank))
                                    {
                                        response.IsSuccess = true;
                                        Console.WriteLine("Банк удален: " + request.Key);
                                    }
                                    else
                                    {
                                        response.ErrorMessage = "Банк с таким ключом не найден";
                                        Console.WriteLine(response.ErrorMessage);
                                    }
                                    break;

                                default:
                                    response.ErrorMessage = "Неизвестный тип запроса";
                                    Console.WriteLine(response.ErrorMessage);
                                    break;
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        response.ErrorMessage = exception.Message;
                        Console.WriteLine("Ошибка: " + exception.Message); // Выводим сообщение об ошибке
                    }

                    // Отправляем ответ клиенту
                    var jsonResponse = JsonConvert.SerializeObject(response);
                    byte[] msg = Encoding.UTF8.GetBytes(jsonResponse);
                    socket.Send(msg);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка обработки запроса: " + ex.Message);
            }
            finally
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }
}
