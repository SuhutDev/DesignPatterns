namespace AdapterPattern;

public class Mp4Player : IAdvancedMediaPlayer
{
    public void PlayMp4(string fileName)
    {
        System.Console.WriteLine($"Playing mp4 fileName : {fileName}");
    }

    public void PlayVlc(string fileName)
    {
        //do nothing
    }
}
