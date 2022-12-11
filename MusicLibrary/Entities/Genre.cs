namespace MusicLibrary;

public class Genre
{
    public string Name { get; private set; }
    private string? Description { get; set; }


    public Genre(string name, string? description)
    {
        Name = name;
        Description = description;
    }
}