using System;
using System.Collections.Generic;
using Visitor.Implementation;

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

            // Value Proxy

            // Console.WriteLine(10f * 5.Percent());
            // Console.WriteLine(2.Percent() + 3.Percent());

            // Composite Proxy SoA/AoS

            //AoS (Array of Structure)
            // var creatures = new Creature[100];
            // foreach (var c in creatures)
            // {
            //     c.X++;
            // }

            //AOS/SOA duality
            // var creatures2 = new Creatures(100); //SoA (Structure of Array)
            // foreach (CreatureProxy c in creatures2)
            // {
            //     c.X++;
            // }

            // Dynamic Proxy For Logging

            // var ba = Log<BankAccount>.As<IBankAccount>();
            //
            // ba.Deposit(100);
            // ba.Withdraw(50);
            //
            // Console.WriteLine(ba);

            // Implementation

            // Client client = new Client();
            //
            // Console.WriteLine("Client: Executing the client code with a real subject:");
            // RealSubject realSubject = new RealSubject();
            // client.ClientCode(realSubject);
            //
            // Console.WriteLine();
            //
            // Console.WriteLine("Client: Executing the same client code with proxy:");
            // Proxy.Implementation.Proxy proxy = new Proxy.Implementation.Proxy(realSubject);
            // client.ClientCode(proxy);

            // TODO:ChainOfResponsibility

            // Mediator Chain

            // The other part of the client code constructs the actual chain.
            // var monkey = new MonkeyHandler();
            // var squirrel = new SquirrelHandler();
            // var dog = new DogHandler();
            //
            // monkey.SetNext(squirrel).SetNext(dog);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.

            // Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            // Client.ClientCode(monkey);
            // Console.WriteLine();
            //
            // Console.WriteLine("Subchain: Squirrel > Dod\n");
            // Client.ClientCode(squirrel);

            // TODO:Command

            // Example

            // var ba = new BankAccount();
            // var commands = new List<BankAccountCommand>
            // {
            //     new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
            //     new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 50)
            // };
            //
            // foreach (var c in commands)
            // {
            //     c.Call();
            // }
            //
            // foreach (var c in Enumerable.Reverse(commands))
            // {
            //     c.Undo();
            // }

            // Implementation

            // The client code can parameterize an invoker with any commands.

            // Invoker invoker = new Invoker();
            // invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            // Receiver receiver = new Receiver();
            // invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));
            //
            // invoker.DoSomethingImportant();

            // TODO:Interpreter

            // Handmade Interpreter

            // (13 + 4) - (12 + 1)
            // string input = "(13+4)-(12+1)";
            // var tokens = Lexing.Lex(input);
            // Console.WriteLine(string.Join("\t", tokens));
            //
            // var parsed = Lexing.Parse(tokens);
            // Console.WriteLine($"{input} = {parsed.Value}");

            // TODO:Iterator

            // Iterator Object

            //   1
            //  / \
            // 2   3

            // in order: 213
            // var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));
            // var it = new InOrderIterator<int>(root);
            // while (it.MoveNext())
            // {
            //     Console.WriteLine(it.Current.Value);
            //     Console.WriteLine(",");
            // }

            // Iterator Method

            // var tree = new BinaryTree<int>(root);
            // Console.WriteLine(string.Join(",", tree.InOrder.Select(x => x.Value)));

            // Iterators And Duck Typing

            // var tree2 = new BinaryTree<int>(root);
            // foreach(var node in tree2)
            //     Console.WriteLine(node.Value);

            // Implementation

            // The client code may or may not know about the Concrete Iterator
            // or Collection classes, depending on the level of indirection you
            // want to keep in your program.

            // var collection = new WordsCollection();
            // collection.AddItem("First");
            // collection.AddItem("Second");
            // collection.AddItem("Third");
            //
            // Console.WriteLine("Straight traversal:");
            //
            // foreach (var element in collection)
            // {
            //     Console.WriteLine(element);
            // }
            //
            // Console.WriteLine("\nReverse traversal:");
            //
            // collection.ReverseDirection();
            //
            // foreach (var element in collection)
            // {
            //     Console.WriteLine(element);
            // }

            // TODO:Mediator

            // Chat Room

            // var room = new ChatRoom();
            //
            // var john = new Person("John");
            // var jane = new Person("jane");
            //
            // room.Join(john);
            // room.Join(jane);
            //
            // john.Say("hi");
            // jane.Say("oh, hey john");
            //
            // var simon = new Person("Simon");
            // room.Join(simon);
            // simon.Say("hi everyone!");
            //
            // jane.PrivateMessage("Simon", "glad you could join us!");

            // Event Broker

            // var cb = new ContainerBuilder();
            // cb.RegisterType<EventBroker>().SingleInstance();
            // cb.RegisterType<FootballCoach>();
            // cb.Register((c, p) => 
            //     new FootballPlayer(
            //         c.Resolve<EventBroker>(),
            //         p.Named<string>("name")
            //     ));
            //
            // using (var c = cb.Build())
            // {
            //     var coach = c.Resolve<FootballCoach>();
            //     var player1 = c.Resolve<FootballPlayer>(new NamedParameter("name", "John"));
            //     var player2 = c.Resolve<FootballPlayer>(new NamedParameter("name", "Chris"));
            //
            //     player1.Score();
            //     player1.Score();
            //     player1.Score(); // x
            //     player1.AssaultReferee();
            //     player2.Score();
            // }

            // MediatR

            // var builder = new ContainerBuilder();
            // builder.RegisterType<Mediator>()
            //     .As<IMediator>()
            //     .InstancePerLifetimeScope();
            //
            // builder.Register<ServiceFactory>(ctx =>
            // {
            //     var c = ctx.Resolve<IComponentContext>();
            //     return t => c.Resolve(t);
            // });
            //
            // builder.RegisterAssemblyTypes(typeof(Program).Assembly)
            //     .AsImplementedInterfaces();
            //
            // var container = builder.Build();
            // var mediator = container.Resolve<IMediator>();
            // var response = await mediator.Send(new PingCommand());
            // Console.WriteLine($"We got a response at {response.Timestamp}");

            // Implementation

            // The client code.
            // Component1 component1 = new Component1();
            // Component2 component2 = new Component2();
            // new ConcreteMediator(component1, component2);
            //
            // Console.WriteLine("Client triggers operation A.");
            // component1.DoA();
            //
            // Console.WriteLine();
            //
            // Console.WriteLine("Client triggers operation D.");
            // component2.Dod();

            // TODO:Memento

            // Example

            // var ba = new BankAccount(100);
            // ba.Deposit(50);
            // ba.Deposit(25);
            // Console.WriteLine(ba);
            //
            // ba.Undo();
            // Console.WriteLine($"Undo 1: {ba}");
            // ba.Undo();
            // Console.WriteLine($"Undo 2: {ba}");
            // ba.Redo();
            // Console.WriteLine($"Redo: {ba}");

            // Implementation

            // Originator originator = new Originator("Super-duper");
            // Caretaker caretaker = new Caretaker(originator);
            //
            // caretaker.Backup();
            // originator.DoSomething();
            //
            // caretaker.Backup();
            // originator.DoSomething();
            //
            // caretaker.Backup();
            // originator.DoSomething();
            //
            // Console.WriteLine();
            // caretaker.ShowHistory();
            //
            // Console.WriteLine("\nClient: Now, let's rollback!\n");
            // caretaker.Undo();
            //
            // Console.WriteLine("\n\nClient: Once more!\n");
            // caretaker.Undo();

            // TODO:NullObject

            // Example

            // var cb = new ContainerBuilder();
            // cb.RegisterType<BankAccount>();
            // cb.RegisterType<NullLog>().As<ILog>();
            // using (var c = cb.Build())
            // {
            //     var ba = c.Resolve<BankAccount>();
            //     ba.Deposit(100);
            // }

            // var log = Null<ILog>.Instance;
            // log.Info("asdsad");
            // var ba = new BankAccount(log);
            // ba.Deposit(100);

            // Via Event Key

            // var person = new Person();
            // person.FallsIll += CallDoctor;
            // person.CatchACold();

            // Weak Event

            // var button = new Button();
            // var window = new Window(button);
            // var windowRef = new WeakReference(window);
            // button.Fire();
            //
            // Console.WriteLine("Setting window to null");
            // window = null;
            //
            // FireGC();
            // Console.WriteLine($"Is the window alive after GC? {windowRef.IsAlive}");

            // Implementation

            // var subject = new Subject();
            // var observerA = new ConcreteObserverA();
            // subject.Attach(observerA);
            //
            // var observerB = new ConcreteObserverB();
            // subject.Attach(observerB);
            //
            // subject.SomeBusinessLogic();
            // subject.SomeBusinessLogic();
            //
            // subject.Detach(observerB);
            //
            // subject.SomeBusinessLogic();

            // Observable Collections

            // var market = new Market(); //observer
            // market.Prices.ListChanged += (sender, eventArgs) =>
            // {
            //     if (eventArgs.ListChangedType == ListChangedType.ItemAdded)
            //     {
            //         float price = ((BindingList<float>) sender)[eventArgs.NewIndex];
            //         Console.WriteLine($"Binding list got a price of {price}");
            //     }
            // };
            // market.AddPrice(123);

            // TODO:State

            // Handmade state machine

            // var state = State1.OffHook;
            // while (true)
            // {
            //     Console.WriteLine($"The phone is currenty {state}");
            //     Console.WriteLine("Select a trigger:");
            //
            //     for (var i = 0; i < rules[state].Count; i++)
            //     {
            //         var (t, _) = rules[state][i];
            //         Console.WriteLine($"{i}. {t}");
            //     }
            //
            //     int input = int.Parse(Console.ReadLine());
            //     var (_, s) = rules[state][input];
            //     state = s;
            // }
            
            // Switch-based state machine

            // string code = "1234";
            // var state = State2.Locked;
            // var entry = new StringBuilder();
            //
            // while (true)
            // {
            //     switch (state)
            //     {
            //         case State2.Locked:
            //             entry.Append(Console.ReadKey().KeyChar);
            //
            //             if (entry.ToString() == code)
            //             {
            //                 state = State2.Unlocked;
            //                 break;
            //             }
            //
            //             if (!code.StartsWith(entry.ToString()))
            //             {
            //                 state = State2.Failed;
            //                 // goto case State2.Failed;
            //             }
            //             
            //             break;
            //         case State2.Failed:
            //             Console.CursorLeft = 0;
            //             Console.WriteLine("FAILED");
            //             entry.Clear();
            //             state = State2.Locked;
            //             break;
            //         case State2.Unlocked:
            //             Console.CursorLeft = 0;
            //             Console.WriteLine("UNLOCKED");
            //             return;
            //         
            //     }
            // }
            
            // State machine with stateless

            // var machine = new StateMachine<Health, Activity>(Health.NonReproductive);
            // machine.Configure(Health.NonReproductive)
            //     .Permit(Activity.ReachPuberty, Health.Reproductive);

            // Implementation
            
            // The client code
            // var context = new Context(new ConcreteStateA());
            // context.Request1();
            // context.Request2();
           
            // TODO:Strategy
            
            // Dynamic Strategy
            
            // var tp = new TextProcessor();
            // tp.SetOutputFormat(OutputFormat.Markdown);
            // tp.AppendList(new[] {"foo", "bar", "baz"});
            // Console.WriteLine(tp);
            //
            // tp.Clear();
            // tp.SetOutputFormat(OutputFormat.Html);
            // tp.AppendList(new[] {"foo", "bar", "baz"});
            // Console.WriteLine(tp);
            
            // Equality and comparison strategies
            
            // var people = new List<Person>();
            // people.Sort(); // default
            // // people.Sort((x,y) => x.Name.CompareTo(y.Name));
            // people.Sort(Person.NameComparer);
            
            // Implementation
            
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            // var context = new Context();
            //
            // Console.WriteLine("Client: Strategy is set to normal sorting.");
            // context.SetStrategy(new ConcreteStrategyA());
            // context.DoSomeBusinessLogic();
            //
            // Console.WriteLine();
            //
            // Console.WriteLine("Client: Strategy is set to reverse sorting.");
            // context.SetStrategy(new ConcreteStrategyB());
            // context.DoSomeBusinessLogic();
            
            // TODO:TemplateMethod
            
            // Example

            // var chess = new Chess();
            // chess.Run();
            
            // Functional Template Method

            // var numberOfPlayers = 2;
            // int currentPlayer = 0;
            // int turn = 1, maxTurns = 10;
            //
            // void Start()
            // {
            //     Console.WriteLine($"Starting a game of chess with {numberOfPlayers} players.");
            // }
            //
            // bool HaveWinner()
            // {
            //     return turn == maxTurns;
            // }
            //
            // void TakeTurn()
            // {
            //     Console.WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
            //     currentPlayer = (currentPlayer + 1) % numberOfPlayers;
            // }
            //
            // int WinningPlayer()
            // {
            //     return currentPlayer;
            // }
            //
            // GameTemplate.Run(Start, TakeTurn, HaveWinner, WinningPlayer);
            
            // Implementation

            // Console.WriteLine("Same client code can work with different subclasses:");
            // Client.ClientCode(new ConcreteClass1());
            // Console.WriteLine("\n");
            // Console.WriteLine("Same client code can work with different subclasses:");
            // Client.ClientCode(new ConcreteClass2());
            
            // TODO:Visitor
            
            // Dynamic Visitor Via The DLR
            
            // Expression e = new AdditionExpression(
            //     new DoubleExpression(1), 
            //     new AdditionExpression(
            //         new DoubleExpression(2), 
            //         new DoubleExpression(3)
            //         ));
            // var ep = new ExpressionPrinter();
            // var sb = new StringBuilder();
            // ep.Print((dynamic)e, sb);
            // Console.WriteLine(sb);

            // Acyclic Visitor
            
            // var e = new AdditionExpression(
            //     new DoubleExpression(1), 
            //     new AdditionExpression(
            //         new DoubleExpression(2), 
            //         new DoubleExpression(3)
            //         ));
            // var ep = new ExpressionPrinter();
            // ep.Visit(e);
            // Console.WriteLine(ep.ToString());
            
            // Implementation
            
            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2);
            
            



            Console.ReadKey();
            
            
            
            


        }

        // private static Dictionary<State1, List<(Trigger, State1)>> rules = new Dictionary<State1, List<(Trigger, State1)>>
        // {
        //     [State1.OffHook] = new List<(Trigger, State1)>
        //     {
        //         (Trigger.CallDialed, State1.Connecting)
        //     },
        //     [State1.Connecting] = new List<(Trigger, State1)>
        //     {
        //         (Trigger.HungUp, State1.OffHook),
        //         (Trigger.CallConnected, State1.Connected)
        //     },
        //     [State1.Connected] = new List<(Trigger, State1)>
        //     {
        //         (Trigger.LeftMessage, State1.OffHook),
        //         (Trigger.HungUp, State1.OffHook),
        //         (Trigger.PlacedOnHold, State1.OnHold)
        //     },
        //     [State1.OnHold] = new List<(Trigger, State1)>
        //     {
        //         (Trigger.TakenOffHold, State1.Connected),
        //         (Trigger.HungUp, State1.OffHook)
        //     }
        // };

        // private static void FireGC()
        // {
        //     Console.WriteLine("Starting GC");
        //     GC.Collect();
        //     GC.WaitForPendingFinalizers();
        //     GC.Collect();
        //     Console.WriteLine("GC is done");
        // }
    }
}