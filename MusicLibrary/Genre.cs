namespace MusicLibrary;

public class Genre
{
    public string Name { get; }
    public string Description { get; }


    public Genre(string name, string description)
    {
        Name = name;
        Description = description;
    }
}