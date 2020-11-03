namespace Decorator.MultipleInheritanceWithInterface
{
    public class Dragon : IBird, ILizard
    {
        private Bird bird = new Bird();
        private Lizard lizard = new Lizard();
        private int weight;

        public void Fly()
        {
            bird.Fly();
        }

        public void Crawl()
        {
            lizard.Crawl();
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
                bird.Weight = value;
                lizard.Weight = value;
            }
        }
    }
}