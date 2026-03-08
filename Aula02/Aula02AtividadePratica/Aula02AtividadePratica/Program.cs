namespace Aula02AtividadePratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5) Criando 5 animais
            Animal animal1 = new Animal(1, "Golfinho", "Marinho");
            Animal animal2 = new Animal(2, "Tubarão", "Marinho");
            Animal animal3 = new Animal(3, "Leão", "Terrestre");
            Animal animal4 = new Animal(4, "Elefante", "Terrestre");
            Animal animal5 = new Animal(5, "Lobo", "Terrestre");

            // 6) Criando 2 habitats
            Habitat habitatAquatico = new Habitat(1, "Oceano Azul", "Marinho");
            Habitat habitatTerrestre = new Habitat(2, "Floresta Viva", "Terrestre");

            // 7) Vincular ao habitat aquático os dois primeiros animais aquáticos
            habitatAquatico.AdicionarAnimal(animal1);
            habitatAquatico.AdicionarAnimal(animal2);

            // 8) Vincular ao habitat terrestre todos os animais terrestres
            habitatTerrestre.AdicionarAnimal(animal3);
            habitatTerrestre.AdicionarAnimal(animal4);
            habitatTerrestre.AdicionarAnimal(animal5);

            // 9) Criar mais uma referência para o habitat terrestre
            Habitat refHabitatTerrestre2 = habitatTerrestre;

            // 10) Criar mais duas referências para o primeiro animal aquático
            Animal refAnimalAquatico2 = animal1;
            Animal refAnimalAquatico3 = animal1;

            // 11) Alterar os dados do primeiro animal aquático a partir da última referência criada
            refAnimalAquatico3.Nome = "Golfinho-Rosa";
            refAnimalAquatico3.Tipo = "Marinho"; // mantive o tipo correto
            refAnimalAquatico3.Id = 101;

            // 12) Alterar os dados do primeiro animal terrestre
            // a partir da segunda referência criada para o habitat
            refHabitatTerrestre2.AnimaisAbrigados[0].Nome = "Leão Dourado";
            refHabitatTerrestre2.AnimaisAbrigados[0].Id = 303;
            refHabitatTerrestre2.AnimaisAbrigados[0].Tipo = "Terrestre";

            // Exibindo resultados
            Console.WriteLine("=== ANIMAIS INDIVIDUAIS ===");
            animal1.ExibirDados();
            animal2.ExibirDados();
            animal3.ExibirDados();
            animal4.ExibirDados();
            animal5.ExibirDados();

            Console.WriteLine("\n=== HABITATS ===");
            habitatAquatico.ExibirHabitat();
            habitatTerrestre.ExibirHabitat();

            Console.ReadLine();
        }
    }
}
