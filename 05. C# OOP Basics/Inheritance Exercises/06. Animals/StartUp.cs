namespace _06.Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string animalType = Console.ReadLine();
            List<Animal> animals = new List<Animal>();

            while (animalType != "Beast!")
            {
                try
                {
                    string[] animalInfo = Console.ReadLine()
                        .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

                    string name = animalInfo[0];
                    int age = int.Parse(animalInfo[1]);
                    string gender = animalInfo[2];
                    Animal currAnimal;

                    switch (animalType)
                    {
                        case "Cat":
                            currAnimal = new Cat(name, age, gender);
                            animals.Add(currAnimal);
                            break;
                        case "Kitten":
                             currAnimal = new Kitten(name, age, gender);
                            animals.Add(currAnimal);
                            break;
                        case "Tomcat":
                            currAnimal = new Tomcat(name, age, gender);
                            animals.Add(currAnimal);
                            break;
                        case "Dog":
                            currAnimal = new Dog(name, age, gender);
                            animals.Add(currAnimal);
                            break;
                        case "Frog":
                            currAnimal = new Frog(name, age, gender);
                            animals.Add(currAnimal);
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                animalType = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
