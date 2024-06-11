using System;

namespace Inkapsling_arv_polymorfism
{
    class Person
    {
       private int age;
       private string fName;

       private string lName;
       private  double height;

       private double weight;

       

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be greater than 0");
                }
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 2 && value.Length <= 10)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException("First Name is mandatory and must be between 2 and 10 characters long");
                }
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 3 && value.Length <= 15)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException("Last Name is mandatory and must be between 3 and 15 characters long");
                }
            }
        }

        public double Height
        {
            get{return height;}
            set{height = value;}
        }

          public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

    }
}