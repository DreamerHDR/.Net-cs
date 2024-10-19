using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public static class Storage
    {
        /// <summary>
        /// Словарь городов, где ключ — название города.
        /// </summary>
        public static Dictionary<string, City> Cities { get; } = new Dictionary<string, City>();

        /// <summary>
        /// Словарь абонентов, где ключ — ИНН.
        /// </summary>
        public static Dictionary<string, Subscriber> Subscribers { get; } = new Dictionary<string, Subscriber>();

        /// <summary>
        /// Список звонков.
        /// </summary>
        public static List<Call> Calls { get; } = new List<Call>();
    }
}

