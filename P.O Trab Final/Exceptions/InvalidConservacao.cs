using System;

namespace PeixariaProject.Exceptions
{
    public class InvalidConservacao : Exception
    {
        public InvalidConservacao(string message) : base(message)
        {
        }
    }
}