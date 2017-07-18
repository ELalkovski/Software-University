using System;
using System.Collections.Generic;

namespace _06.Animals
{
    public class StartUp
    {
        public static void Main()
        {
            var animalType = Console.ReadLine();
            var animals = new List<Animal>();

            while (animalType != "Beast!")
            {
                try
                {
                    var animalInfo = Console.ReadLine()
                        .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

                    var name = animalInfo[0];
                    var age = int.Parse(animalInfo[1]);
                    var gender = animalInfo[2];
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
