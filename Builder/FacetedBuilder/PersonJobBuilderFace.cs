namespace Builder.FacetedBuilder
{
    public class PersonJobBuilderFace : PersonBuilderFace
    {
        public PersonJobBuilderFace(PersonFace person)
        {
            this.person = person;
        }

        public PersonJobBuilderFace At(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilderFace AsA(string position)
        {
            person.Position = position;
            return this;
        }

        public PersonJobBuilderFace Earning(int amount)
        {
            person.AnnualIncome = amount;
            return this;
        }
    }
}