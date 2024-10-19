using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Laba4.Exception
{
    [Serializable]
    public class InvalidSubscriberException : System.Exception
    {
        public InvalidSubscriberException()
        {
        }

        public InvalidSubscriberException(string message) : base(message)
        {
        }

        public InvalidSubscriberException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidSubscriberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}