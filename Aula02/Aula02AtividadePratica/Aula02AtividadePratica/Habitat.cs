using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02AtividadePratica
{
    internal class Habitat
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }

        private List<Animal> animaisAbrigados;
        public const int CapacidadeMaxima = 5;

        public Habitat(int id, string nome, string tipo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Tipo = tipo;
            animaisAbrigados = new List<Animal>();
        }

        public bool AdicionarAnimal(Animal animal)
        {
            if (animaisAbrigados.Count >= CapacidadeMaxima)
            {
                Console.WriteLine($"Erro: O habitat {Nome} está lotado.");
                return false;
            }

            if (animal.Tipo != this.Tipo)
            {
                Console.WriteLine($"Erro: O animal {animal.Nome} ({animal.Tipo}) não pode habitar um ambiente {this.Tipo}.");
                return false;
            }

            animaisAbrigados.Add(animal);
            Console.WriteLine($"Animal {animal.Nome} adicionado ao habitat {Nome}.");
            return true;
        }

        public void ExibirHabitat()
        {
            Console.WriteLine($"\nHabitat: {Nome} | Tipo: {Tipo}");
            Console.WriteLine("Animais abrigados:");

            if (animaisAbrigados.Count == 0)
            {
                Console.WriteLine("Nenhum animal cadastrado.");
            }
            else
            {
                foreach (Animal animal in animaisAbrigados)
                {
                    animal.ExibirDados();
                }
            }
        }

        public List<Animal> AnimaisAbrigados
        {
            get { return animaisAbrigados; }
        }
    }
}