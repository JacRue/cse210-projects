class ScriptureCollection
{
    private List<Scripture> Scriptures { get; set; }

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