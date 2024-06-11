namespace Inkapsling_arv_polymorfism
{
    public class Swan : Bird
    {
        public string NeckLength { get; set; }

        public Swan(string name, double weight, int age, double wingSpan, string neckLength)
            : base(name, weight, age, wingSpan)
        {
            NeckLength = neckLength;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{Name} says: Hiss!");
        }
    }
}