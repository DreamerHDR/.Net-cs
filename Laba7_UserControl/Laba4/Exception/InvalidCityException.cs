using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Laba4.Exception
{
    [Serializable]
    public class InvalidCityException : System.Exception
    {
        public InvalidCityException()
        {
        }

        public InvalidCityException(string message) : base(message)
        {
        }

        public InvalidCityException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidCityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
