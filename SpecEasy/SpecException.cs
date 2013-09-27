using System;
using System.Runtime.Serialization;

namespace SpecEasy
{
    [Serializable]
    public class SpecException : Exception
    {
        protected SpecException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public SpecException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public SpecException(string message) : base(message)
        {
        }

        public SpecException()
        {
        }
    }
}
