using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    /// <summary>
    /// Класс, представляющий телефонный разговор.
    /// </summary>
    public class Call : IValidatable
    {
        /// <summary>
        /// Абонент, совершающий звонок.
        /// </summary>
        public Subscriber Subscriber { get; set; } = new Subscriber();

        /// <summary>
        /// Город, куда был совершен звонок.
        /// </summary>
        public City City { get; set; } = new City();

        /// <summary>
        /// Дата звонка.
        /// </summary>
        public DateTime CallDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Количество минут звонка.
        /// </summary>
        public int Minutes { get; set; } = 0;

        /// <summary>
        /// Время суток, когда был совершен звонок (день или ночь).
        /// </summary>
        public TimeOfDay TimeOfDay { get; set; } = TimeOfDay.Day;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Call() { }

        // Конструктор с параметрами
        public Call(Subscriber subscriber, City city, DateTime callDate, int minutes, TimeOfDay timeOfDay)
        {
            Subscriber = subscriber;
            City = city;
            CallDate = callDate;
            Minutes = minutes;
            TimeOfDay = timeOfDay;
        }

        /// <summary>
        /// Свойство, проверяющее корректность данных звонка.
        /// </summary>
        public bool IsValid
        {
            get
            {
                return Subscriber != null && Subscriber.IsValid &&
                       City != null && City.IsValid &&
                       Minutes > 0;
            }
        }

        // Метод для расчета стоимости переговоров
        public decimal CalculateCost()
        {
            if (TimeOfDay == TimeOfDay.Day)
            {
                return Minutes * City.DayRate;
            }
            else
            {
                return Minutes * City.NightRate;
            }
        }

        // Переопределение метода ToString()
        public override string ToString()
        {
            return $"Call: Minutes = {Minutes}, TimeOfDay = {TimeOfDay}";
        }
    }
}
