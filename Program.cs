using WizardNinjaSamurai;
Wizard myWizard = new Wizard("Greg");
Console.WriteLine($"Wizard name is {myWizard.Name} Stats: {myWizard.Health} Hp,  {myWizard.Intelligence} Int");
Human myHuman = new Human("Mr T");
Wizard myWizard1 = new Wizard("JERICHO");
Human myHuman1 = new Human("");

myWizard.Attack(myHuman); 
myWizard.Heal(myHuman);

// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("What is your name?");
//             var name = Console.ReadLine();
//             var currentDate = DateTime.Now;
//             Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
//             Console.Write($"{Environment.NewLine}Press any key to exit...");
//             Console.ReadKey(true);
//         }
//     }
// }
