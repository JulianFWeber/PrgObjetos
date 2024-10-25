using System;

namespace PeixariaProject.Exceptions
{
    public class InvalidQty : Exception
    {
        public InvalidQty(string message) : base(message)
        {
        }
    }
}