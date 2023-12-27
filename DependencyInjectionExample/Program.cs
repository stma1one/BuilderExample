using DependencyInjectionExample.Models;

public class Program
{
    private static void Main(string[] args)
    {
        

        var warrior1 = new Samurai(new Sword() ){  Name = "Ish-Im-Otto" };
        var warrior2 = new Samurai(new Nunchako()) { Name = "Sak-Im-Kaki" };
        warrior1.Attack(warrior2);
        Console.WriteLine(warrior2.Vitallity);
    }
}