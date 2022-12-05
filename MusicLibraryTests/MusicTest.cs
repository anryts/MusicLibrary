using MusicLibrary;

namespace MusicLibraryTests;

public class MusicTest
{
    [Fact]
    public void AddSongTestErrorfalse()
    {
        bool error = false;
        // Arrange
        // Act
        try
        {
            void DoAction(IMainInterface Action) => Action.AddSong("Beat it", "Mickael Jackson", "Rock-n-roll");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            error = true;
        }      
        // Assert
        Assert.False(error);
    }
    [Fact]
    public void AddSongTestErrortrue()
    {
        bool error = true;
        // Arrange
        // Act
        try
        {
            void DoAction(IMainInterface Action) => Action.AddSong("Beat it", "Mickael Jackson", "Rock-n-roll");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            error = true;
        }
        // Assert
        Assert.True(error);
    }
}