using System;
using System.Collections.Generic;

namespace Builder.FunctionalBuilder
{
    public class PersonBuilderFunc
    {
        public readonly List<Action<PersonFunc>> Actions = new List<Action<PersonFunc>>();
        
        public PersonBuilderFunc Called(string name)
        {
            Actions.Add(p => { p.Name = name; });
            return this;
        }
        
        public PersonFunc Build()
        {
            var p = new PersonFunc();
            Actions.ForEach(a=>a(p));
            return p;
        }
    }
}