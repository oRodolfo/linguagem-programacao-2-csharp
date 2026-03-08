using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02Exemplo01
{
    internal class Pessoa
    {
        public String Nome { get; set; }

        public int Idade { get; set; }

        public double Altura { get; set; }

        public double Peso { get; set; }

        public Pessoa(string nome, int idade, double altura, double peso)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Altura = altura;
            this.Peso = peso;
        }

        public void andar()
        {
            Console.WriteLine(this.Nome + " está andando!");
        }

        public void apresentar()
        {
            Console.WriteLine("\n--- DADOS DA PESSOA ---");
            Console.WriteLine($"NOME:   {this.Nome}");
            Console.WriteLine($"IDADE:  {this.Idade}");
            Console.WriteLine($"ALTURA: {this.Altura}");
            Console.WriteLine($"PESO:   {this.Peso}");
            Console.WriteLine("-----------------------");
        }
    }
}