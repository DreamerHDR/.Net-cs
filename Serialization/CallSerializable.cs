using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4.Serialization
{
    [Serializable]
    public class CallSerializable
    {
        public string CityId { get; set; }
        public string SubscriberId { get; set; }
        /// <summary>
        /// Дата звонка
        /// </summary>
        public DateTime CallDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Продолжительность звонка в минутах
        /// </summary>
        public int Minutes { get; set; }
        /// <summary>
        /// Время звонка (день или ночь)
        /// </summary>
        public string TimeOfDay { get; set; }
    }
}
