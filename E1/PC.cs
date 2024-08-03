using System;

namespace Herancas
{
    public class PC
    {
        // Atributos
        private string _cpu;
        private string _gpu;
        private int _ram;

        // Propriedades
        public string CPU
        {
            get { return _cpu; }
            set { _cpu = value; }
        }

        public string GPU
        {
            get { return _gpu; }
            set { _gpu = value; }
        }

        public int RAM
        {
            get { return _ram; }
            set { _ram = value; }
        }

        // Construtor
        public PC(string cpu, string gpu, int ram)
        {
            _cpu = cpu;
            _gpu = gpu;
            _ram = ram;
        }

        // Métodos
        public void VerificarGPU()
        {
            Console.WriteLine($"{_gpu} está funcionando perfeitamente.");
        }

        //Para demonstrar assinaturas
        public void MostrarEspecificacoes()
        {
            Console.WriteLine($"CPU: {_cpu}, GPU: {_gpu}, RAM: {_ram}GB");
        }

        public bool MostrarEspecificacoes(string detalhes)
        {
            if (detalhes == "detalhado")
            {
                Console.WriteLine($"Especificações detalhadas: CPU: {_cpu}, GPU: {_gpu}, RAM: {_ram}GB");
                return true;
            }
            return false;
        }

        // Sobrescrita de método
        public virtual void Ligar()
        {
            Console.WriteLine($"{_cpu} está ligando...");
        }

        // Classe filha (subclasse)
        public class Notebook : PC
        {
            private float _peso;

            public float Peso
            {
                get { return _peso; }
                set { _peso = value; }
            }

            // Construtor da subclasse
            public Notebook(string cpu, string gpu, int ram, float peso) : base(cpu, gpu, ram)
            {
                _peso = peso;
            }

            // Método específico do Notebook
            public void MostrarPeso()
            {
                Console.WriteLine($"Peso: {_peso} kg");
            }

            // Sobrescrita de método
            public override void Ligar()
            {
                Console.WriteLine($"{CPU} no Notebook está ligando...");
            }
        }
    }
}
