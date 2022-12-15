using MusicLibrary;
using System;

namespace MusicLibraryTests;

public class MusicTest
{
    private readonly MusicLibrary.MusicLibrary _musicLibrary;
    
    // "@$!&*(" - not polite word (for test)
    public MusicTest()
    {
        _musicLibrary = new MusicLibrary.MusicLibrary();
    }
    
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
    
    [Fact]
    public void RemoveSongTestTrueIfWeHaveException()
    {
        Assert.Throws<Exception>(() => _musicLibrary.RemoveSong("Beat it"));
    }
    
    [Fact]
    public void RemoveSongTestTrueIfWeHaveNotException()
    {
        _musicLibrary.AddSong("Beat it", "Mickael Jackson", "Rock-n-roll");
        Assert.True(_musicLibrary.RemoveSong("Beat it"));
    }
    
    [Fact]
    public void RemoveSongTestTrueIfWeHaveArgumentException()
    {
        _musicLibrary.AddSong("Beat it", "Mickael Jackson", "Rock-n-roll");
        Assert.False(_musicLibrary.RemoveSong("Beat it1"));
    }
 
}