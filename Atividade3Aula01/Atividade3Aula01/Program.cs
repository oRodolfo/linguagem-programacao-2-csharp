namespace Atividade3Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Digite a primeira nota do aluno {i}: ");
                double valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a segunda nota do aluno {i}: ");
                double valor2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"Informe a quantidade de presença do aluno {i}: ");
                int presenca = int.Parse(Console.ReadLine());

                double media = (valor1 + (valor2 * 2)) / 3;
                Console.WriteLine($"Media Final: {media:F2}");
                Console.WriteLine($"Quantidade de presença do {i}º aluno: {presenca}");

                if (presenca >= 75 && media >= 5)
                {
                    Console.WriteLine($"O {i}º aluno foi aprovado!");
                }
                else if (presenca >= 75 && media < 5)
                {
                    Console.WriteLine($"O {i}º aluno está de RE");
                }
                else
                {
                    Console.WriteLine($"O {i}º aluno está reprovado!");
                }
            }
        }
    }
}
