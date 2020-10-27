using System;

namespace Prototype.CopyThroughSerializationAndXml
{
    [Serializable]
    public class Address
    {
        public string StreetNumber;
        public int HouseNumber;

        // public Address()
        // {
        //     
        // }

        public Address(string streetNumber, int houseNumber)
        {
            StreetNumber = streetNumber;
            HouseNumber = houseNumber;
        }

        public Address(Address other)
        {
            StreetNumber = other.StreetNumber;
            HouseNumber = other.HouseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetNumber)}: {StreetNumber}, {nameof(HouseNumber)}: {HouseNumber}";
        }
        
        
    }
}