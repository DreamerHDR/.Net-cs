﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Laba4.Exception
{
    [Serializable]
    public class InvalidCallException : System.Exception
    {
        public InvalidCallException()
        {
        }

        public InvalidCallException(string message) : base(message)
        {
        }

        public InvalidCallException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidCallException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}