using System.Media;

namespace AgeAPP.Classes
{
    internal class SoundManager
    {
        static SoundPlayer musicPlayer;

        public static void PlayMusic()
        {
            //musicPlayer = new SoundPlayer(Properties.Resources.bg_music);
            musicPlayer.PlayLooping();
        }

        public static void StopMusic()
        {
            musicPlayer?.Stop();
        }

        public void Play_button_sound()
        {

        }
    }
}
