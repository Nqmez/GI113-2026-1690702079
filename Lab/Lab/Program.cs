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

            //Part B
            string MCName = "TM Opera O";
            string Codename = "Centurial Overlord";
            char rank2 = 'Z';
            int level2 = 1000;
            int maxHp2 = 99999;
            int currentHp2 = 99990;
            float attackPower2 = 9999.9f;
            double critMultiplier2 = 99.99;
            bool isBoss2 = false;

            Console.WriteLine();
            Console.WriteLine("===== MC STATUS: INITIAL =====");
            Console.WriteLine($"Name: {MCName}");
            Console.WriteLine($"Codename: {Codename}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"Level: {level2}");
            Console.WriteLine($"HP: {currentHp2} / {maxHp2}");
            Console.WriteLine($"Attack Power: {attackPower2}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier2}");
            Console.WriteLine($"Is Boss: {isBoss2}");

            string NPCName = "tazuna";
            char rank1 = 'S';
            int level1 = 67;
            int maxHp1 = 2000;
            int currentHp1 = 1150;
            float attackPower1 = 670.5f;
            double critMultiplier1 = 6.75;
            bool isBoss1 = false;

            Console.WriteLine();
            Console.WriteLine("===== NPC STATUS: INITIAL =====");   
            Console.WriteLine($"Name: {NPCName}");
            Console.WriteLine($"Rank: {rank1}");    
            Console.WriteLine($"HP: {currentHp1} / {maxHp1}");
            Console.WriteLine($"Attack Power: {attackPower1}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier1}");
            Console.WriteLine($"Is Boss: {isBoss1}");

            string MonsterName = "UMA";
            char rank3 = 'E';
            int level3 = 6;
            int maxHp3 = 20;
            int currentHp3 = 11;
            float attackPower3 = 6.7f;
            double critMultiplier3 = 1.75;

            Console.WriteLine();
            Console.WriteLine("===== MONSTER STATUS: INITIAL =====");
            Console.WriteLine($"Name: {MonsterName}");
            Console.WriteLine($"Rank: {rank3}");
            Console.WriteLine($"Level: {level3}");
            Console.WriteLine($"HP: {currentHp3} / {maxHp3}");
            Console.WriteLine($"Attack Power: {attackPower3}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier3}");

            string SidekickName = "Meisho Dotto";
            string Codename2 = "King of the Goats";
            char rank4 = 'Z';
            int level4 = 900;
            int maxHp4 = 90000;
            int currentHp4 = 59999;
            float attackPower4 = 6000.7f;
            double critMultiplier4 = 20.75;
            
            Console.WriteLine();
            Console.WriteLine("===== SIDEKICK STATUS: INITIAL =====");
            Console.WriteLine($"Name: {SidekickName}");
            Console.WriteLine($"Codename: {Codename2}");
            Console.WriteLine($"Rank: {rank4}");
            Console.WriteLine($"Level: {level4}");
            Console.WriteLine($"HP: {currentHp4} / {maxHp4}");
            Console.WriteLine($"Attack Power: {attackPower4}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier4}");

        }
    }
}
