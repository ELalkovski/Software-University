using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Google
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var people = new List<Person>();

            while (input != "End")
            {
                var tokens = input.Split(' ').ToList();

                if (tokens.Contains("company"))
                {
                    var personName = tokens[0];
                    var companyName = tokens[2];
                    var department = tokens[3];
                    var salary = double.Parse(tokens[4]);

                    var company = new Company(companyName, department, salary);

                    if (people.Any(p => p.Name == personName))
                    {
                        people.Find(p => p.Name == personName).Company = company;
                    }
                    else
                    {
                        var person = new Person(personName);
                        person.Company = company;
                        people.Add(person);
                    }

                }
                else if (tokens.Contains("pokemon"))
                {
                    var personName = tokens[0];
                    var pokemonName = tokens[2];
                    var type = tokens[3];
                    var pokemon = new Pokemon(pokemonName, type);

                    if (people.Any(p => p.Name == personName))
                    {
                        people.Find(p => p.Name == personName).Pokemons.Add(pokemon);
                    }
                    else
                    {
                        var person = new Person(personName);
                        person.Pokemons.Add(pokemon);
                        people.Add(person);
                    }
                }
                else if (tokens.Contains("parents"))
                {
                    var personName = tokens[0];
                    var parentName = tokens[2];
                    var birthday = tokens[3];
                    var parent = new Parent(parentName, birthday);

                    if (people.Any(p => p.Name == personName))
                    {
                        people.Find(p => p.Name == personName).Parents.Add(parent);
                    }
                    else
                    {
                        var person = new Person(personName);
                        person.Parents.Add(parent);
                        people.Add(person);
                    }
                }
                else if (tokens.Contains("children"))
                {
                    var personName = tokens[0];
                    var childName = tokens[2];
                    var birthday = tokens[3];
                    var child = new Child(childName, birthday);

                    if (people.Any(p => p.Name == personName))
                    {
                        people.Find(p => p.Name == personName).Children.Add(child);
                    }
                    else
                    {
                        var person = new Person(personName);
                        person.Children.Add(child);
                        people.Add(person);
                    }
                }
                else if (tokens.Contains("car"))
                {
                    var personName = tokens[0];
                    var model = tokens[2];
                    var speed = double.Parse(tokens[3]);
                    var currCar = new Car(model, speed);

                    if (people.Any(p => p.Name == personName))
                    {
                        people.Find(p => p.Name == personName).Car = currCar;
                    }
                    else
                    {
                        var person = new Person(personName);
                        person.Car = currCar;
                        people.Add(person);
                    }
                }
                input = Console.ReadLine();
            }

            var wantedName = Console.ReadLine();

            if (people.Any(p => p.Name == wantedName))
            {
                Person pesronNeeded = people.Find(p => p.Name == wantedName);
                Console.WriteLine(pesronNeeded.ToString().Trim());
            }      
        }
    }
}
