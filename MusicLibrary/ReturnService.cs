namespace MusicLibrary;

public class ReturnService : IReturnService
{
    public List<Song> GetSongsSortedByTitle(List<Song>? songs)
    {
        return songs.Where(x => x.IsFavourite)
            .OrderBy(s => s.Title).ToList();
    }

    public List<Song> GetSongsSortedByGenre(List<Song>? songs, Genre genre)
    {
        return songs.Where(x => x.Genre.Name == genre.Name)
            .OrderBy(s => s.Title).ToList();
    }
}