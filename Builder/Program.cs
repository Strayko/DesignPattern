using System;
using System.Threading.Tasks;
using Builder.FacetedBuilder;
using Builder.FluentBuilder;
using Builder.FluentGenericRecursiveBuilder;
using Builder.FunctionalBuilder;
using Factories.AbstractFactory;
using Factories.AsynchronousFactoryMethod;
using Factories.FactoryMethod;
using Prototype.CopyThroughSerializationAndXml;
using Singleton.Monostate;
using Singleton.SingletonImplementation;

namespace Builder
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // TODO:Builder

            // Fluent Builder
            var htmlBuilder = new HtmlBuilder("ul");
            htmlBuilder.AddChild("li", "hello")
                .AddChild("li", "from");

            htmlBuilder.AddChild("li", "me");
            // Console.WriteLine(htmlBuilder.ToString());


            // Fluent Generic Recursive Builder
            var me = Person.New
                .Called("Moamer")
                .WorksAsA("Programmer")
                .Build();
            // Console.WriteLine(me);

            // Functional Builder (mostly for F sharp where object oriented approaches are not particularly)
            var pbFunc = new PersonBuilderFunc();
            var personFunc = pbFunc.Called("Moamer")
                .WorksAsA("developer")
                .Build();

            // Functional Builder
            var pbFace = new PersonBuilderFace();
            PersonFace personFace = pbFace
                .Lives.At("some address")
                    .In("some city")
                    .WithPostcode("333222")
                .Works.At("DieWerber")
                    .AsA("Engineer")
                    .Earning(12000);
            // Console.WriteLine(personFace);
            
            // TODO:Factories

            // Factory Method
            var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
            var origin = Point.Origin;
            // Console.WriteLine(point);
            
            // Asynchronous Factory Method
            Foo x = await Foo.CreateAsync();
            
            // Abstract Factory
            // var machine = new HotDrinkMachine();
            // var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 100);
            // drink.Consume();
            
            // Use reflection
            var machine = new HotDrinkMachine();
            // var drink = machine.MakeDrink();
            // drink.Consume();
            
            // TODO:Prototype
            
            // Copy Through Serialization
            var john = new PersonProto(new []{"John", "Smith"}, new Address("Bulevar Road", 1223));
            var jane = john.DeepCopy();
            jane.Address.HouseNumber = 3221;
            // Console.WriteLine(john);
            // Console.WriteLine(jane);
            
            // TODO:Singleton

            // Monostate
            var ceo = new CEO();
            ceo.Name = "Adam Smith";
            ceo.Age = 55;
            
            var ceo2 = new CEO();
            Console.WriteLine(ceo2);

            Console.ReadKey();
        }
    }
}