namespace DemoFactoriesMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AnimalFactory> animalFactories = new List<AnimalFactory>
            {
                new LionFactory(),
                new TigerFactory()
            };

            foreach (var animal in animalFactories)
            {
                animal.CreateAnimal().AboutMe();
            }
        }
    }

    public interface IAnimal
    {
        void AboutMe();
    }

    public class  Lion : IAnimal
    {
        public void AboutMe() => Console.WriteLine("I am a Lion");
    }

    public class  Tiger : IAnimal
    {
        public void AboutMe() => Console.WriteLine("I am a tiger");
    }

    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }

    public class LionFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Lion();
    }

    public class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Tiger();
    }
}
