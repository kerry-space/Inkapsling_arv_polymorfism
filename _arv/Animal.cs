using Inkapsling_arv_polymorfism;


namespace Inkapsling_arv_polymorfism
{
    public abstract class Animal
    {
      // Properties common to all animals
        public string Name { get; set; } = string.Empty;
        public double Weight { get; set; }
        public int Age { get; set; }

        // Constructor to initialize properties
        protected Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract void DoSound();

        // Virtual method that can be overridden in derived classes
        public virtual string Stats()
        {
            return $"Name: {Name}, Weight: {Weight}, Age: {Age}";
        }
           
    }


}