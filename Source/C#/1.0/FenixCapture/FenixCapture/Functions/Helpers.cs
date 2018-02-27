using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace FenixCapture
{
    class Helpers
    {
        public void play_sound(string option)
        {
            SoundPlayer sound = new SoundPlayer();

            if (option == "click")
            {
                sound = new SoundPlayer(FenixCapture.Properties.Resources.click);
            }
            else if (option == "loaded")
            {
                sound = new SoundPlayer(FenixCapture.Properties.Resources.formcreate);
            }
            else if (option == "done")
            {
                sound = new SoundPlayer(FenixCapture.Properties.Resources.done);
            }
            else
            {
                sound = new SoundPlayer(FenixCapture.Properties.Resources.click);
            }

            sound.Play();
        }
    }
}
