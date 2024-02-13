using System;

public class MyClass
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public MyClass(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to print properties
    public void PrintProperties()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of MyClass
        MyClass myObject = new MyClass("John", 25);

        // Call the PrintProperties method to print the properties
        myObject.PrintProperties();
    }
}
