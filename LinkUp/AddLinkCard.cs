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
    public partial class AddLinkCard : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\LinkUp\LinkUp\Database1.mdf';Integrated Security=True");
        int type = 3;
        public AddLinkCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            if (urlBox.Text != "")
            {
                if (photoBox.Text == "")
                {
                    photoBox.Text = "https://cdn-icons-png.flaticon.com/512/9502/9502352.png";
                }
                string query = "INSERT INTO [Table] (url,description,type,favorite,photoUrl) VALUES (@urll,@des,@typee,@fav,@photo)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@urll", urlBox.Text);
                    command.Parameters.AddWithValue("@des", descriptionBox.Text);
                    command.Parameters.AddWithValue("@typee", type);
                    command.Parameters.AddWithValue("@fav", 0);
                    command.Parameters.AddWithValue("@photo", photoBox.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    this.Close();
                    this.Dispose();
                    GC.SuppressFinalize(this);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            type = 3;
        }

        private void photoBox_TextChanged(object sender, EventArgs e)
        {
            if (photoBox.Text != "")
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        using (MemoryStream ms = new MemoryStream(client.DownloadData(photoBox.Text)))
                        {
                            guna2CirclePictureBox1.Image = Image.FromStream(ms); // Resmi PictureBox'a yükle
                        }
                    }
                }
                catch
                {

                }
            }
        }
    }
}
