using System;
using System.Dynamic;
using ImpromptuInterface;

namespace NullObject.Example
{
    public class Null<TInterface> : DynamicObject where TInterface : class
    {
        public static TInterface Instance => new Null<TInterface>().ActLike<TInterface>();

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            result = Activator.CreateInstance(binder.ReturnType);
            return true;
        }
    }
}