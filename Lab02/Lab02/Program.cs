/*
 * Student ID :1690702079
 * Name       :สุภนัย หัทยาภิชาติ
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02

{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //Part A
                string bossName = "Kirin";
                char rank = 'S';
                int level = 7;
                int maxHp = 240;
                int currentHp = 175;
                float attackPower = 42.5f;
                double critMultiplier = 1.75;
                bool isBoss = true;

                Console.WriteLine("===== BOSS STATUS: INITIAL =====");
                Console.WriteLine($"Name: {bossName}");
                Console.WriteLine($"Rank: {rank}");
                Console.WriteLine($"Level: {level}");
                Console.WriteLine($"HP: {currentHp} / {maxHp}");
                Console.WriteLine($"Attack Power: {attackPower}");
                Console.WriteLine($"Crit Multiplier: {critMultiplier}");
                Console.WriteLine($"Is Boss: {isBoss}");
                Console.WriteLine();

                int hpPercent = currentHp * 10 / maxHp;
                Console.WriteLine($"HP Percent: {hpPercent}");
                Console.WriteLine();

                Console.WriteLine($"Kirin takes 60 damages!");
                currentHp = currentHp - 60;
                Console.WriteLine();

                Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
                Console.WriteLine($"HP: {currentHp} / {maxHp}");
                hpPercent = currentHp * 100 / maxHp;
                Console.WriteLine($"HP Percent: {hpPercent}%");
            }

            {
                //Part B
                string MCName = "TM Opera O";
                string Codename = "Centurial Overlord";
                char rank = 'Z';
                int level = 1000;
                int maxHp = 99999;
                int currentHp = 99990;
                float attackPower = 9999.9f;
                double critMultiplier = 99.99;
                bool isBoss = false;

                Console.WriteLine();
                Console.WriteLine("===== MC STATUS: INITIAL =====");
                Console.WriteLine($"Name: {MCName}");
                Console.WriteLine($"Codename: {Codename}");
                Console.WriteLine($"Rank: {rank}");
                Console.WriteLine($"Level: {level}");
                Console.WriteLine($"HP: {currentHp} / {maxHp}");
                Console.WriteLine($"Attack Power: {attackPower}");
                Console.WriteLine($"Crit Multiplier: {critMultiplier}");
                Console.WriteLine($"Is Boss: {isBoss}");
            }

            {
                string NPCName = "tazuna";
                char rank = 'S';
                int level = 67;
                int maxHp = 2000;
                int currentHp = 1150;
                float attackPower = 670.5f;
                double critMultiplier = 6.75;
                bool isBoss = false;

                Console.WriteLine();
                Console.WriteLine("===== NPC STATUS: INITIAL =====");
                Console.WriteLine($"Name: {NPCName}");
                Console.WriteLine($"Rank: {rank}");
                Console.WriteLine($"Level: {level}");
                Console.WriteLine($"HP: {currentHp} / {maxHp}");
                Console.WriteLine($"Attack Power: {attackPower}");
                Console.WriteLine($"Crit Multiplier: {critMultiplier}");
                Console.WriteLine($"Is Boss: {isBoss}");
            }

            {
                string MonsterName = "UMA";
                char rank = 'E';
                int level = 6;
                int maxHp = 20;
                int currentHp = 11;
                float attackPower = 6.7f;
                double critMultiplier = 1.75;

                Console.WriteLine();
                Console.WriteLine("===== MONSTER STATUS: INITIAL =====");
                Console.WriteLine($"Name: {MonsterName}");
                Console.WriteLine($"Rank: {rank}");
                Console.WriteLine($"Level: {level}");
                Console.WriteLine($"HP: {currentHp} / {maxHp}");
                Console.WriteLine($"Attack Power: {attackPower}");
                Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            }

            {
                string SidekickName = "Meisho Dotto";
                string Codename2 = "King of the Goats";
                char rank = 'Z';
                int level = 900;
                int maxHp = 90000;
                int currentHp = 59999;
                float attackPower = 6000.7f;
                double critMultiplier = 20.75;

                Console.WriteLine();
                Console.WriteLine("===== SIDEKICK STATUS: INITIAL =====");
                Console.WriteLine($"Name: {SidekickName}");
                Console.WriteLine($"Codename: {Codename2}");
                Console.WriteLine($"Rank: {rank}");
                Console.WriteLine($"Level: {level}");
                Console.WriteLine($"HP: {currentHp} / {maxHp}");
                Console.WriteLine($"Attack Power: {attackPower}");
                Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            }
        }
    }
}
