using Moq;
using MusicLibrary;

namespace MusicLibraryTests;

public class MusicTest
{
    [Fact]
    public void Test()
    {
        var mock = new Mock<IReadService>();
        mock.Setup(x => x.ReadSongs(null))
            .Returns(new List<Song>()
            {
                new Song("MockTest", "Andrii.H", new Genre("Test", null))
            });
        
        
    }
}