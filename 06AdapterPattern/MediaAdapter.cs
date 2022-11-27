
namespace AdapterPattern;

public class MediaAdapter : IMediaPlayer
{
    IAdvancedMediaPlayer? advancedMusicPlayer;

    public MediaAdapter(string audioType)
    {
        if (string.Equals(audioType, "vlc", StringComparison.OrdinalIgnoreCase))
        {
            advancedMusicPlayer = new VlcPlayer();
        }
        else if (string.Equals(audioType, "mp4", StringComparison.OrdinalIgnoreCase))
        {
            advancedMusicPlayer = new Mp4Player();
        }
    }
    public void Play(string audioType, string fileName)
    {
        if (string.Equals(audioType, "vlc", StringComparison.OrdinalIgnoreCase))
        {
            advancedMusicPlayer!.PlayVlc(fileName);
        }
        else if (string.Equals(audioType, "mp4", StringComparison.OrdinalIgnoreCase))
        {
            advancedMusicPlayer!.PlayMp4(fileName);
        }
    }
}
