
namespace AdapterPattern;

public class VlcPlayer : IAdvancedMediaPlayer
{
    public void PlayMp4(string fileName)
    {
        //do nothing
    }

    public void PlayVlc(string fileName)
    {
        System.Console.WriteLine($"Playing vlc filename : {fileName}");
    }
}
