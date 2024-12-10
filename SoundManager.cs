using WMPLib;
using System;

namespace BrickBreakerGame
{
    public class SoundManager
    {
        private WindowsMediaPlayer hitsound;
        private WindowsMediaPlayer winsound;
        private WindowsMediaPlayer losssound;

        public SoundManager()
        {
            hitsound = new WindowsMediaPlayer();
            winsound = new WindowsMediaPlayer();
            losssound = new WindowsMediaPlayer();
        }

        // Plays the win sound effect
        public void PlayWinSound()
        {
            winsound.URL = @"C:/MYOP/prog2/BrickBreakerGame/Resources/win.mp3";
            winsound.controls.play();
        }

        // Plays the loss sound effect
        public void PlayLossSound()
        {
            losssound.URL = @"C:/MYOP/prog2/BrickBreakerGame/Resources/loss.mp3";
            losssound.controls.play();
        }

        // Plays the hit sound effect
        public void PlayHitSound()
        {
            hitsound.URL = @"C:/MYOP/prog2/BrickBreakerGame/Resources/hit.mp3";
            hitsound.controls.play();
        }
    }
}
