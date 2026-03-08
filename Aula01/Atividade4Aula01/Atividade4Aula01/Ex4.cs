namespace Atividade4Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor que deseja sacar: R$");
            int valorSaque = int.Parse(Console.ReadLine());

            if (valorSaque == 1 || valorSaque == 3 || valorSaque <= 0)
            {
                Console.WriteLine("Valor indisponivel para saque com as cedulas disponiveis, tente novamente.");
            }
            else
            {
                int valorResto = valorSaque;

                int n100 = valorResto / 100;
                valorResto = valorResto % 100;

                int n50 = valorResto / 50;
                valorResto = valorResto % 50;

                int n20 = valorResto / 20;
                valorResto = valorResto % 20;

                int n10 = valorResto / 10;
                valorResto = valorResto % 10;

                int n5 = valorResto / 5;
                valorResto = valorResto % 5;

                int n2 = valorResto / 2;
                valorResto = valorResto % 2;

                if (valorResto != 0)
                {
                    Console.WriteLine("Não é possível sacar esse valor com as notas disponíveis.");
                }
                else
                {
                    Console.WriteLine("Notas entregues:");
                    if (n100 > 0) Console.WriteLine(n100 + " de R$ 100");
                    if (n50 > 0) Console.WriteLine(n50 + " de R$ 50");
                    if (n20 > 0) Console.WriteLine(n20 + " de R$ 20");
                    if (n10 > 0) Console.WriteLine(n10 + " de R$ 10");
                    if (n5 > 0) Console.WriteLine(n5 + " de R$ 5");
                    if (n2 > 0) Console.WriteLine(n2 + " de R$ 2");
                }
            }
        }
    }
}
