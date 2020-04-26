using System;
using System.Linq;
using Samurai.App.Data;
using Samurai.App.Domain;
namespace SamuraiApp
{
    class Program
    {
        private static SamuraiContext context = new SamuraiContext();
        static void Main(string[] args)
        {
            Console.WriteLine("There you go for the result!");
            context.Database.EnsureCreated();
            GetSamurais("Before Adding");
            AddSamurai();
            GetSamurais("After Adding");
            Console.WriteLine($"Press any key.");
            Console.ReadKey();
        }

        private static void AddSamurai()
        {
            var samurai = new Samurai.App.Domain.Samurai { Name = "Ziaur" };
            context.Samurais.Add(samurai);
            context.SaveChanges();
        }

        private static void GetSamurais(string text)
        {
            var samurais = context.Samurais.ToList();
            Console.WriteLine($"{text}: SAmurai count is {samurais.Count}");
            foreach(var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}
