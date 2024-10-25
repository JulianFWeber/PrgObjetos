using System;

namespace PeixariaProject.Exceptions
{
    public class InvalidPrice : Exception
    {
        public InvalidPrice(string message) : base(message)
        {
        }
    }
}