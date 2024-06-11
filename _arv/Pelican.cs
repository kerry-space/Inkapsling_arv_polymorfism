namespace Inkapsling_arv_polymorfism
{
    public class Pelican : Bird
    {
        public double BeakLength { get; set; }

        public Pelican(string name, double weight, int age, double wingSpan, double beakLength)
            : base(name, weight, age, wingSpan)
        {
            BeakLength = beakLength;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{Name} says: Squawk!");
        }
    }
}