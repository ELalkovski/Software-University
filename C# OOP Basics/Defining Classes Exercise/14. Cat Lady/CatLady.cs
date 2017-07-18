using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.Cat_Lady
{
    public class CatLady
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var siamese = new List<SiameseCat>();
            var cymrics = new List<CymricCat>();
            var streetExtraordinaires = new List<StreetExtraordinaireCat>();


            while (input != "End")
            {
                var catTokens = input.Split(' ');
                var type = catTokens[0];
                var name = catTokens[1];

                switch (type)
                {
                    case "Siamese":
                        var earSize = int.Parse(catTokens[2]);
                        var currSiamese = new SiameseCat(name, type, earSize);
                        siamese.Add(currSiamese);
                        break;
                    case "Cymric":
                        var furLength = double.Parse(catTokens[2]);
                        var currCymric = new CymricCat(name, type, furLength);
                        cymrics.Add(currCymric);
                        break;
                    case "StreetExtraordinaire":
                        var decibels = int.Parse(catTokens[2]);
                        var currStreetCat = new StreetExtraordinaireCat(name, type, decibels);
                        streetExtraordinaires.Add(currStreetCat);
                        break;
                }

                input = Console.ReadLine();
            }

            var catNeeded = Console.ReadLine();

            if (cymrics.Any(c => c.Name.Equals(catNeeded)))
            {
                var cymric = cymrics.First(c => c.Name.Equals(catNeeded));
                Console.WriteLine(cymric.ToString());
            }
            else if (siamese.Any(c => c.Name.Equals(catNeeded)))
            {
                var currSiamese = siamese.First(c => c.Name.Equals(catNeeded));
                Console.WriteLine(siamese.ToString());
            }
            else if (streetExtraordinaires.Any(c => c.Name.Equals(catNeeded)))
            {
                var currStreetCat = streetExtraordinaires.First(c => c.Name.Equals(catNeeded));
                Console.WriteLine(currStreetCat.ToString());
            }

        }
    }
}
