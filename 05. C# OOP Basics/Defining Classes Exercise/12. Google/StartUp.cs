namespace _12.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (input != "End")
            {
                List<string> tokens = input
                    .Split(' ')
                    .ToList();

                if (tokens.Contains("company"))
                {
                    string personName = tokens[0];
                    string companyName = tokens[2];
                    string department = tokens[3];
                    double salary = double.Parse(tokens[4]);
                    Company company = new Company(companyName, department, salary);

                    if (people.Any(p => p.Name == personName))
                    {
                        people.Find(p => p.Name == personName).Company = company;
                    }
                    else
                    {
                        Person person = new Person(personName);
                        person.Company = company;
                        people.Add(person);
                    }
                }
                else if (tokens.Contains("pokemon"))
                {
                    string personName = tokens[0];
                    string pokemonName = tokens[2];
                    string type = tokens[3];
                    Pokemon pokemon = new Pokemon(pokemonName, type);

                    if (people.Any(p => p.Name == personName))
                    {
                        people.Find(p => p.Name == personName).Pokemons.Add(pokemon);
                    }
                    else
                    {
                        Person person = new Person(personName);
                        person.Pokemons.Add(pokemon);
                        people.Add(person);
                    }
                }
                else if (tokens.Contains("parents"))
                {
                    string personName = tokens[0];
                    string parentName = tokens[2];
                    string birthday = tokens[3];
                    Parent parent = new Parent(parentName, birthday);

                    if (people.Any(p => p.Name == personName))
                    {
                        people.Find(p => p.Name == personName).Parents.Add(parent);
                    }
                    else
                    {
                        Person person = new Person(personName);
                        person.Parents.Add(parent);
                        people.Add(person);
                    }
                }
                else if (tokens.Contains("children"))
                {
                    string personName = tokens[0];
                    string childName = tokens[2];
                    string birthday = tokens[3];
                    Child child = new Child(childName, birthday);

                    if (people.Any(p => p.Name == personName))
                    {
                        people.Find(p => p.Name == personName).Children.Add(child);
                    }
                    else
                    {
                        Person person = new Person(personName);
                        person.Children.Add(child);
                        people.Add(person);
                    }
                }
                else if (tokens.Contains("car"))
                {
                    string personName = tokens[0];
                    string model = tokens[2];
                    double speed = double.Parse(tokens[3]);
                    Car currCar = new Car(model, speed);

                    if (people.Any(p => p.Name == personName))
                    {
                        people.Find(p => p.Name == personName).Car = currCar;
                    }
                    else
                    {
                        Person person = new Person(personName);
                        person.Car = currCar;
                        people.Add(person);
                    }
                }

                input = Console.ReadLine();
            }

            string wantedName = Console.ReadLine();

            if (people.Any(p => p.Name == wantedName))
            {
                Person pesronNeeded = people.Find(p => p.Name == wantedName);

                Console.WriteLine(pesronNeeded.ToString().Trim());
            }      
        }
    }
}
