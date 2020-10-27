using System;

namespace Prototype.CopyThroughSerializationAndXml
{
    [Serializable]
    public class PersonProto
    {
        public string[] Names;
        public Address Address;

        // public PersonProto()
        // {
        //     
        // }

        public PersonProto(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public PersonProto(PersonProto other)
        {
            Names = other.Names;
            Address = new Address(other.Address);
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ",Names)}, {nameof(Address)}: {Address}";
        }
        
    }
}