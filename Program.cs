Character hero = new Character("Hero", 80, 22, 14, 38);
Character villain = new Character("Villain", 90, 21, 12, 40);

Console.WriteLine("{0} has challenged you to a fight!", villain.Name);
Thread.Sleep(2000);

            while (villain.Hp > 0 || hero.Hp > 0)
            {
                Console.WriteLine("Type an option from the menu: (attack, special)  ");
                string menu = Console.ReadLine();
                int villainSpecial = new Random().Next(0, 2);

                if (menu == "attack")
                {
                    hero.Attack(villain);
                }
                else if (menu == "special")
                {
                    hero.SpecialAttack(villain);
                }

                if (villain.Hp <= 0)
                {
                    Console.WriteLine("{0} has been defeated. Congratulations!", villain.Name);
                    break;
                }

                Thread.Sleep(2000);

                if (villainSpecial == 1)
                {
                    villain.SpecialAttack(hero);
                }
                else
                {
                    villain.Attack(hero);
                }

                if (hero.Hp <= 0)
                {
                    Console.WriteLine("{0} has been defeated. Game over!", hero.Name);
                    break;
                }
            }

class Character
{
    // Character Atributes
    public string? name { get; set; }
    public int hp { get; set; }
    public int attackPoints { get; set; }
    public int defensePoints { get; set; }
    public int specialPoints { get; set; }

    public Character(string name, int hp, int attackPoints, int defensePoints, int specialPoints)
    {
        this.name = name;
        this.hp = hp;
        this.attackPoints = attackPoints;
        this.defensePoints = defensePoints;
        this.specialPoints = specialPoints;
    }

    public void attack(Character opponent)
    {
        Random random = new Random();
        int miss = random.Next(0, 6);
        if (miss == 0)
        {
            Console.WriteLine($"{name}'s attack missed");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }
        else if (attackPoints > opponent.defensePoints)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"{name} attacked {opponent.name}.");
            opponent.hp = opponent.hp + opponent.defensePoints - attackPoints;
            Console.WriteLine($"{opponent.name} has {opponent.hp} HP left.");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public void specialAttack(Character opponent)
    {
        Random random = new Random();
        int miss = random.Next(0, 1);
        if (miss == 0)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"{name}'s special attack missed");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }
        else if (specialPoints > opponent.defensePoints)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"{name} attacked {opponent.name} with special.");
            opponent.hp = opponent.hp + opponent.defensePoints - specialPoints;
            Console.WriteLine($"{opponent.name} has {opponent.hp} HP left.");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
