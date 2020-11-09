using System;

namespace Builder
{
    class Program
    { 
        static void Main(string[] args)
        {
            // TODO:Builder

            // Fluent Builder
            // var htmlBuilder = new HtmlBuilder("ul");
            // htmlBuilder.AddChild("li", "hello")
            //     .AddChild("li", "from");
            //
            // htmlBuilder.AddChild("li", "me");
            // Console.WriteLine(htmlBuilder.ToString());


            // Fluent Generic Recursive Builder
            // var me = Person.New
            //     .Called("Moamer")
            //     .WorksAsA("Programmer")
            //     .Build();
            // Console.WriteLine(me);

            // Functional Builder (mostly for F sharp where object oriented approaches are not particularly)
            // var pbFunc = new PersonBuilderFunc();
            // var personFunc = pbFunc.Called("Moamer")
            //     .WorksAsA("developer")
            //     .Build();

            // Functional Builder
            // var pbFace = new PersonBuilderFace();
            // PersonFace personFace = pbFace
            //     .Lives.At("some address")
            //         .In("some city")
            //         .WithPostcode("333222")
            //     .Works.At("DieWerber")
            //         .AsA("Engineer")
            //         .Earning(12000);
            // Console.WriteLine(personFace);
            
            // TODO:Factories

            // Factory Method
            // var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
            // var origin = Point.Origin;
            // Console.WriteLine(point);
            
            // Asynchronous Factory Method
            // Foo x = await Foo.CreateAsync();
            
            // Abstract Factory
            // var machine = new HotDrinkMachine();
            // var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 100);
            // drink.Consume();
            
            // Use reflection
            // var machine = new HotDrinkMachine();
            // var drink = machine.MakeDrink();
            // drink.Consume();
            
            // TODO:Prototype
            
            // Copy Through Serialization
            // var john = new PersonProto(new []{"John", "Smith"}, new Address("Bulevar Road", 1223));
            // var jane = john.DeepCopy();
            // jane.Address.HouseNumber = 3221;
            // Console.WriteLine(john);
            // Console.WriteLine(jane);
            
            // TODO:Singleton

            // Monostate
            // var ceo = new CEO();
            // ceo.Name = "Adam Smith";
            // ceo.Age = 55;
            
            // var ceo2 = new CEO();
            // Console.WriteLine(ceo2);
            
            // TODO:Adapter
            
            // Adapter Caching
            // var point2 = new PointAdap(3,4);
            // point2.Draw();
            // point2.Draw();
            
            // Generic Value Adapter
            // var v = new Vector2i(1,2);
            // v[0] = 0;
            
            // var vv = new Vector2i(3,2);
            // var result = v + vv;
            // Vector3f u = Vector3f.Create(3.5f, 2.2f, 1);
            
            // Adapter In Dependency Injection
            // var b = new ContainerBuilder();
            // b.RegisterType<SaveCommand>().As<ICommand>()
            //     .WithMetadata("Name", "Save");
            // b.RegisterType<OpenCommand>().As<ICommand>()
            //     .WithMetadata("Name", "Open");
            // // b.RegisterAdapter<ICommand, Button>(cmd => new Button(cmd));
            // b.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
            //     new Button(cmd.Value, (string) cmd.Metadata["Name"]));
            // b.RegisterType<Editor>();

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
            // Adaptee adaptee = new Adaptee();
            // ITarget target = new Adapter3(adaptee);
            // Console.WriteLine(target.GetRequest());
            
            // TODO:Bridge
            
            // Implementation
            // Example 1
            // var renderer = new VectorRenderer();
            // var circle = new Circle(renderer, 5);
            // circle.Draw();
            // circle.Resize(2);
            // circle.Draw();
            
            // Example 2 (with Container Builder)
            // var cb = new ContainerBuilder();
            // cb.RegisterType<VectorRenderer>().As<IRenderer>()
            //     .SingleInstance();
            // cb.Register((c, p) =>
            //     new Circle(c.Resolve<IRenderer>(),
            //         p.Positional<float>(0)));
            // using (var c = cb.Build())
            // {
            //     var circle5 = c.Resolve<Circle>(new PositionalParameter(0, 5.0f));
            //     circle5.Draw();
            //     circle5.Resize(2.0f);
            //     circle5.Draw();
            // }
            
            // TODO:Composite
            
            // Example

            // var drawing = new GraphicObject {Name = "My Drawing"};
            // drawing.Children.Add(new Square {Color = "Red"});
            // drawing.Children.Add(new Composite.Example.Circle {Color = "Yellow"});
            
            // var group = new GraphicObject();
            // group.Children.Add(new Composite.Example.Circle {Color = "Blue"});
            // group.Children.Add(new Square {Color = "Blue"});
            // drawing.Children.Add(group);
            //
            // Console.WriteLine(drawing);
            
            //
            
            // Neural Networks
            
            // var neuron1 = new Neuron();
            // var neuron2 = new Neuron();
            //
            // neuron1.ConnectTo(neuron2);
            //
            // var layer1 = new NeuronLayer();
            // var layer2 = new NeuronLayer();
            //
            // neuron1.ConnectTo(layer1);
            // layer1.ConnectTo(layer2);
            
            // Implementation
            
            // Client client = new Client();
            // This way the client code can support the simple leaf
            // components...
            // Leaf leaf = new Leaf();
            // Console.WriteLine("Client: I get a simple component:");
            // client.ClientCode(leaf);
            
            // ...as well as the complex composites.
            // Composite.Implementation.Composite three = new Composite.Implementation.Composite();
            // Component branch1 = new Composite.Implementation.Composite();
            // branch1.Add(new Leaf());
            // branch1.Add(new Leaf());
            // Composite.Implementation.Composite branch2 = new Composite.Implementation.Composite();
            // branch2.Add(new Leaf());
            // three.Add(branch1);
            // three.Add(branch2);
            // Console.WriteLine("Client: Now I've got a composite three:");
            // client.ClientCode(three);
            //
            // Console.WriteLine("Client: I don't need to check the components classes even when managing the three:\n");
            // client.ClientCode2(three, leaf);
            
            // TODO:Decorator
            
            // Implementation
            // Client client = new Client();
            // var simple = new ConcreteComponent();
            // Console.WriteLine("Client: I get simple component");
            // client.ClientCode(simple);
            // Console.WriteLine();
            
            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            // ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            // ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            // Console.WriteLine("Client: Now I've got a decorated component");
            // client.ClientCode(decorator2);
            
            // Adapter Decorator

            // MyStringBuilder s = "hello ";
            // s += "world";
            // Console.WriteLine(s);

            // Multiple Inheritance With Interface
            
            // var d = new Dragon();
            // d.Weight = 22;
            // d.Fly();
            // d.Crawl();
            
            // Multiple Inheritance with Default Interface Members

            // Dragon d = new Dragon {Age = 5};
            //
            // if (d is IBird bird)
            //     bird.Fly();
            // if (d is ILizard lizard)
            //     lizard.Crawl();
            
            // Dynamic Decorator Composition

            // var square = new Square(1.23f);
            // Console.WriteLine(square.AsString());
            //
            // var redSquare = new ColoredShape(square, "red");
            // Console.WriteLine(redSquare.AsString());
            //
            // var redHalfTransparentSquare = new TransparentShape(redSquare, 0.5f);
            // Console.WriteLine(redHalfTransparentSquare.AsString());

            // Decorator In Dependency Injection
            
            // var b = new ContainerBuilder();
            // b.RegisterType<ReportingService>().Named<IReportingService>("reporting");
            // b.RegisterDecorator<IReportingService>(
            //     (context, service) => new ReportingServiceWithLogging(service), "reporting"
            // );
            //
            // using (var c = b.Build())
            // {
            //     var r = c.Resolve<IReportingService>();
            //     r.Report();
            // }
            
            // TODO:Facade
            
            // Implementation
            
            // Subsystem1 subsystem1 = new Subsystem1();
            // Subsystem2 subsystem2 = new Subsystem2();
            // Facade.Implementation.Facade facade = new Facade.Implementation.Facade(subsystem1, subsystem2);
            // Client.ClientCode(facade);
            
            // TODO:Flyweight
            
            // User Names Optimization DotMemory
            // Run test in Demo class
            
            // Text Formatting
            
            // var ft = new FormattedText("This is a brave new world");
            // ft.Capitalize(10, 15);
            // Console.WriteLine(ft);
            //
            // var bft = new BetterFormattedText("This is a brave new world");
            // bft.GetRange(10, 15).Capitalize = true;
            // Console.WriteLine(bft);
            
            // Implementation
            
            // var factory = new FlyweightFactory(
            //     new Car {Company = "Chevrolet", Model = "Camaro2018", Color = "pink"},    
            //     new Car {Company = "Mercedes Benz", Model = "C300", Color = "black"},
            //     new Car {Company = "Mercedes Benz", Model = "C500", Color = "red"},
            //     new Car {Company = "Bmw", Model = "M5", Color = "red"},
            //     new Car {Company = "Bmw", Model = "X6", Color = "white"}
            // );
            // factory.listFlyweights();
            //
            // addCarToPoliceDatabase(factory, new Car {
            //     Number = "CL234IR",
            //     Owner = "James Doe",
            //     Company = "BMW",
            //     Model = "M5",
            //     Color = "red"
            // });
            //
            // addCarToPoliceDatabase(factory, new Car {
            //     Number = "CL234IR",
            //     Owner = "James Doe",
            //     Company = "BMW",
            //     Model = "X1",
            //     Color = "red"
            // });
            //
            // factory.listFlyweights();
            //
            // static void addCarToPoliceDatabase(FlyweightFactory factory, Car car)
            // {
            //     Console.WriteLine("\nClient: Adding a car to database.");
            //
            //     var flyweight = factory.GetFlyweight(new Car {
            //         Color = car.Color,
            //         Model = car.Model,
            //         Company = car.Company
            //     });
            //
            //     // The client code either stores or calculates extrinsic state and
            //     // passes it to the flyweight's methods.
            //     flyweight.Operation(car);
            // }
            
            // TODO:Proxy
            
            // Protection Proxy
            
            // ICar car = new CarProxy(new Driver(25));
            // car.Drive();
            
            // Property Proxy
            
            // var c = new Creature();
            // c.Agility = 10; // c.set_Agility(10) xxxxxxx
                               // c.Agility = new Property<int>(10)
            // c.Agility = 10;
            

            Console.ReadKey();
        }

        
    }
}