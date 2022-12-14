namespace MusicLibrary;

public interface IReturnService
{
    List<Song> GetSongsSortedByTitle(List<Song>? songs);
    List<Song> GetSongsSortedByGenre(List<Song>? songs ,Genre genre);
}