namespace _12.Google
{
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Parent> parents;
        private List<Child> children;
        private List<Pokemon> pokemons;

        public Person(string name)
        {
            this.name = name;
            this.parents = new List<Parent>();
            this.children = new List<Child>();
            this.pokemons = new List<Pokemon>();
            this.company = new Company();
            this.car = new Car();
        }

        public string Name
        {
            get { return this.name; }
        }

        public Company Company
        {
            get { return this.company; }
            set { this.company = value; }
        }

        public Car Car
        {
            get { return this.car; }
            set { this.car = value; }
        }

        public List<Parent> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        public List<Child> Children
        {
            get { return this.children; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.name);
            sb.AppendLine("Company:");

            if (!string.IsNullOrEmpty(this.Company.CompanyName))
            {
                sb.AppendLine($"{this.Company.CompanyName} {this.Company.Department} {this.Company.Salary:f2}");
            }

            sb.AppendLine("Car:");

            if (!string.IsNullOrEmpty(this.Car.Model))
            {
                sb.AppendLine($"{this.Car.Model} {this.Car.Speed}");
            }

            sb.AppendLine("Pokemon:");

            foreach (var pokemon in this.Pokemons)
            {
                sb.AppendLine($"{pokemon.Name} {pokemon.Type}");
            }

            sb.AppendLine("Parents:");

            foreach (var parent in this.Parents)
            {
                sb.AppendLine($"{parent.Name} {parent.Birthday}");
            }

            sb.AppendLine("Children:");

            foreach (var child in this.Children)
            {
                sb.AppendLine($"{child.Name} {child.Birthday}");
            }

            return sb.ToString();
        }
    }
}
