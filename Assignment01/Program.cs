/*
 * Student ID :1690702079
 * Name       :สุภนัย หัทยาภิชาติ
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Umamusume Pretty Derby";

            var UmaName = "T.M. Opera O";
            var UmaRank = 'S';
            var SkillSwingingMaestro = "Swinging Maestro";
            var SkillProfessorofcurvature = "Professor of curvature";
            int FriendShipLevel = 100;
            float SpeedBonus = 1.15f;
            double StaminaBonus = 3.5;
            bool isGOAT = true;

            double FriendShipLevelAsDouble = FriendShipLevel;
            int staminaTruncated = (int)StaminaBonus;
            int staminaRounded = Convert.ToInt32(StaminaBonus);

            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║          UMAMUSUME PRETTY DERBY              ║");
            Console.WriteLine("║                 ID CARD                      ║");
            Console.WriteLine("╠══════════════════════════════════════════════╣");
            Console.WriteLine($"║  Name       : {UmaName,-30} ║");
            Console.WriteLine($"║  Rank       : {UmaRank,-30} ║");
            Console.WriteLine($"║  Level      : {FriendShipLevel,-30} ║");
            Console.WriteLine($"║  Speed      : {SpeedBonus,-30} ║");
            Console.WriteLine($"║  Stamina    : {StaminaBonus,-30} ║");
            Console.WriteLine($"║  GOAT       : {isGOAT,-30} ║");
            Console.WriteLine("╠══════════════════════════════════════════════╣");
            Console.WriteLine($"║  Skill 1    : {SkillSwingingMaestro,-30} ║");
            Console.WriteLine($"║  Skill 2    : {SkillProfessorofcurvature,-30} ║");
            Console.WriteLine("╠══════════════════════════════════════════════╣");
            Console.WriteLine("║              TYPE CONVERSIONS                ║");
            Console.WriteLine("╠══════════════════════════════════════════════╣");
            Console.WriteLine($"║  Level → double (implicit): {FriendShipLevelAsDouble,-14}   ║");
            Console.WriteLine($"║  Stamina cast (truncates): {staminaTruncated,-15}   ║");
            Console.WriteLine($"║  Stamina Convert (rounds): {staminaRounded,-15}   ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
        }
    }
}