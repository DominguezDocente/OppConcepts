﻿using System.Runtime.Serialization;

namespace OppConcepts
{
    [Serializable]
    internal class InvalidDateException : Exception
    {
        public InvalidDateException()
        {
        }

        public InvalidDateException(string? message) : base(message)
        {
        }

        public InvalidDateException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidDateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}