namespace WizardNinjaSamurai;
public class Wizard : Human
{
    public Wizard(string name) : base(name)
    {
        Intelligence = 25;
        Health = 50;
    }
 public override int Attack(Human target)
    {
        int dmg = Intelligence * 5;
        target.Health -= dmg;
        Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        Console.WriteLine($"{Name} healed for {dmg}, {Name} new health: {Health}");
        return target.Health;
    }
    public int Heal(Human target)
    {
        int hp = Intelligence * 10;
        target.Health += hp;
        Console.WriteLine($"{Name} healed {target.Name} for {hp} new health: {target.Health}");
        return target.Health;
    }
}