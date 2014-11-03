using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class Pronouciation
    {
        private const string AUDIO_FOLDER = "audio";
        private static SoundPlayer PLAYER = new SoundPlayer();

        internal static void Play(string pinyin)
        {
            string wavFile = string.Format("{0}\\{1}.wav", AUDIO_FOLDER, pinyin);
            if (!File.Exists(wavFile)) 
            {
                return;
            }

            try
            {
                PLAYER.SoundLocation = wavFile;
                PLAYER.Play();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to play sound {0} due to {1}", wavFile, ex.ToString());
            }
        }
    }
}
