using System;
using System.IO;

class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}

class Journal
{
    private List<Entry> entries = new List<Entry>();
    private readonly string[] prompts = { "Describe your day", "What did you learn today", "What are you grateful for", "What is on your mind", "What scripture did you read today" };

    public void AddEntry()
    {
        Console.WriteLine("Select a prompt:");
        for (int i = 0; i < prompts.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }

        int selectedPrompt = int.Parse(Console.ReadLine());
        Console.WriteLine("Write your response:");
        string response = Console.ReadLine();
        entries.Add(new Entry(prompts[selectedPrompt - 1], response, DateTime.Now));
    }

    public void ShowJournal()
    {
        Console.WriteLine("Journal entries:");
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry.Date.ToShortDateString()} - {entry.Prompt}: {entry.Response}");
        }
    }

    public void SaveJournal(string fileName)
    {
        using (StreamWriter streamWriter = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                streamWriter.WriteLine($"{entry.Date.ToShortDateString()},{entry.Prompt},{entry.Response}");
            }
        }
    }

    public void LoadJournal(string fileName)
    {
        entries.Clear();
        using (StreamReader streamReader = new StreamReader(fileName))
        {
            while (!streamReader.EndOfStream)
            {
                string[] line = streamReader.ReadLine().Split(',');
                entries.Add(new Entry(line[1], line[2], DateTime.Parse(line[0])));
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Journal options:");
            Console.WriteLine("1. Add entry");
            Console.WriteLine("2. Show journal"); 
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.ShowJournal();
                    break;
                case 3:
                    Console.WriteLine("Enter file name:");
                    string fileName = Console.ReadLine();
                    journal.SaveJournal(fileName);
                    break;
            }
        }
    }
}
