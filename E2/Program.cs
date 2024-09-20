using E2.Classes;
using E2.Interfaces;
using System;

namespace E2
{
    class Program
    {
        static List<IPessoa> clientes = new List<IPessoa>();

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Criar novo cliente");
                Console.WriteLine("2. Criar veículo");
                Console.WriteLine("3. Exibir clientes");
                Console.WriteLine("3. Consultar Veiculos");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CriarCliente();
                        break;
                    case "2":
                        CriarVeiculo();
                        break;
                    case "3":
                        ConsultarClientes();
                        break;
                    case "4":
                        ConsultarVeiculos();
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        private static void CriarCliente()
        {
            Console.WriteLine("Criar Novo Cliente");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite 1 para Pessoa Física ou 2 para Pessoa Jurídica: ");
            var tipo = Console.ReadLine();

            IPessoa cliente;

            if (tipo == "1")
            {
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();

                Console.Write("Sexo: ");
                string sexo = Console.ReadLine();

                cliente = new PessoaFisica(nome, cpf, sexo);
            }
            else if (tipo == "2")
            {
                Console.Write("CNPJ: ");
                string cnpj = Console.ReadLine();

                Console.Write("Atividade da Empresa: ");
                string atividade = Console.ReadLine();

                cliente = new PessoaJuridica(nome, cnpj, atividade);
            }
            else
            {
                Console.WriteLine("Tipo inválido.");
                return;
            }

            cliente.ExibirInformacoes();
            clientes.Add(cliente);

            Console.WriteLine("Cliente adicionado com sucesso!");
        }

        private static List<IAutomovel> veiculos = new List<IAutomovel>(); // Lista para armazenar os veículos

        private static void CriarVeiculo()
        {
            Console.WriteLine("Criar Novo Veículo");

            Console.Write("Digite o modelo do carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Digite o valor do carro: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Digite o ano do carro: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Digite a placa do carro: ");
            string placa = Console.ReadLine();

            Console.Write("Digite o tipo de combustível (Gasolina, Diesel, etc.): ");
            string tipoCombustivelNome = Console.ReadLine();

            Console.Write("Digite o preço do combustível: ");
            double precoCombustivel = double.Parse(Console.ReadLine());

            var combustivel = new Combustivel(tipoCombustivelNome, precoCombustivel);
            var novoCarro = new Carro(modelo, valor, ano, placa, combustivel);

            veiculos.Add(novoCarro);

            Console.WriteLine("Veículo criado com sucesso!");
        }
        private static void ConsultarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
            }
            else
            {
                foreach (var veiculo in veiculos)
                {
                    veiculo.ExibirInformacoes();
                    Console.WriteLine("------------------------------");
                }
            }
        }

        private static void ConsultarClientes()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }
            else
            {
                Console.WriteLine("Clientes cadastrados:");
                foreach (var cliente in clientes)
                {
                    cliente.ExibirInformacoes();
                }
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}
