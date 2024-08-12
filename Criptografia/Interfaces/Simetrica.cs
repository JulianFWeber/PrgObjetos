using System;

namespace Criptografia.Interface
{
    public interface ICriptografia
    {
        string Criptografar(string plainText);
        string Descriptografar(string cipherText);
    }
}