using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBank
{
    /// <summary>
    /// Запрос к справочнику банков
    /// </summary>
    public class BankRequest
    {
        /// <summary>
        /// Тип запроса
        /// </summary>
        public BankRequestType Type { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Информация о банке
        /// </summary>
        public Bank Bank { get; set; }
    }
}
