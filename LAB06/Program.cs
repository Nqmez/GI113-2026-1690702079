/*
 * Student ID :1690702079
 * Name       :สุภนัย หัทยาภิชาติ
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var GameTitle = "Umamusume Pretty Derby Duel";
            string Uma = "T.M. Opera O";
            string Rival = "Meisho Doto";
            float CriticalMultiplier = 1.5f;
            int UmaHp = 150;
            int UmaMaxHp = 200;
            int AttackPower = 80;
            int RivalHp = 100;
            int PotionHeal = 50;

            Console.WriteLine($"[[--{GameTitle}--]]");
            Console.WriteLine($"{Uma} HP: {UmaHp}/{UmaMaxHp} | ATK: {AttackPower} | {Rival} HP: {RivalHp}");
            Console.WriteLine("=============================");
            Console.WriteLine("1: ATTACK");
            Console.WriteLine("2: USE POTION");
            Console.WriteLine("3: RUN");
            Console.WriteLine("=============================");
            Console.Write("CHOOSE YOUR ACTION (1 - 3): ");
            bool isInputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (isInputValid == false || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid Input, Enter between 1 - 3.");
            }
            else if (choice == 1)
            {
                Random random = new Random();
                int roll = random.Next(1, 50);
                bool isCritical = roll <= 10;
                int damage = AttackPower;
                if (isCritical)
                {
                    damage = (int)(AttackPower * CriticalMultiplier);
                    Console.WriteLine($"Critical Hit! {Uma} deals {damage} damage to {Rival}.");
                    RivalHp -= damage;
                    RivalHp = Math.Max(RivalHp, 0);
                    Console.WriteLine($"{Rival}'s HP is now {RivalHp}.");
                    Console.WriteLine($"{Rival} is no longer able to continue!");
                    Console.WriteLine($"{Uma} wins the duel!");
                }
                else
                {
                    Console.WriteLine($"{Uma} attacks {Rival} and deals {damage} damage.");
                    RivalHp -= damage;
                    RivalHp = Math.Max(RivalHp, 0);
                    Console.WriteLine($"{Rival}'s HP is now {RivalHp}.");
                }
            }
            else if (choice == 2)
            {
                UmaHp = Math.Min(UmaHp + PotionHeal, UmaMaxHp);
                Console.WriteLine($"{Uma} used a potion! HP is now {UmaHp}.");
            }
            else
            {
                Console.WriteLine($"{Uma} ran away from {Rival}.");
                Console.WriteLine($"{Uma} Gets away safely.");
            }
        }
    }
}