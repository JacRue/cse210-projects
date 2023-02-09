using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Scripture class with a reference to John 3:16
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Play the scripture memory game
        scripture.Play();
    }
}

class Scripture
{
    public string Reference { get; set; }
    public string Text { get; set; }
    private List<int> HiddenWords { get; set; }

    // Constructor for a single verse scripture reference
    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
        HiddenWords = new List<int>();
    }

    public void Play()
    {
        // Split the text into an array of words
        string[] words = Text.Split(' ');

        // Loop until all words are hidden
        while (HiddenWords.Count < words.Length)
        {
            Console.Clear();

            // Display the scripture with some words hidden
            for (int i = 0; i < words.Length; i++)
            {
                if (HiddenWords.Contains(i))
                {
                    Console.Write("____ ");
                }
                else
                {
                    Console.Write(words[i] + " ");
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Press enter to hide another word, or type quit to exit");

            // Read the user input
            string input = Console.ReadLine();

            // If the user types quit, exit the game
            if (input == "quit")
            {
                break;
            }

            // Otherwise, hide another random word
            else
            {
                // Choose a random word that has not yet been hidden
                int randomIndex;
                do
                {
                    randomIndex = new Random().Next(0, words.Length);
                }
                while (HiddenWords.Contains(randomIndex));

                // Add the index of the chosen word to the list of hidden words
                HiddenWords.Add(randomIndex);
            }
        }
    }
}
