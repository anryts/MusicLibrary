namespace MusicLibrary;

public class MusicLibrary : IMainInterface
{
    private List<Music> musicList = new List<Music>();
    private List<string> not_polite_words = new List<string>() { "@$!&*(", "%^&&@", "!@)^&$#"};

    public void ReadSongFromFile(string fileName)
    {
        var file = File.ReadLines("listOfMusic.txt");
        file = file.Skip(2).ToArray();
        foreach (var item in file)
        {
            try
            {
                var split = item.Split('\t', StringSplitOptions.RemoveEmptyEntries).ToList();
                AddSong(split[0], split[1], split[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public void ConsolePrintMusicList()
    {
        foreach (var music in musicList)
        {
            Console.WriteLine(music.GetMusicInfo());
        }
    }

    public void AddGenre(Genre genre)
    {
        throw new NotImplementedException();
    }

    public void RemoveGenre(string genre)
    {
        throw new NotImplementedException();
    }

    public bool AddSong(string title, string artist, string genre)
    {
        Music new_music = new Music(title, artist, genre);
        if (title == null || artist == null || genre == null)
        {
            throw new Exception();
        }
        for (int i = 0; i < musicList.Count; i++)
        {
            if (musicList[i].Title.ToLower().Equals(title.ToLower()))
            {
                throw new Exception();
            }           
        }
        for (int i = 0; i < not_polite_words.Count; i++)
        {
            if (title.Contains(not_polite_words[i]) || artist.Contains(not_polite_words[i]) || genre.Contains(not_polite_words[i]))
            {
                throw new Exception();
            }
        }
        musicList.Add(new_music);
        return true;
    }

    public bool RemoveSong(string song)
    {
        if(musicList.Count == 0)
            throw new Exception();

        return musicList.Remove(musicList.Find(x => x.Title == song)!);
    }

    /// <summary>
    /// key can be "genre" or "name"
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public List<Music> GetSongsBySomethingSorted(string key)
    {
        throw new NotImplementedException();
    }
}