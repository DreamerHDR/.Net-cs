using Laba4.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    /// <summary>
    /// Хранилище данных для городов, абонентов и звонков
    /// </summary>
    public class Storage
    {
        private static Storage _instance;

        /// <summary>
        /// Единственный экземпляр класса Storage
        /// </summary>
        public static Storage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Storage();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Приватный конструктор
        /// </summary>
        private Storage() { }

        /// <summary>
        /// Словарь городов, где ключ — название города.
        /// </summary>
        private Dictionary<string, City> _cities = new Dictionary<string, City>();

        /// <summary>
        /// Словарь абонентов, где ключ — ИНН.
        /// </summary>
        private Dictionary<string, Subscriber> _subscribers = new Dictionary<string, Subscriber>();

        /// <summary>
        /// Список звонков.
        /// </summary>
        private List<Call> _calls = new List<Call>();

        /// <summary>
        /// Коллекция городов.
        /// </summary>
        public IEnumerable<City> Cities
        {
            get { return _cities.Values.AsEnumerable(); }
        }

        /// <summary>
        /// Коллекция абонентов.
        /// </summary>
        public IEnumerable<Subscriber> Subscribers
        {
            get { return _subscribers.Values.AsEnumerable(); }
        }

        /// <summary>
        /// Коллекция звонков.
        /// </summary>
        public IEnumerable<Call> Calls
        {
            get
            {
                return _calls;
            }
        }

        public event EventHandler CityAdded;
        public event EventHandler SubscriberAdded;
        public event EventHandler CallAdded;
        public event EventHandler CityRemoved;
        public event EventHandler SubscriberRemoved;
        public event EventHandler CallRemoved;

        /// <summary>
        /// Добавление города
        /// </summary>
        public void AddCity(City city)
        {
            if (!city.IsValid)
            {
                throw new InvalidCityException("Информация о городе заполнена некорректно");
            }

            try
            {
                _cities.Add(city.Name, city);
                CityAdded?.Invoke(city, EventArgs.Empty);
            }
            catch (System.Exception ex)
            {
                throw new InvalidCityException("При добавлении города произошла ошибка", ex);
            }
        }

        /// <summary>
        /// Добавление абонента
        /// </summary>
        public void AddSubscriber(Subscriber subscriber)
        {
            if (!subscriber.IsValid)
            {
                throw new InvalidSubscriberException("Информация об абоненте заполнена некорректно");
            }

            try
            {
                _subscribers.Add(subscriber.INN, subscriber);
                SubscriberAdded?.Invoke(subscriber, EventArgs.Empty);
            }
            catch (System.Exception ex)
            {
                throw new InvalidSubscriberException("При добавлении абонента произошла ошибка", ex);
            }
        }

        /// <summary>
        /// Добавление звонка
        /// </summary>
        public void AddCall(Call call)
        {
            if (!call.IsValid)
            {
                throw new InvalidCallException("Информация о звонке заполнена некорректно");
            }

            try
            {
                _calls.Add(call);
                CallAdded?.Invoke(call, EventArgs.Empty);
            }
            catch (System.Exception ex)
            {
                throw new InvalidCallException("При добавлении звонка произошла ошибка", ex);
            }
        }

        /// <summary>
        /// Удаление города по названию
        /// </summary>
        public void RemoveCity(string cityName)
        {
            _cities.Remove(cityName);
            CityRemoved?.Invoke(cityName, EventArgs.Empty);

            // Удаляем звонки, связанные с городом
            var callsForCity = Calls.Where(c => c.City.Name == cityName).ToList();
            Console.WriteLine($"Количество звонков для города {cityName}: {callsForCity.Count}");

            for (int i = 0; i < callsForCity.Count; i++)
            {
                RemoveCall(callsForCity[i]);
            }
        }

        /// <summary>
        /// Удаление абонента по ИНН
        /// </summary>
        public void RemoveSubscriber(string inn)
        {
            _subscribers.Remove(inn);
            SubscriberRemoved?.Invoke(inn, EventArgs.Empty);

            // Удаляем звонки, связанные с абонентом
            var callsForSubscriber = Calls.Where(c => c.Subscriber.INN == inn).ToList();
            for (int i = 0; i < callsForSubscriber.Count; i++)
            {
                RemoveCall(callsForSubscriber[i]);
            }
        }

        /// <summary>
        /// Удаление звонка
        /// </summary>
        public void RemoveCall(Call call)
        {
            _calls.Remove(call);
            CallRemoved?.Invoke(call, EventArgs.Empty);
        }
    }
}


