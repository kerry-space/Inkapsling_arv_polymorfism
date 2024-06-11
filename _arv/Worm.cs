using Inkapsling_arv_polymorfism;


namespace Inkapsling_arv_polymorfism
{
    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public Worm(string name, double weight, int age , Boolean isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;

        }

        public override void DoSound()
        {
            Console.WriteLine($"{Name} says: Silence!");
        }

        public override string Stats()
        {
            return base.Stats() + $", IsPoisonous: {IsPoisonous}";
        }
    }
}