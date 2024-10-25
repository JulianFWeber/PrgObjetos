using System;

namespace PeixariaProject.Exceptions
{
    public class InvalidQtyVenda : Exception
    {
        public InvalidQtyVenda(string message) : base(message)
        {
        }
    }
}