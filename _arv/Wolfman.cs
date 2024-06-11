namespace Inkapsling_arv_polymorfism
{
    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, string packName)
            : base(name, weight, age, packName)
        {
        }

        public void Talk()
        {
            Console.WriteLine($"{Name} says: I am a Wolfman!");
        }
    }
}