using System;
using System.Runtime.Serialization;

namespace Ej50Interfaces
{
    [Serializable]
    internal class ErrorArchivoException : Exception
    {
        public ErrorArchivoException()
        {
        }

        public ErrorArchivoException(string message) : base(message)
        {
        }

        public ErrorArchivoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ErrorArchivoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}