namespace MusicLibrary;

public interface IReturnService
{
    List<Song> GetSongs();
    List<Song> GetSongsSortedByTitle();
    List<Song> GetSongsSortedByGenre(Genre genre);
}