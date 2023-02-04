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
}