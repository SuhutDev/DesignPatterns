namespace AdapterPattern;

public class AudioPlayer : IMediaPlayer
{
    MediaAdapter? mediaAdapter;

    public void Play(string audioType, string fileName)
    {
        if (string.Equals(audioType, "mp3", StringComparison.OrdinalIgnoreCase))
        {
            System.Console.WriteLine($"Playing mp3 filename {fileName}");
        }
        else if ((string.Equals(audioType, "vlc", StringComparison.OrdinalIgnoreCase)) ||
                (string.Equals(audioType, "mp4", StringComparison.OrdinalIgnoreCase))
                )
        {
            mediaAdapter = new MediaAdapter(audioType);
            mediaAdapter.Play(audioType, fileName);
        }
        else
        {
            System.Console.WriteLine($"Invalid media {audioType} format not support");
        }
    }
}
