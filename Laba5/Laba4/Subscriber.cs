using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    /// <summary>
    /// Класс, представляющий абонента с номером телефона, ИНН и адресом.
    /// </summary>
    public class Subscriber : IValidatable
    {
        /// <summary>
        /// Номер телефона абонента.
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// ИНН абонента.
        /// </summary>
        public string INN { get; set; } = string.Empty;

        /// <summary>
        /// Адрес абонента.
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Subscriber() { }

        /// <summary>
        /// Конструктор с параметрами для создания нового абонента.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона абонента.</param>
        /// <param name="inn">ИНН абонента.</param>
        /// <param name="address">Адрес абонента.</param>
        public Subscriber(string phoneNumber, string inn, string address)
        {
            PhoneNumber = phoneNumber;
            INN = inn;
            Address = address;
        }

        /// <summary>
        /// Свойство, проверяющее корректность данных абонента.
        /// </summary>
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrWhiteSpace(PhoneNumber) &&
                       !string.IsNullOrWhiteSpace(INN) &&
                       !string.IsNullOrWhiteSpace(Address);
            }
        }

        /// <summary>
        /// Переопределение метода ToString для представления информации об абоненте.
        /// </summary>
        /// <returns>Строка с данными абонента.</returns>
        public override string ToString()
        {
            return $"Subscriber: PhoneNumber = {PhoneNumber}, INN = {INN}, Address = {Address}";
        }
    }
}
