using System;
using System.Runtime.Serialization;

namespace SpecEasy
{
    [Serializable]
    public class InvalidTestConfigurationException : Exception
    {
        public InvalidTestConfigurationException()
        {
        }

        public InvalidTestConfigurationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidTestConfigurationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public InvalidTestConfigurationException(string message) : base(message)
        {
        }
    }
}
