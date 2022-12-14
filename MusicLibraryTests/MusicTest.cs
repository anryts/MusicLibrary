using Moq;
using MusicLibrary;

namespace MusicLibraryTests;

public class MusicTest
{
    // [Fact]
    // public void Test()
    // {
    //     var mock = new Mock<IReadService>();
    //     mock.Setup(x => x.ReadSongs(null))
    //         .Returns(new List<Song>()
    //         {
    //             new Song("MockTest", "Andrii.H", new Genre("Test", null))
    //         });
    //     var mock2 = new Mock<IReturnService>();
    //     var expectedString = "MockTest";
    //
    //     MusicLibrary.MusicLibrary musicLibrary = new MusicLibrary
    //         .MusicLibrary(mock2.Object, mock.Object, new PrintIntoConsoleService());
    //
    //     Assert.Equal(expectedString, musicLibrary
    //         .GetSongsBySomethingSorted("genre", new Genre("Test", null))[0].GetMusicInfo());
    // }

    // public void Test2()
    // {
    //     List<Song> testSongs = new List<Song>();
    //
    //     var mock2 = new Mock<IPrintService>();
    //     mock2.Setup(x => x.Print(testSongs))
    //         .Callback(() => Console.WriteLine("Mocked"));
    //     var mock1 = new Mock<IReturnService>();
    //     var expectedString = "MockTest";
    //
    //     MusicLibrary.MusicLibrary musicLibrary = new MusicLibrary
    //         .MusicLibrary(mock1.Object, mock2.Object, new PrintIntoConsoleService());
    //
    //     Assert.Equal(expectedString, musicLibrary
    //         .GetSongsBySomethingSorted("genre", new Genre("Test", null))[0].GetMusicInfo());
    // }

    [Fact]
    public void Test3()
    {
        List<Song> expectedSongs = new List<Song>(new []{
            new Song("MockTest", "Andrii.H", new Genre("Test", null)), 
            }
            );

        var mock = new Mock<IReturnService>();
        var mock2 = new Mock<IPrintService>();

        
        
        var testData = new InMemoryCollection(new List<Song>(
                new []
                {
                    new Song("MockTest", "Andrii.H", new Genre("Test", null)), 
                }
            ), null
        );

        MusicLibrary.MusicLibrary musicLibrary = new MusicLibrary
            .MusicLibrary(new ReturnService(), new ReadService(), mock2.Object, testData);
        
        var actualSongs = musicLibrary.GetSongsBySomethingSorted("genre", new Genre("Test", null));
        Assert.Equal(expectedSongs[0].Title, actualSongs[0].Title);
    }

}