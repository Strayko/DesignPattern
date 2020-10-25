namespace Builder.FacetedBuilder
{
    public class PersonAddressBuilderFace : PersonBuilderFace
    {
        public PersonAddressBuilderFace(PersonFace person)
        {
            this.person = person;
        }

        public PersonAddressBuilderFace At(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }

        public PersonAddressBuilderFace WithPostcode(string postcode)
        {
            person.Postcode = postcode;
            return this;
        }

        public PersonAddressBuilderFace In(string city)
        {
            person.City = city;
            return this;
        }
    }
}