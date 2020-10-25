﻿using System;
using Builder.FacetedBuilder;
using Builder.FluentBuilder;
using Builder.FluentGenericRecursiveBuilder;
using Builder.FunctionalBuilder;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:Builder

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
            Console.WriteLine(personFace);
            
            Console.ReadKey();
        }
    }
}