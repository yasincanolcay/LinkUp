using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkUp
{
    public partial class Card : Form
    {
        public EO.WinForm.WebControl browser = new EO.WinForm.WebControl();
        public string url = "";
        public int type = 0;
        public int Index = 0;
        public int fav = 0;
        public LinkUp up = new LinkUp();
        public Guna.UI2.WinForms.Guna2CircleButton playBtn= new Guna.UI2.WinForms.Guna2CircleButton();
        public Guna.UI2.WinForms.Guna2CirclePictureBox thumbBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
        string[] types = { 
            "Video",
            "Musics",
            "My links"
        };
        public Card()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (type==2)
            {
                up.isPlaying = true;
                up.selectIndex = Index;
                up.axWindowsMediaPlayer1.URL = label1.Text;
                up.axWindowsMediaPlayer1.Ctlcontrols.play();
                playBtn.Image = Image.FromFile("icons/pause_50px.png");
                using (WebClient client = new WebClient())
                {
                    using (MemoryStream ms = new MemoryStream(client.DownloadData(url)))
                    {
                        thumbBox.Image = Image.FromStream(ms); // Resmi PictureBox'a yükle
                    }
                }
                if (fav == 1)
                {
                    up.favoriteButton.Image = Image.FromFile("icons/heart_50px.png");
                }
                else
                {
                    up.favoriteButton.Image = Image.FromFile("icons/favorite_50px.png");
                }
            }
            else
            {
                browser.WebView.Url = label1.Text;
                browser.ResumeLayout();
            }
        }

        private void Card_Load(object sender, EventArgs e)
        {
            label1.Cursor = Cursors.Hand;
            using (WebClient client = new WebClient())
            {
                using (MemoryStream ms = new MemoryStream(client.DownloadData(url)))
                {
                    guna2CirclePictureBox1.Image = Image.FromStream(ms); // Resmi PictureBox'a yükle
                }
            }
        }

        private void openBrowser_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(label1.Text);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkGreen;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }
    }
}
