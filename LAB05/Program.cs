/*
 * Student ID :1690702079
 * Name       :สุภนัย หัทยาภิชาติ
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */

 namespace LAB05;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== >> GAME TITILE << ===");
        Console.WriteLine("Hero VS. Monster -- Calculate Damage");

        //Hero
        Console.Write("Hero HP: ");
        bool heroHpOK = int.TryParse(Console.ReadLine(), out int heroHp);
        Console.Write("Hero Attack: ");
        bool heroAtkOK = int.TryParse(Console.ReadLine(), out int heroAtk);
        Console.Write("Hero Defense: ");
        bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

        //Monster
        Console.Write("Monster HP: ");
        bool monHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
        Console.Write("Monster Attack: ");
        bool monAtkOk = int.TryParse(Console.ReadLine(), out int monsterAttack);
        Console.Write("Monster Defense: ");
        bool monDefOk = int.TryParse(Console.ReadLine(), out int monsterDefense);

        //check for valid input
        bool heroInputValid = heroHpOK && heroDefOk && heroAtkOK;
        bool monsterInputValid = monHpOk && monAtkOk && monDefOk;
        Console.WriteLine($">> Hero Status Valid: {heroInputValid}");
        Console.WriteLine($">> Monster Status Valid: {monsterInputValid}");
        Console.WriteLine($"[Hero]    HP:{heroHp} ATK:{heroAtk} DEF:{heroDef}");
        Console.WriteLine($"[Monster] HP:{monsterHp} ATK:{monsterAttack} DEF:{monsterDefense}");

        int potionheal = 14;
        heroHp += potionheal;
        Console.WriteLine($"\nHero drink potion heal {potionheal} HP, Hero Hp is: {heroHp}");

        int normalDamage = Math.Max(0, (heroAtk - monsterDefense ));
        Console.WriteLine($"Normal attack damange: {normalDamage} DMG");

        int powerDamage = Math.Max(0, (heroAtk * 2) - monsterDefense);
        Console.WriteLine($"Power attack damage: {powerDamage} DMG");

        int counterDamage = Math.Max(0, (monsterAttack - monsterDefense) / 2);
        Console.WriteLine($"Counter attack deals: {counterDamage} DMG");

        Random randomSomething = new Random();
        int roll = randomSomething.Next(1,101);
        bool isCrit = roll <= 10;
        int critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage;
        Console.WriteLine($"Crit Damage roll: {roll} (Crit?: {isCrit})");
        Console.WriteLine($"If critical, normal attack would deal: {critDamage} DMG");
    }
}