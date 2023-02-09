using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the ScriptureCollection class
        ScriptureCollection scriptureCollection = new ScriptureCollection();

        // Add multiple scriptures to the collection
        scriptureCollection.AddScripture(new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        scriptureCollection.AddScripture(new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; In all your ways submit to him, and he will make your paths straight."));
        scriptureCollection.AddScripture(new Scripture("1 Nephi 1:8", "And being thus overcome with the Spirit, he was carried away in a vision, even that he saw the heavens open, and he thought he saw God sitting upon his throne, surrounded with numberless concourses of angels in the attitude of singing and praising their God."));
        scriptureCollection.AddScripture(new Scripture("1 Nephi 3:19", "And behold, it is wisdom in God that we should obtain these records, that we may preserve unto our children the language of our fathers;"));

        // Play all the scriptures in the collection
        scriptureCollection.PlayScriptures();
    }
}

class ScriptureCollection
{
    public List<Scripture> Scriptures { get; set; }

    public ScriptureCollection()
    {
        Scriptures = new List<Scripture>();
    }

    public void AddScripture(Scripture scripture)
    {
        Scriptures.Add(scripture);
    }

    public void PlayScriptures()
    {
        Console.WriteLine("Playing all scriptures in the collection:");
        foreach (Scripture scripture in Scriptures)
        {
            scripture.Play();
        }
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
            Console.WriteLine("Scripture Memory Game: The game will cycle through each set of scriptures until all scriptures have played");
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
