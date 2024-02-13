using System;

public class MyClass
{
    
    private string books;
    private int goals;

    public string Name
    {
        get { return books; }
        set { books = value; }
    }

    public int goals
    {
        get { return goals; }
        set { goals = value; }
    }

    
    public MyClass(string books, int goals)
    {
        Book = books;
        Goal = goals;
    }

    
    public void PrintProperties()
    {
        Console.WriteLine("Book Name: {Book}, Goal: {Goal}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        MyClass myLab1 = new MyLab2("Pride and Prejudice by Zadid", 3);

        
        myLab1.PrintProperties();
    }
}
