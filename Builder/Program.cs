using System;
using Builder.FluentBuilder;
using Builder.FluentGenericRecursiveBuilder;
using Builder.FunctionalBuilder;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Fluent Builder
            var htmlBuilder = new HtmlBuilder("ul");
            htmlBuilder.AddChild("li", "hello")
                .AddChild("li", "from");
            
            htmlBuilder.AddChild("li", "me");
            Console.WriteLine(htmlBuilder.ToString());

            
            // Fluent Generic Recursive Builder
            var me = Person.New
                .Called("Moamer")
                .WorksAsA("Programmer")
                .Build();
            Console.WriteLine(me);
            
            // Functional Builder (mostly for F sharp where object oriented approaches are not particularly)
            var pb = new PersonBuilderFunc();
            var person = pb.Called("Moamer")
                .WorksAsA("developer")
                .Build();
            
            Console.ReadKey();
        }
    }
}