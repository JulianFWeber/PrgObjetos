using System;
using Herancas;

class Program
{
    static void Main(string[] args)
    {
        var pc = new PC("AMD Ryzen 5 7600x", "RX 6600XT", 32);
        PC.Notebook meuNotebook = new PC.Notebook("Intel i5", "NVIDIA GTX 1050", 8, 4.4f);

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nSelecione uma opção:");
            Console.WriteLine("1. Verificar GPU do PC");
            Console.WriteLine("2. Mostrar especificações do PC");
            Console.WriteLine("3. Mostrar especificações detalhadas do PC");
            Console.WriteLine("4. Ligar o PC");
            Console.WriteLine("5. Verificar GPU do Notebook");
            Console.WriteLine("6. Mostrar especificações do Notebook");
            Console.WriteLine("7. Mostrar especificações detalhadas do Notebook");
            Console.WriteLine("8. Ligar o Notebook");
            Console.WriteLine("9. Mostrar peso do Notebook");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    pc.VerificarGPU();
                    break;
                case 2:
                    pc.MostrarEspecificacoes();
                    break;
                case 3:
                    pc.MostrarEspecificacoes("detalhado");
                    break;
                case 4:
                    pc.Ligar();
                    break;
                case 5:
                    meuNotebook.VerificarGPU();
                    break;
                case 6:
                    meuNotebook.MostrarEspecificacoes();
                    break;
                case 7:
                    meuNotebook.MostrarEspecificacoes("detalhado");
                    break;
                case 8:
                    meuNotebook.Ligar();
                    break;
                case 9:
                    meuNotebook.MostrarPeso();
                    break;
                case 0:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }
    }
}

