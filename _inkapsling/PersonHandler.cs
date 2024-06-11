using Inkapsling_arv_polymorfism;

internal class PersonHandler
    {
        public PersonHandler()
        {
        }

        public void SetAge(Person pers, int age){
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight){
             
             Person person = new Person 
             {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };

            return person;
        }

        // Additional methods to handle Person objects
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public string GetFullName(Person pers)
        {
            return $"{pers.FName} {pers.LName}";
        }

        public void DisplayPersonInfo(Person pers)
        {
            Console.WriteLine($"Name: {GetFullName(pers)}, Age: {pers.Age}, Height: {pers.Height}, Weight: {pers.Weight}");
        }
    }