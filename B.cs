using System;

public class MyClass
{
    private string book;
    private int goal;

    public string Book
    {
        get { return this.book; }
        set { this.book = value; }
    }

    public int Goal
    {
        get { return this.goal; }
        set { this.goal = value; }
    }

    public MyClass(string book, int goal)
    {
        this.Book = book;
        this.Goal = goal;
    }

    public void PrintProperties()
    {
        Console.WriteLine("Book Name: " + this.Book + ", Goal: " + this.Goal);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myLab1 = new MyClass("Pride and Prejudice by Zadid", 3);
        myLab1.PrintProperties();
    }
}
