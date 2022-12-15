using MusicLibrary;
using System;

namespace MusicLibraryTests;

public class MusicTest
{
    // "@$!&*(" - not polite word (for test)
    [Fact]
    public void AddSongTestTrueIfWeHaveException()
    {        
        var music_library = new MusicLibrary.MusicLibrary();       
        Assert.Throws<Exception>(() => music_library.AddSong("Beat it", "Mickael Jackson", "Rock-n-roll"));
    }
    [Fact]
    public void AddSongTestTrueIfWeHaveNotException()
    {
        var music_library = new MusicLibrary.MusicLibrary();
        Assert.True(music_library.AddSong("Beat it", "Mickael Jackson", "Rock-n-roll"));          
    }
}