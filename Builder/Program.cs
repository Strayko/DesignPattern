using System;
using System.Threading.Tasks;
using Adapter.AdapterCaching;
using Adapter.AdapterImpementation;
using Adapter.AdapterInDependencyInjection;
using Adapter.GenericValueAdapter;
using Autofac;
using Autofac.Features.Metadata;
using Bridge.Implementation;
using Builder.FacetedBuilder;
using Builder.FluentBuilder;
using Builder.FluentGenericRecursiveBuilder;
using Builder.FunctionalBuilder;
using Factories.AbstractFactory;
using Factories.AsynchronousFactoryMethod;
using Factories.FactoryMethod;
using Prototype.CopyThroughSerializationAndXml;
using Singleton.Monostate;

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
            // Console.WriteLine(ceo2);
            
            // TODO:Adapter
            
            // Adapter Caching
            var point2 = new PointAdap(3,4);
            // point2.Draw();
            // point2.Draw();
            
            // Generic Value Adapter
            var v = new Vector2i(1,2);
            v[0] = 0;
            
            // var vv = new Vector2i(3,2);
            // var result = v + vv;
            // Vector3f u = Vector3f.Create(3.5f, 2.2f, 1);
            
            // Adapter In Dependency Injection
            var b = new ContainerBuilder();
            b.RegisterType<SaveCommand>().As<ICommand>()
                .WithMetadata("Name", "Save");
            b.RegisterType<OpenCommand>().As<ICommand>()
                .WithMetadata("Name", "Open");
            // b.RegisterAdapter<ICommand, Button>(cmd => new Button(cmd));
            b.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
                new Button(cmd.Value, (string) cmd.Metadata["Name"]));
            b.RegisterType<Editor>();

            // using (var c = b.Build())
            // {
            //     var editor = c.Resolve<Editor>();
            //     // editor.ClickAll();
            //     foreach (var btn in editor.Buttons)
            //     {
            //         btn.PrintMe();
            //     }
            // }
            
            // Adapter Impementation
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter3(adaptee);
            // Console.WriteLine(target.GetRequest());
            
            // TODO:Bridge
            
            // Implementation
            // Example 1
            var renderer = new VectorRenderer();
            var circle = new Circle(renderer, 5);
            // circle.Draw();
            // circle.Resize(2);
            // circle.Draw();
            
            // Example 2 (with Container Builder)
            var cb = new ContainerBuilder();
            cb.RegisterType<VectorRenderer>().As<IRenderer>()
                .SingleInstance();
            cb.Register((c, p) =>
                new Circle(c.Resolve<IRenderer>(),
                    p.Positional<float>(0)));
            // using (var c = cb.Build())
            // {
            //     var circle5 = c.Resolve<Circle>(new PositionalParameter(0, 5.0f));
            //     circle5.Draw();
            //     circle5.Resize(2.0f);
            //     circle5.Draw();
            // }
            



            Console.ReadKey();
        }

        
    }
}