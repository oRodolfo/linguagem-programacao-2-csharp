using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02AtividadePratica
{
    internal class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }

        public Animal(int id, string nome, string tipo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Tipo = tipo;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Id: {Id} | Nome: {Nome} | Tipo: {Tipo}");
        }
    }
}
