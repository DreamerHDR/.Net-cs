using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Laba4.Serialization
{
    [Serializable]
    public class StorageSerializable
    {
        public List<Subscriber> Subscribers { get; set; } = new List<Subscriber>();
        public List<City> Cities { get; set; } = new List<City>();
        public List<CallSerializable> Calls { get; set; } = new List<CallSerializable>();

        public static void Save(string fileName, SerializeType type)
        {
            var storageSerializable = new StorageSerializable();
            var storage = Storage.Instance;
            foreach (var subscriber in storage.Subscribers)
            {
                storageSerializable.Subscribers.Add(subscriber);
            }
            foreach (var city in storage.Cities)
            {
                storageSerializable.Cities.Add(city);
            }
            foreach (var call in storage.Calls)
            {
                storageSerializable.Calls.Add(new CallSerializable
                {
                    CityId = call.City.Name,
                    SubscriberId = call.Subscriber.INN,
                    CallDate = call.CallDate,
                    Minutes = call.Minutes,
                    TimeOfDay = call.TimeOfDay.ToString()
                }) ;
            }
            switch(type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(StorageSerializable));
                    using (StreamWriter xmlStreamWriter = new StreamWriter(fileName))
                    {
                        xmlSerializer.Serialize(xmlStreamWriter, storageSerializable);
                    }
                    break;
                case SerializeType.JSON:
                    using (StreamWriter jsonStreamWriter = File.CreateText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer { Formatting = Formatting.Indented };
                        jsonSerializer.Serialize(jsonStreamWriter, storageSerializable);
                    }
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream binaryFileStream = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(binaryFileStream, storageSerializable);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public static void Load(string fileName, SerializeType type)
        {
            StorageSerializable storageSerializable;
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(StorageSerializable));
                    using (StreamReader streamReader = new StreamReader(fileName))
                    {
                        storageSerializable = (StorageSerializable)xmlSerializer.Deserialize(streamReader);
                    }
                    break;
                case SerializeType.JSON:
                    using (StreamReader jsonStreamReader = File.OpenText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer();
                        storageSerializable = (StorageSerializable)jsonSerializer.Deserialize(jsonStreamReader, typeof(StorageSerializable));
                    }
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream binaryFileStream = new FileStream(fileName, FileMode.Open))
                    {
                        storageSerializable = (StorageSerializable)formatter.Deserialize(binaryFileStream);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            var storage = Storage.Instance;
            var storageSubscribers = storage.Subscribers.ToList();
            var storageCitys = storage.Cities.ToList();
            var storageCalls = storage.Calls.ToList();

            foreach (var storageSubscriber in storageSubscribers )
            {
                storage.RemoveSubscriber(storageSubscriber.INN);
            }

            foreach (var storageCity in storageCitys)
            {
                storage.RemoveCity(storageCity.Name);
            }

            foreach (var storageCall in storageCalls)
            {
                storage.RemoveCall(storageCall);
            }
            var subscribers = new Dictionary<string, Subscriber>();
            var citys = new Dictionary<string, City>();
            int maxSubsciberId = 0;
            foreach (var subscriber in storageSerializable.Subscribers)
            {
                if (subscriber.INN.Length > maxSubsciberId) maxSubsciberId = subscriber.INN.Length;
                subscribers.Add(subscriber.INN, subscriber);
                storage.AddSubscriber(subscriber);
            }
            foreach (var city in storageSerializable.Cities)
            {
                citys.Add(city.Name, city);
                storage.AddCity(city);
            }
            foreach (var call in storageSerializable.Calls)
            {
                TimeOfDay timeOfDay;
                if (TimeOfDay.TryParse(call.TimeOfDay, out timeOfDay))
                {
                    storage.AddCall(new Call
                    {
                        Subscriber = subscribers[call.SubscriberId],
                        City = citys[call.CityId],
                        CallDate = call.CallDate,
                        Minutes = call.Minutes,
                        TimeOfDay = timeOfDay
                    });
                }

            }
        }
    }
}
