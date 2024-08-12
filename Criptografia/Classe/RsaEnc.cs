using Criptografia.Interface;
using System;
using System.Security.Cryptography;
using System.Text;

public class RsaCriptografia : ICriptografia
{
    private readonly RSA _rsa;

    public RsaCriptografia()
    {
        _rsa = RSA.Create();
    }

    public string Criptografar(string plainText)
    {
        byte[] dataToEncrypt = Encoding.UTF8.GetBytes(plainText);
        byte[] encryptedData = _rsa.Encrypt(dataToEncrypt, RSAEncryptionPadding.Pkcs1);
        return Convert.ToBase64String(encryptedData);
    }

    public string Descriptografar(string cipherText)
    {
        byte[] dataToDecrypt = Convert.FromBase64String(cipherText);
        byte[] decryptedData = _rsa.Decrypt(dataToDecrypt, RSAEncryptionPadding.Pkcs1);
        return Encoding.UTF8.GetString(decryptedData);
    }

    public string ExportPublicKey()
    {
        return _rsa.ToXmlString(false);
    }

    public string ExportPrivateKey()
    {
        return _rsa.ToXmlString(true);
    }

    public void ImportPublicKey(string publicKey)
    {
        _rsa.FromXmlString(publicKey);
    }

    public void ImportPrivateKey(string privateKey)
    {
        _rsa.FromXmlString(privateKey);
    }
}