using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkUp
{
    public partial class LinkUp : Form
    {
        List<Panel> pnlCardList = new List<Panel>();
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\LinkUp\LinkUp\Database1.mdf';Integrated Security=True");
        List<string> audioUrls = new List<string>();
        public int selectIndex = 0;
        public bool isPlaying = false;
        List<Guna.UI2.WinForms.Guna2CirclePictureBox> thumbPic = new List<Guna.UI2.WinForms.Guna2CirclePictureBox>();
        List<int> cardId = new List<int>();
        List<bool> favList = new List<bool>();
        bool fullScreen = false;
        public LinkUp()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LinkUp_Load(object sender, EventArgs e)
        {
            LoadPanels(3,3);
        }

        private void LoadPanels(int type, int fav)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            isPlaying = false;
            playButton.Image = Image.FromFile("icons/play_50px.png");
            int indexCard = 0;
            pageViewer.Controls.Clear();
            audioUrls.Clear();
            thumbPic.Clear();
            favList.Clear();
            using (SqlCommand command = new SqlCommand("SELECT * From [Table]", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (Int32.Parse(reader["type"].ToString()) == type||Int32.Parse(reader["favorite"].ToString())==fav)
                    {
                        Card card = new Card();
                        card.TopLevel = false;
                        card.label1.Text = reader["url"].ToString();
                        card.label2.Text = reader["description"].ToString();
                        card.browser = webControl1;
                        card.url = reader["photoUrl"].ToString();
                        card.type = Int32.Parse(reader["type"].ToString());
                        card.Index = indexCard;
                        card.up = this;
                        card.playBtn = playButton;
                        card.thumbBox = cardThumbPicture;
                        card.fav = Int32.Parse(reader["favorite"].ToString());
                        pageViewer.Controls.Add(card);
                        card.Show();
                        if (type == 2)
                        {
                            audioUrls.Add(reader["url"].ToString());
                            thumbPic.Add(card.guna2CirclePictureBox1);
                            cardId.Add(Int32.Parse(reader["Id"].ToString()));
                            if (Int32.Parse(reader["favorite"].ToString()) == 1)
                            {
                                favList.Add(true);
                            }
                            else
                            {
                                favList.Add(false);
                            }
                        }
                        indexCard++;
                    }
                }
           
                reader.Close();
                connection.Close();
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddLinkCard add = new AddLinkCard();
            add.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            LoadPanels(3,3);
        }

        private void guna2ResizeBox1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
            if (topBarPanel.Height > topBarPanel.MaximumSize.Height-80)
            {
                label2.Text = "Yukarı Sürükleyin";
            }
            else
            {
                label2.Text = "Aşagı Sürükleyin";
            }
        }

        private void guna2ResizeBox1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void myLinksBtn_Click(object sender, EventArgs e)
        {
            myLinksBtn.BackColor=Color.FromArgb(15, 25, 0);
            videosBtn.BackColor = Color.FromArgb(15, 15, 5);
            musicBtn.BackColor = Color.FromArgb(15, 15, 5);
            favoritesBtn.BackColor = Color.FromArgb(15, 15, 5);
            LoadPanels(3,3);
        }

        private void videosBtn_Click(object sender, EventArgs e)
        {
            videosBtn.BackColor = Color.FromArgb(15, 25, 0);
            myLinksBtn.BackColor = Color.FromArgb(15, 15, 5);
            favoritesBtn.BackColor = Color.FromArgb(15, 15, 5);
            musicBtn.BackColor = Color.FromArgb(15, 15, 5);
            LoadPanels(1,3);
        }

        private void musicBtn_Click(object sender, EventArgs e)
        {
            musicBtn.BackColor = Color.FromArgb(15, 25, 0);
            videosBtn.BackColor = Color.FromArgb(15, 15, 5);
            favoritesBtn.BackColor = Color.FromArgb(15, 15, 5);
            myLinksBtn.BackColor = Color.FromArgb(15, 15, 5);
            LoadPanels(2,3);
        }

        private void favoritesBtn_Click(object sender, EventArgs e)
        {
            favoritesBtn.BackColor = Color.FromArgb(15, 25, 0);
            videosBtn.BackColor = Color.FromArgb(15, 15, 5);
            musicBtn.BackColor = Color.FromArgb(15, 15, 5);
            myLinksBtn.BackColor = Color.FromArgb(15, 15, 5);
            LoadPanels(0,1);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (audioUrls.Count!=0)
            {
                cardThumbPicture.Image = thumbPic[selectIndex].Image;
                if (favList[selectIndex] == true)
                {
                    favoriteButton.Image = Image.FromFile("icons/heart_50px.png");
                }
                else
                {
                    favoriteButton.Image = Image.FromFile("icons/favorite_50px.png");
                }
                if (!isPlaying)
                {
                    axWindowsMediaPlayer1.URL = audioUrls[selectIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    isPlaying = true;
                    playButton.Image = Image.FromFile("icons/pause_50px.png");

                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    isPlaying = false;
                    playButton.Image = Image.FromFile("icons/play_50px.png");

                }
                
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (audioUrls.Count != 0)
            {
                if (selectIndex < audioUrls.Count-1)
                {
                    selectIndex++;
                    isPlaying = false;
                    playButton.PerformClick();
                }
            }
        }

        private void backwardButton_Click(object sender, EventArgs e)
        {
            if (audioUrls.Count != 0)
            {
                if (selectIndex > 0)
                {
                    selectIndex--;
                    isPlaying = false;
                    playButton.PerformClick();
                }
            }
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            if (favList[selectIndex] == false)
            {
                string query = "UPDATE [Table] SET favorite = @fav where Id ="+cardId[selectIndex];
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@fav", 1);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                favoriteButton.Image = Image.FromFile("icons/heart_50px.png");
                favList[selectIndex] = true;
            }
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About aboutPage = new About();
            aboutPage.Show();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            if (!fullScreen)
            {
                guna2Elipse1.BorderRadius = 0;
                fullScreen = true;
            }
            else
            {
                guna2Elipse1.BorderRadius = 30;
                fullScreen = false;
            }
        }
    }

}
