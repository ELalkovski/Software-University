namespace _14.Cat_Lady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<SiameseCat> siamese = new List<SiameseCat>();
            List<CymricCat> cymrics = new List<CymricCat>();
            List<StreetExtraordinaireCat> streetExtraordinaires = new List<StreetExtraordinaireCat>();

            while (input != "End")
            {
                string[] catTokens = input.Split(' ');
                string type = catTokens[0];
                string name = catTokens[1];

                switch (type)
                {
                    case "Siamese":
                        int earSize = int.Parse(catTokens[2]);
                        SiameseCat currSiamese = new SiameseCat(name, type, earSize);
                        siamese.Add(currSiamese);

                        break;
                    case "Cymric":
                        double furLength = double.Parse(catTokens[2]);
                        CymricCat currCymric = new CymricCat(name, type, furLength);
                        cymrics.Add(currCymric);

                        break;
                    case "StreetExtraordinaire":
                        int decibels = int.Parse(catTokens[2]);
                        StreetExtraordinaireCat currStreetCat = new StreetExtraordinaireCat(name, type, decibels);
                        streetExtraordinaires.Add(currStreetCat);

                        break;
                }

                input = Console.ReadLine();
            }

            string catNeeded = Console.ReadLine();

            if (cymrics.Any(c => c.Name.Equals(catNeeded)))
            {
                CymricCat cymric = cymrics.First(c => c.Name.Equals(catNeeded));

                Console.WriteLine(cymric.ToString());
            }
            else if (siamese.Any(c => c.Name.Equals(catNeeded)))
            {
                SiameseCat currSiamese = siamese.First(c => c.Name.Equals(catNeeded));

                Console.WriteLine(siamese.ToString());
            }
            else if (streetExtraordinaires.Any(c => c.Name.Equals(catNeeded)))
            {
                StreetExtraordinaireCat currStreetCat = streetExtraordinaires.First(c => c.Name.Equals(catNeeded));

                Console.WriteLine(currStreetCat.ToString());
            }

        }
    }
}
