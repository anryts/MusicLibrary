namespace MusicLibrary;

public class PrintIntoConsoleService: IPrintService
{
    public void Print(List<Song>? songs)
    {
        foreach (var song in songs)
        {
            Console.WriteLine(song.GetMusicInfo());
        }
    }
}