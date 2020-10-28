using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MoreLinq;

namespace Singleton.SingletonImplementation
{
    public class OrdinaryDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;

        public OrdinaryDatabase()
        {
            Console.WriteLine("Initializing database");

            string path = @"C:\\Users\\moame\\RiderProjects\\DesignPattern\\Singleton\\SingletonImplementation\\capitals.txt";
            
            capitals = File.ReadAllLines(Path.Combine(new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, path))
                .Batch(2)
                .ToDictionary(
                    list => list.ElementAt(0).Trim(),
                    list => int.Parse(list.ElementAt(1)));
        }

        public int GetPopulation(string name)
        {
            return capitals[name];
        }
    }
}