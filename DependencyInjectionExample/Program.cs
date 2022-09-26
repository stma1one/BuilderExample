using DependencyInjectionExample.Models;

public class Program
{
    private static void Main(string[] args)
    {
        var warrior1 = new Samurai() { Name = "Ish-Im-Otto" };
        var warrior2 = new Samurai() { Name = "Sak-Im-Kaki" };
        warrior1.Attack(warrior2);
        Console.WriteLine(warrior2.Vitallity);
    }
}