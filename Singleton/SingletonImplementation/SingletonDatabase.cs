using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MoreLinq;

namespace Singleton.SingletonImplementation
{
    public class SingletonDatabase
    {
        private static Lazy<SingletonDatabase> instance = 
            new Lazy<SingletonDatabase>(() => new SingletonDatabase());

        public static SingletonDatabase Instance => instance.Value;
        
        
    }
}