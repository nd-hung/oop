/*
Xây dựng giao diện Animal để các lớp động vật khác cài đặt theo khuôn mẫu thống nhất.
*/
using System;

public interface IAnimal
{
    string Name{get; set;}

    void Speak();
}

// Cài đặt các lớp động vật cụ thể tuân theo giao diện IAnimal
class Dog:IAnimal
{
    public string Name{get; set;}

    public Dog(string name="")
    {
        Name = name;
    }
    public void Speak()
    {
        Console.WriteLine("Gow gow! I'm a dog.");
    }

    public void Print()
    {
        Console.WriteLine("I'm a dog. My name is " + Name);
    }
}

class Cat:IAnimal
{
    public string Name{get; set;}
    public void Speak()
    {
        Console.WriteLine("Meow! I'm a cat.");
    }
}