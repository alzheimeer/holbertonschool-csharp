using System;

struct Dog
    {  
        public string name;
        public float age;
        public string owner;
        public Rating rating;

        public Dog(string name, float age, string owner, Rating rating)
        {
            this.name = name;
            this.age = age;
            this.owner = owner;
            this.rating = rating;
        }

        public override string ToString()
        {
            return "Dog Name: " + name + "Age: " + age + "Owner: " + owner + "Rating: " + rating;
        }
    }

enum Rating
{
    Good,
    Great,
    Excellent
}