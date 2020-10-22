using System;
using Builder.Builder;
using Builder.FluentGenericBuilder;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var htmlBuilder = new HtmlBuilder("ul");
            htmlBuilder.AddChild("li", "hello")
                .AddChild("li", "from");
            
            htmlBuilder.AddChild("li", "me");
            Console.WriteLine(htmlBuilder.ToString());

            var me = Person.New
                .Called("Moamer")
                .WorksAsA("Programmer")
                .Build();
            Console.WriteLine(me);
            
            Console.ReadKey();
        }
    }
}