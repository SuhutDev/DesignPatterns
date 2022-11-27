using AdapterPattern;

AudioPlayer audioPlayer = new();

audioPlayer.Play("mp3", "file 1.mp3");
audioPlayer.Play("mp4", "file 2.mp4");
audioPlayer.Play("vlc", "file 3.vlc");
audioPlayer.Play("avi", "file 4.avi");