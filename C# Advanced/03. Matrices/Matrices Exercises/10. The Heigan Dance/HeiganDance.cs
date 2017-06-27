namespace _10.The_Heigan_Dance
{
    using System;

    public class HeiganDance
    {
        private const int CloudDamage = 3500;
        private const int EruptionDamage = 6000;
        public static int PlayerHealth = 18500;
        public static double HeiganHealth = 3000000;
        public const int ChamberSize = 15;

        public static void Main()
        {
            var playerPos = new int[] {ChamberSize / 2, ChamberSize / 2};
            var playerPoints = PlayerHealth;
            var heiganPoints = HeiganHealth;
            var isHeiganDead = false;
            var isPlayerDead = false;
            var hasCloud = false;
            var deathCause = "";
            var damageToHeigan = double.Parse(Console.ReadLine());
            
            while (true)
            {         

                var spellTokens = Console.ReadLine()
                    .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

                var spell = spellTokens[0];
                var spellRow = int.Parse(spellTokens[1]);
                var spellCol = int.Parse(spellTokens[2]);

                heiganPoints -= damageToHeigan;
                isHeiganDead = heiganPoints <= 0;

                if (hasCloud)
                {
                    playerPoints -= CloudDamage;
                    hasCloud = false;
                    isPlayerDead = playerPoints <= 0;
                }
                if (isHeiganDead || isPlayerDead)
                {
                    break;
                }
                if (IsInDamageArea(playerPos, spellRow, spellCol))
                {
                    if (!PlayerTryToEscape(playerPos, spellRow, spellCol))
                    {
                        switch (spell)
                        {
                            case "Cloud":
                                playerPoints -= CloudDamage;
                                hasCloud = true;
                                deathCause = "Plague Cloud";
                                break;

                            case "Eruption":
                                playerPoints -= EruptionDamage;
                                deathCause = spell;
                                break;
                        }
                    }
                }
                isPlayerDead = playerPoints <= 0;
                if (isPlayerDead)
                {
                    break;
                }

            }

            PrintResult(playerPos, heiganPoints, playerPoints, deathCause);
        }

        private static void PrintResult(int[] playerPos, double heiganPoints, int playerPoints, string deathCause)
        {
            if (heiganPoints <= 0)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine("Heigan: {0:f2}", heiganPoints);
            }
            if (playerPoints <= 0)
            {
                Console.WriteLine($"Player: Killed by {deathCause}");
            }
            else
            {
                Console.WriteLine($"Player: {playerPoints}");
            }

            Console.WriteLine($"Final position: {playerPos[0]}, {playerPos[1]}");
        }

        private static bool PlayerTryToEscape(int[] playerPos, int spellRow, int spellCol)
        {
            if (playerPos[0] - 1 >= 0 && playerPos[0] - 1 < spellRow - 1)
            {
                playerPos[0]--;
                return true;
            }
            else if (playerPos[1] + 1 < ChamberSize && playerPos[1] + 1 > spellCol + 1)
            {
                playerPos[1]++;
                return true;
            }
            else if (playerPos[0] + 1 < ChamberSize && playerPos[0] + 1 > spellRow + 1)
            {
                playerPos[0]++;
                return true;
            }
            else if (playerPos[1] - 1 >= 0 && playerPos[1] - 1 < spellCol - 1)
            {
                playerPos[1]--;
                return true;
            }

            return false;
        }

        private static bool IsInDamageArea(int[] playerPos, int spellRow, int spellCol)
        {
            bool inHitRow = playerPos[0] >= spellRow - 1 && playerPos[0] <= spellRow + 1;
            bool inHitCol = playerPos[1] >= spellCol - 1 && playerPos[1] <= spellCol + 1;

            return inHitRow && inHitCol;
        }
    }
}
