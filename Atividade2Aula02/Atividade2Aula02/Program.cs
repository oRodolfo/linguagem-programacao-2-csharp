namespace Atividade2Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de presença do aluno: ");
            int presenca = int.Parse(Console.ReadLine());

            double media = (valor1 + (valor2 * 2)) / 3;
            Console.WriteLine($"Media Final: {media:F2}");
            Console.WriteLine($"Quantidade de presença do aluno: {presenca}");

            if (presenca >= 75 && media >= 5)
            {
                Console.WriteLine("O aluno foi aprovado!");
            }
            else if (presenca >= 75 && media < 5)
            {
                Console.WriteLine("O aluno está de RE");
            }
            else
            {
                Console.WriteLine("O aluno está reprovado!");
            }
        }
    }
}
