namespace Atividade5Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);

            int resposta = -1;
            int tentativas = 0;

            while (resposta != numeroAleatorio)
            {
                Console.Write("Informe um numero entre 1 e 100: ");
                resposta = int.Parse(Console.ReadLine());
                if (resposta > numeroAleatorio)
                {
                    Console.WriteLine("Informe um numero menor");
                }
                else if (resposta < numeroAleatorio)
                {
                    Console.WriteLine("Informe um numero maior");
                }
                tentativas++;
                if (resposta == numeroAleatorio)
                {
                    Console.WriteLine($"O numero secreto era: {numeroAleatorio}");
                    Console.WriteLine("Você acertou o numero do secreto!");
                    Console.WriteLine($"Você tentou {tentativas} vezes");
                    break;
                }
            }
        }
    }
}
