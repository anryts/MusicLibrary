namespace MusicLibrary;

public class Genre
{
    public string Name { get; }
    private string Description { get; }


    public Genre(string name, string description)
    {
        Name = name;
        Description = description;
    }
}