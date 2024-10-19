using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    /// <summary>
    /// Класс, представляющий город с тарифами на звонки.
    /// </summary>
    public class City : IValidatable
    {
        /// <summary>
        /// Название города.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Тариф на звонки в дневное время.
        /// </summary>
        public decimal DayRate { get; set; }

        /// <summary>
        /// Тариф на звонки в ночное время.
        /// </summary>
        public decimal NightRate { get; set; }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public City() { }

        /// <summary>
        /// Конструктор с параметрами для создания города с тарифами.
        /// </summary>
        /// <param name="name">Название города.</param>
        /// <param name="dayRate">Дневной тариф.</param>
        /// <param name="nightRate">Ночной тариф.</param>
        public City(string name, decimal dayRate, decimal nightRate)
        {
            Name = name;
            DayRate = dayRate;
            NightRate = nightRate;
        }

        /// <summary>
        /// Свойство, проверяющее корректность данных города.
        /// </summary>
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Name) &&
                       DayRate > 0 && NightRate > 0;
            }
        }

        /// <summary>
        /// Переопределение метода ToString для представления информации о городе.
        /// </summary>
        /// <returns>Строка с данными города.</returns>
        public override string ToString()
        {
            return $"City: Name = {Name}, DayRate = {DayRate}, NightRate = {NightRate}";
        }
    }
}
