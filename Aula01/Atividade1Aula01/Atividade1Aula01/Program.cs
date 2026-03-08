namespace Atividade1Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double valor2 = double.Parse(Console.ReadLine());
            double media = (valor1 + (valor2 * 2)) / 3;
            Console.WriteLine($"Media Final: {media:F2}");

            if (media < 3)
            {
                Console.WriteLine("Você foi Reprovado!");
            }
            else if (media <= 5)
            {
                Console.WriteLine("Você está de RE");
            }
            else
            {
                Console.WriteLine("Você foi aprovado!");
            }
        }
    }
}
