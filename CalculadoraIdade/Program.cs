using System;

namespace CalculadoraIdade
{
    struct Pessoa
    {
        public string Nome;
        public DateTime DataNascimento;

        public int CalcularIdade()
        {
            DateTime hoje = DateTime.Now;
            int idade = hoje.Year - DataNascimento.Year;

            if (hoje.Month < DataNascimento.Month || (hoje.Month == DataNascimento.Month && hoje.Day < DataNascimento.Day))
            {
                idade--; 
            }

            return idade;
        }

        public bool MaiorDeIdade()
        {
            return CalcularIdade() >= 18;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de idade");

            Pessoa pessoa = new Pessoa();

            Console.Write("Digite seu nome: ");
            pessoa.Nome = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(pessoa.Nome) || !pessoa.Nome.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                Console.WriteLine("Nome inválido! Digite apenas letras e espaços.");
                Console.Write("Digite seu nome novamente: ");
                pessoa.Nome = Console.ReadLine();
            }



            DateTime dataNascimento;
            Console.Write("Digite sua data de nascimento (DD/MM/AAAA): ");

            while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
            {
                Console.WriteLine("Formato de data inválido! Por favor, use o formato DD/MM/AAAA.");
                Console.Write("Digite sua data de nascimento novamente: ");
            }

            pessoa.DataNascimento = dataNascimento;

            int idade = pessoa.CalcularIdade();
            Console.WriteLine($"Olá {pessoa.Nome}, você tem {idade} anos.");
            if (!pessoa.MaiorDeIdade())
            {
                Console.WriteLine("Você é menor de idade e não pode tirar a CNH.");
                return;
            }

            Console.WriteLine("Você é maior de idade e pode tirar a CNH.");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}