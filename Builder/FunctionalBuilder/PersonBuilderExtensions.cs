namespace Builder.FunctionalBuilder
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilderFunc WorksAsA(this PersonBuilderFunc builder, string position)
        {
            builder.Actions.Add(p => { p.Position = position; });
            return builder;
        }
    }
}