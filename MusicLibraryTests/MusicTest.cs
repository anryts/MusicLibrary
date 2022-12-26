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

    [Fact]
    public void AddToFavouriteTrue()
    {
        //Arrange
        var music_library = new MusicLibrary.MusicLibrary();
        var Test_music = new Music("Beat it", "Mickael Jackson", "Rock-n-roll");
        var Test_music2 = new Music("DOGLAND", "PEOPLE1", "Rap");
        List<Music> musicList = new List<Music>();

        //Act
        musicList.Add(Test_music);
        musicList.Add(Test_music2);

        //Assert
        Assert.True(music_library.AddSongToFavourites("Beat it", musicList));
    }

    [Fact]
    public void AddToFavouriteFalse()
    {
        //Arrange
        var music_library = new MusicLibrary.MusicLibrary();
        var Test_music = new Music("Beat it", "Mickael Jackson", "Rock-n-roll");
        var Test_music2 = new Music("DOGLAND", "PEOPLE1", "Rap");
        List<Music> musicList = new List<Music>();

        //Act
        musicList.Add(Test_music);
        musicList.Add(Test_music2);

        //Assert
        Assert.False(music_library.AddSongToFavourites("KICK BACK", musicList));
    }

    [Fact]
    public void AddToFavouriteUppercase()
    {
        //Arrange
        var music_library = new MusicLibrary.MusicLibrary();
        var Test_music = new Music("BEAT IT", "Mickael Jackson", "Rock-n-roll");
        var Test_music2 = new Music("DOGLAND", "PEOPLE1", "Rap");
        List<Music> musicList = new List<Music>();

        //Act
        musicList.Add(Test_music);
        musicList.Add(Test_music2);

        //Assert
        Assert.True(music_library.AddSongToFavourites("Dogland", musicList));
    }

    [Fact]
    public void AddToFavouriteNull()
    {
        //Arrange
        var music_library = new MusicLibrary.MusicLibrary();
        var Test_music = new Music("BEAT IT", "Mickael Jackson", "Rock-n-roll");
        var Test_music2 = new Music("DOGLAND", "PEOPLE1", "Rap");
        List<Music> musicList = new List<Music>();

        //Act
        musicList.Add(Test_music);
        musicList.Add(Test_music2);

        //Assert
        Assert.False(music_library.AddSongToFavourites(null, null));
    }
}