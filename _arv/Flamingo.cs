namespace Inkapsling_arv_polymorfism
{
    public class Flamingo : Bird
    {
        public string Color { get; set; }

        public Flamingo(string name, double weight, int age, double wingSpan, string color)
            : base(name, weight, age, wingSpan)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{Name} says: Honk!");
        }
    }
}