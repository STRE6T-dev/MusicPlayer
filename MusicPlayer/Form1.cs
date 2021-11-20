using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer {
    public partial class Form1 : Form {
        Music mc = new Music();
        public Form1() {
            InitializeComponent();
            listBox1.Items.Add("Black");
            listBox1.Items.Add("chime");
            listBox1.Items.Add("OneRepublic");
        }

        private void btnPlay_Click(object sender, EventArgs e) {
            int musicIndex = listBox1.SelectedIndex;
            String previousSong = "";
            String song = "";

            switch (musicIndex) {
                case 0:
                    song = "Black";
                    previousSong = "Black";
                    break;
                case 1:
                    song = "chime";
                    previousSong = "chime";
                    break;
                case 2:
                    song = "OneRepublic";
                    previousSong = "OneRepublic";
                    break;
                default:
                    break;

            }


            
            mc.StopSong(previousSong);
            mc.PlaySong(song);

        }

       
    }
}
