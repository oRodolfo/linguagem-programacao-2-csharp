using Aula02Exemplo01;

namespace Aula02Exmplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Pessoa> pessoas = new List<Pessoa>();
            int opcao = 0;
            while (opcao != 3)
            {
                Console.Clear();
                Console.WriteLine("====== SISTEMA DE CADASTRO =====");
                Console.WriteLine("1 - Cadastrar Pessoas");
                Console.WriteLine("2 - Listar pessoas");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("=================================");
                Console.WriteLine("Escolha uma opcao: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o seu nome: ");
                        String nome = Console.ReadLine();

                        Console.WriteLine("Informe a sua idade: ");
                        int idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a sua altura: ");
                        double altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite seu peso: ");
                        double peso = double.Parse(Console.ReadLine());

                        Pessoa p1 = new Pessoa(nome, idade, altura, peso);
                        pessoas.Add(p1);
                        p1.apresentar();

                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("===== LISTA DE PESSOAS =====");
                        if (pessoas.Count == 0)
                        {
                            Console.WriteLine("Nenhuma pessoa cadastrada!");
                        }
                        else
                        {
                            foreach (Pessoa pessoa in pessoas)
                            {
                                pessoa.apresentar();
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Encerrando Sistema");
                        break;
                }
            }

        }
    }
}