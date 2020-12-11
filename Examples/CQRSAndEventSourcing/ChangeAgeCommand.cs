namespace Examples.CQRSAndEventSourcing
{
    public class ChangeAgeCommand : Command
    {
        public Person Target;
        public int Age;

        public ChangeAgeCommand(Person target, int age)
        {
            Target = target;
            this.Age = age;
        }
    }
}