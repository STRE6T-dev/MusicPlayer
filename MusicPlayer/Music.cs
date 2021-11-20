using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer {
    class Music {

       
      
        
        public void PlaySong(String aSong) {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\STRE6T\Music\" +aSong+".wav");
            simpleSound.Play();
        }

        public void StopSong(String aSong) {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\STRE6T\Music\" + aSong);
            simpleSound.Stop();
        }

        public void NextSong(String aSong) {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\STRE6T\Music\" + aSong +".wav");
            
        }

        public void PreviousSong(String aSong) {

        }
    }
}
