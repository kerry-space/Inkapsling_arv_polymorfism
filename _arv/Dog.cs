using Inkapsling_arv_polymorfism;


namespace Inkapsling_arv_polymorfism
{
    public class Dog : Animal
    {
         public string Breed { get; set; }

        public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }

        public override string Stats()
        {
            return base.Stats() + $", Breed: {Breed}";
        }

         public string GetDogInfo()
        {
            return $"Dog info - Name: {Name}, Breed: {Breed}";
        }
        
    }
}