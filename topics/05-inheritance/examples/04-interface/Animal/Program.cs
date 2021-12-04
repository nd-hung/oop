using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo 1 đối tượng Dog
            Dog dog1 = new Dog("Shiba");
            dog1.Speak();
            dog1.Print();
        }
    }
}
