namespace MusicLibrary;

public class ReturnService: IReturnService
{
    public List<Song> GetSongs()
    {
        return InMemoryCollection.Songs;
    }

    public List<Song> GetSongsSortedByTitle()
    {
        return InMemoryCollection.Songs.Where(x=>x.IsFavourite)
            .OrderBy(s => s.Title).ToList();
    }

    public List<Song> GetSongsSortedByGenre(Genre genre)
    {
        return InMemoryCollection.Songs.Where(x=> x.Genre.Name == genre.Name)
            .OrderBy(s => s.Title).ToList();
    }
}