namespace Builder.FacetedBuilder
{
    public class PersonBuilderFace // facade
    {
        // reference !
        protected PersonFace person = new PersonFace();
        
        public PersonJobBuilderFace Works => new PersonJobBuilderFace(person);
        public PersonAddressBuilderFace Lives => new PersonAddressBuilderFace(person);

        public static implicit operator PersonFace(PersonBuilderFace pb)
        {
            return pb.person;
        }
    }
}