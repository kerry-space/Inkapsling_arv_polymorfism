using Inkapsling_arv_polymorfism;


namespace Inkapsling_arv_polymorfism
{
    public class Wolf : Animal
    {
         public string PackName { get; set; }

        public Wolf(string name, double weight, int age, string packName) : base(name, weight, age)
        {
            PackName = packName;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{Name} says: Howl!");
        }

        public override string Stats()
        {
            return base.Stats() + $", PackName: {PackName}";
        }
    }
}