using System;

namespace Journal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, journal prove World!");
        List<Journal> myJournals = new List<Journal>();
        
        Journal journal1 = new Journal();
        journal1._date = "2023-06-01";
        journal1._prompt = "What is the capital of France?";
        journal1._response = "The capital of France is Paris.";
        myJournals.Add(journal1);

        Journal journal2 = new Journal();
        journal2._date = "2026-12-01";
        journal2._prompt = "What is the capital of England?";
        journal2._response = "The capital of England is London.";
        myJournals.Add(journal2);

        foreach (Journal j in myJournals)
        {
            j.Display();
        }
    }
}