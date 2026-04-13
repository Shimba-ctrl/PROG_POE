
using System;
using WMPLib;

/// Handles audio playback for greeting
public class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = "greeting.wav";
            player.controls.play();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Audio error: " + ex.Message);
        }
    }
}
