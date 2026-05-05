namespace Audio.Management;

public class AudioManager
{
    const float defaultvolume = 1.0f;
    private const string playertag = "player";
    private readonly float pitchMutable;
    public AudioManager()
    {
        pitchMutable = 0.5f;
    }

    public void PlayAudio(float volume = defaultvolume, float pitch = 1f)
    {
        Console.WriteLine($"Playing audio {volume}x{pitch}");
    }
    
    
}