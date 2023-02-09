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


