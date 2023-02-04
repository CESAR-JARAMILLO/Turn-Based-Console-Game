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
}