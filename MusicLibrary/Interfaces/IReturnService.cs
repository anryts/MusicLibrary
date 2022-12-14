namespace MusicLibrary;

public interface IReturnService
{
    List<Song> GetSongs(List<Song>? songs);
    List<Song> GetSongsSortedByTitle(List<Song>? songs);
    List<Song> GetSongsSortedByGenre(List<Song>? songs ,Genre genre);
}