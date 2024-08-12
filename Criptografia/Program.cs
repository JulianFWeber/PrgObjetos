using System.Text;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Criptografar texto");
            Console.WriteLine("2. Descriptografar texto");
            Console.WriteLine("3. Criptografar arquivo");
            Console.WriteLine("4. Descriptografar arquivo");
            Console.WriteLine("5. Sair");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o texto para criptografar: ");
                    string textoParaCriptografar = Console.ReadLine() ?? string.Empty;
                    string textoCriptografado = Criptografar(textoParaCriptografar);
                    Console.WriteLine($"Texto criptografado: {textoCriptografado}");
                    break;

                case "2":
                    Console.Write("Digite o texto para descriptografar: ");
                    string textoParaDescriptografar = Console.ReadLine() ?? string.Empty;
                    string textoDescriptografado = Descriptografar(textoParaDescriptografar);
                    Console.WriteLine($"Texto descriptografado: {textoDescriptografado}");
                    break;

                case "3":
                    Console.Write("Digite o caminho do arquivo para criptografar: ");
                    string caminhoArquivoCripto = Console.ReadLine() ?? string.Empty;
                    string conteudoArquivo = File.ReadAllText(caminhoArquivoCripto);
                    string arquivoCriptografado = Criptografar(conteudoArquivo);
                    Console.WriteLine($"Conteúdo do arquivo criptografado: {arquivoCriptografado}");
                    break;

                case "4":
                    Console.Write("Digite o caminho do arquivo para descriptografar: ");
                    string caminhoArquivoDescripto = Console.ReadLine() ?? string.Empty;
                    string conteudoArquivoDescripto = File.ReadAllText(caminhoArquivoDescripto);
                    string arquivoDescriptografado = Descriptografar(conteudoArquivoDescripto);
                    Console.WriteLine($"Conteúdo do arquivo descriptografado: {arquivoDescriptografado}");
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static string Criptografar(string texto)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(texto);
        return Convert.ToBase64String(bytes);
    }

    static string Descriptografar(string textoCriptografado)
    {
        byte[] bytes = Convert.FromBase64String(textoCriptografado);
        return Encoding.UTF8.GetString(bytes);
    }
}
