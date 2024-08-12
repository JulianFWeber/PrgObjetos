using System.Security.Cryptography;

public class RsaFileCriptografia
{
    private readonly RSACryptoServiceProvider _rsa;

    public RsaFileCriptografia()
    {
        _rsa = new RSACryptoServiceProvider(2048);
    }

    public string ExportPublicKey() => _rsa.ToXmlString(false);

    public string ExportPrivateKey() => _rsa.ToXmlString(true);

    public void ImportPublicKey(string publicKey) => _rsa.FromXmlString(publicKey);

    public void ImportPrivateKey(string privateKey) => _rsa.FromXmlString(privateKey);

    public byte[] EncryptData(byte[] data) => _rsa.Encrypt(data, false);

    public byte[] DecryptData(byte[] data) => _rsa.Decrypt(data, false);
}