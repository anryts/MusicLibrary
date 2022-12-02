﻿namespace MusicLibrary;

public class MusicLibrary : IMainInterface
{
    private List<Music> _musicList = new List<Music>();

    private void AddMusic(string title, string artist, string genre)
    {
        Music music = new Music(title, artist, genre);
        _musicList.Add(music);
    }

    public void ReadSongFromFile(string fileName)
    {
        var file = File.ReadLines("listOfMusic.txt");
        file = file.Skip(2).ToArray();
        foreach (var item in file)
        {
            try
            {
                var split = item.Split('\t', StringSplitOptions.RemoveEmptyEntries).ToList();
                AddMusic(split[0], split[1], split[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public void ConsolePrintMusicList()
    {
        foreach (var music in _musicList)
        {
            Console.WriteLine(music.GetMusicInfo());
        }
    }

    public void RemoveMusic(Music music)
    {
        _musicList.Remove(music);
    }

    List<Music> IMainInterface.GetSongsByNamesSorted()
    {
        throw new NotImplementedException();
    }

    List<Music> IMainInterface.GetSongsByGenre(string genre)
    {
        throw new NotImplementedException();
    }

    public void AddGenre(Genre genre)
    {
        throw new NotImplementedException();
    }

    public void RemoveGenre(string genre)
    {
        throw new NotImplementedException();
    }

    public void AddSong(Music song)
    {
        throw new NotImplementedException();
    }

    public void RemoveSong(string song)
    {
        throw new NotImplementedException();
    }
}