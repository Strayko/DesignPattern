using System;
using System.Collections.Generic;

namespace Factories.AbstractFactory
{
    public class HotDrinkMachine
    {
        // Violate OCP(Open Close Principle)

        // public enum AvailableDrink
        // {
        //     Coffee,
        //     Tea
        // }

        // private Dictionary<AvailableDrink, IHotDrinkFactory> factories =
        //     new Dictionary<AvailableDrink, IHotDrinkFactory>();
        //
        // public HotDrinkMachine()
        // {
        //     foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
        //     {
        //         var factory = (IHotDrinkFactory) Activator.CreateInstance(
        //             Type.GetType("Factories.AbstractFactory." + Enum.GetName(typeof(AvailableDrink), drink) +
        //                          "Factory"));
        //
        //         factories.Add(drink, factory);
        //     }
        // }
        //
        // public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        // {
        //     return factories[drink].Prepare(amount);
        // }

        
        // Using Reflection
        private List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>>();

        public HotDrinkMachine()
        {
            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    factories.Add(Tuple.Create(
                        t.Name.Replace("Factory", string.Empty),
                        (IHotDrinkFactory) Activator.CreateInstance(t)));
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks:");
            for (int index = 0; index < factories.Count; index++)
            {
                var tuple = factories[index];
                Console.WriteLine($"{index}: {tuple.Item1}");
            }

            while (true)
            {
                string s;
                if ((s = Console.ReadLine()) != null
                    && int.TryParse(s, out int i)
                    && i >= 0
                    && i < factories.Count)
                {
                    Console.WriteLine("Specify amount: ");
                    s = Console.ReadLine();
                    if (s != null && int.TryParse(s, out int amount) && amount > 0)
                    {
                        return factories[i].Item2.Prepare(amount);
                    }
                }

                Console.WriteLine("Incorrect input, try again!");
            }
        }
    }
}