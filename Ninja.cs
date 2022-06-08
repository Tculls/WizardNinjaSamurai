namespace WizardNinjaSamurai;

public class Ninja : Human
{
    public Ninja(string name) : base (name)
    {
        Dexterity = 175;
    }
    public override int Attack(Human target)
    {
        Random Rand = new Random();
        int dmg = 0;
        int Crit = Rand.Next(0,100); 
        
        if (Crit <= 20) {
            dmg = 10 + (5 * Dexterity);
        }
        else
        {
            dmg = Dexterity * 5;
        }
        target.Health -= dmg;
        Console.WriteLine($"{Name} has attacked {target.Name} for {dmg} damage");
        return target.Health;
    }
    public int Steal(Human target)
    {
        target.Health -= 5;
        Health +=5;
        Console.WriteLine("${Name} did dojo steal hp from {target.Name}");
        return target.Health;
    }
}