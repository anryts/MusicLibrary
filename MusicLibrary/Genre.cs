namespace MusicLibrary;

public class Genre
{
    public string Name { get; set; }
    public string Description { get; set; }


    public Genre(string name, string description)
    {
        Name = name;
        Description = description;
    }
}