using Inkapsling_arv_polymorfism;


namespace Inkapsling_arv_polymorfism
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{Name} says: Tweet!");
        }

        public override string Stats()
        {
            return base.Stats() + $", WingSpan: {WingSpan}";
        }
    }
}