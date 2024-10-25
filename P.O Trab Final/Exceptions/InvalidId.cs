using System;

namespace PeixariaProject.Exceptions
{
    public class InvalidId : Exception
    {
        public InvalidId(string message) : base(message)
        {
        }
    }
}