using Inkapsling_arv_polymorfism;


namespace Inkapsling_arv_polymorfism
{
    public class Horse : Animal
    {
         public string Breed { get; set; }
        public Horse(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{Name} says: Neigh!, and the horse is type {Breed}");
        }

        public override string Stats()
        {
            return base.Stats() + $", Breed: {Breed}";
        }
    }
}