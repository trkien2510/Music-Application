using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace MusicApp.Functions
{
    internal class Mp3Player
    {
        WindowsMediaPlayer sound = new WindowsMediaPlayer();

        public void setting(string obj, bool mode)
        {
            sound.settings.setMode(obj, mode);
        }
        public void setUrl(string URL)
        {
            sound.URL = URL;
        }
        public void play()
        {
            sound.controls.play();
        }
        public void pause()
        {
            sound.controls.pause();
        }
        public void stop()
        {
            sound.controls.stop();
        }
        public void setVolume(int volume)
        {
            sound.settings.volume = volume;
        }
        public int getVolume()
        {
            return sound.settings.volume;
        }
        public void mute(bool value)
        {
            sound.settings.mute = value;
        }
        public double getDuration()
        {
            return sound.controls.currentItem.duration;
        }
        public string getDurationString()
        {
            return sound.controls.currentItem.durationString;
        }
        public string getNameSong()
        {
            return sound.controls.currentItem.name;
        }
        public bool isPlaying()
        {
            if (sound.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                return true;
            }
            return false;
        }
        public double currentPosition()
        {
            return sound.controls.currentPosition;
        }
        public string currentPositionString()
        {
            return sound.controls.currentPositionString;
        }
        public void setPosition(int posotion)
        {
            sound.controls.currentPosition = posotion;
        }
    }
}
