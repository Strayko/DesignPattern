using System;

namespace Decorator.DecoratorInDependencyInjection
{
    public class ReportingService : IReportingService
    {
        public void Report()
        {
            Console.WriteLine("Here is your report");
        }
    }
}