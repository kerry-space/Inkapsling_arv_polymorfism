using Inkapsling_arv_polymorfism;


namespace Inkapsling_arv_polymorfism
{
    public class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }
        public Hedgehog(string name, double weight, int age, int numberOfSpikes) : base(name, weight, age)
        {
             NumberOfSpikes = numberOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{Name} says: Snuffle!");
        }

        public override string Stats()
        {
            return base.Stats() + $", NumberOfSpikes: {NumberOfSpikes}";
        }
    }
}