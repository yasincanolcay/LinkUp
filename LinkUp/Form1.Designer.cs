
namespace LinkUp
{
    partial class LinkUp
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkUp));
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.topPanelAppBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.myLinksBtn = new System.Windows.Forms.Button();
            this.videosBtn = new System.Windows.Forms.Button();
            this.musicBtn = new System.Windows.Forms.Button();
            this.favoritesBtn = new System.Windows.Forms.Button();
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.nextButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.playButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.backwardButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ResizeBox1 = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageViewer = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2ResizeBox2 = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.favoriteButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cardThumbPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2HScrollBar1 = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.topBarPanel.SuspendLayout();
            this.topPanelAppBar.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardThumbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topBarPanel
            // 
            this.topBarPanel.Controls.Add(this.topPanelAppBar);
            this.topBarPanel.Controls.Add(this.webControl1);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.topBarPanel.MaximumSize = new System.Drawing.Size(0, 380);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(800, 81);
            this.topBarPanel.TabIndex = 0;
            // 
            // topPanelAppBar
            // 
            this.topPanelAppBar.Controls.Add(this.guna2CirclePictureBox1);
            this.topPanelAppBar.Controls.Add(this.linkLabel1);
            this.topPanelAppBar.Controls.Add(this.guna2Separator1);
            this.topPanelAppBar.Controls.Add(this.label1);
            this.topPanelAppBar.Controls.Add(this.guna2ControlBox3);
            this.topPanelAppBar.Controls.Add(this.guna2ControlBox2);
            this.topPanelAppBar.Controls.Add(this.guna2ControlBox1);
            this.topPanelAppBar.Controls.Add(this.addBtn);
            this.topPanelAppBar.Controls.Add(this.myLinksBtn);
            this.topPanelAppBar.Controls.Add(this.videosBtn);
            this.topPanelAppBar.Controls.Add(this.musicBtn);
            this.topPanelAppBar.Controls.Add(this.favoritesBtn);
            this.topPanelAppBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelAppBar.Location = new System.Drawing.Point(0, 0);
            this.topPanelAppBar.Name = "topPanelAppBar";
            this.topPanelAppBar.Size = new System.Drawing.Size(800, 81);
            this.topPanelAppBar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 64);
            this.label1.TabIndex = 26;
            this.label1.Text = "LinkUp";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(671, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(36, 21);
            this.guna2ControlBox3.TabIndex = 25;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(712, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(36, 21);
            this.guna2ControlBox2.TabIndex = 24;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(753, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(36, 21);
            this.guna2ControlBox1.TabIndex = 23;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(287, 28);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(93, 30);
            this.addBtn.TabIndex = 22;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // myLinksBtn
            // 
            this.myLinksBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myLinksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.myLinksBtn.FlatAppearance.BorderSize = 0;
            this.myLinksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myLinksBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.myLinksBtn.ForeColor = System.Drawing.Color.White;
            this.myLinksBtn.Location = new System.Drawing.Point(386, 28);
            this.myLinksBtn.Name = "myLinksBtn";
            this.myLinksBtn.Size = new System.Drawing.Size(93, 30);
            this.myLinksBtn.TabIndex = 21;
            this.myLinksBtn.Text = "My Links";
            this.myLinksBtn.UseVisualStyleBackColor = false;
            this.myLinksBtn.Click += new System.EventHandler(this.myLinksBtn_Click);
            // 
            // videosBtn
            // 
            this.videosBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.videosBtn.FlatAppearance.BorderSize = 0;
            this.videosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videosBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.videosBtn.ForeColor = System.Drawing.Color.White;
            this.videosBtn.Location = new System.Drawing.Point(485, 28);
            this.videosBtn.Name = "videosBtn";
            this.videosBtn.Size = new System.Drawing.Size(93, 30);
            this.videosBtn.TabIndex = 20;
            this.videosBtn.Text = "Videos";
            this.videosBtn.UseVisualStyleBackColor = true;
            this.videosBtn.Click += new System.EventHandler(this.videosBtn_Click);
            // 
            // musicBtn
            // 
            this.musicBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.musicBtn.FlatAppearance.BorderSize = 0;
            this.musicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musicBtn.ForeColor = System.Drawing.Color.White;
            this.musicBtn.Location = new System.Drawing.Point(584, 28);
            this.musicBtn.Name = "musicBtn";
            this.musicBtn.Size = new System.Drawing.Size(93, 30);
            this.musicBtn.TabIndex = 19;
            this.musicBtn.Text = "Musics";
            this.musicBtn.UseVisualStyleBackColor = true;
            this.musicBtn.Click += new System.EventHandler(this.musicBtn_Click);
            // 
            // favoritesBtn
            // 
            this.favoritesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.favoritesBtn.FlatAppearance.BorderSize = 0;
            this.favoritesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoritesBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.favoritesBtn.ForeColor = System.Drawing.Color.White;
            this.favoritesBtn.Location = new System.Drawing.Point(683, 28);
            this.favoritesBtn.Name = "favoritesBtn";
            this.favoritesBtn.Size = new System.Drawing.Size(93, 30);
            this.favoritesBtn.TabIndex = 18;
            this.favoritesBtn.Text = "Favorites";
            this.favoritesBtn.UseVisualStyleBackColor = true;
            this.favoritesBtn.Click += new System.EventHandler(this.favoritesBtn_Click);
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(800, 81);
            this.webControl1.TabIndex = 8;
            this.webControl1.Text = "webControl1";
            this.webControl1.WebView = this.webView1;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.panel4);
            this.controlPanel.Controls.Add(this.panel3);
            this.controlPanel.Controls.Add(this.nextButton);
            this.controlPanel.Controls.Add(this.playButton);
            this.controlPanel.Controls.Add(this.backwardButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 385);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(800, 65);
            this.controlPanel.TabIndex = 1;
            this.controlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.controlPanel_Paint);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextButton.Animated = true;
            this.nextButton.AnimatedGIF = true;
            this.nextButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nextButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nextButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nextButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nextButton.FillColor = System.Drawing.Color.Transparent;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.Location = new System.Drawing.Point(436, 7);
            this.nextButton.Name = "nextButton";
            this.nextButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.nextButton.Size = new System.Drawing.Size(50, 50);
            this.nextButton.TabIndex = 18;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playButton.Animated = true;
            this.playButton.AnimatedGIF = true;
            this.playButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.playButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.playButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.playButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.playButton.FillColor = System.Drawing.Color.Transparent;
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Location = new System.Drawing.Point(375, 7);
            this.playButton.Name = "playButton";
            this.playButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.playButton.Size = new System.Drawing.Size(50, 50);
            this.playButton.TabIndex = 16;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // backwardButton
            // 
            this.backwardButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.backwardButton.Animated = true;
            this.backwardButton.AnimatedGIF = true;
            this.backwardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backwardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backwardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backwardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backwardButton.FillColor = System.Drawing.Color.Transparent;
            this.backwardButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backwardButton.ForeColor = System.Drawing.Color.White;
            this.backwardButton.Image = ((System.Drawing.Image)(resources.GetObject("backwardButton.Image")));
            this.backwardButton.Location = new System.Drawing.Point(314, 7);
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.backwardButton.Size = new System.Drawing.Size(50, 50);
            this.backwardButton.TabIndex = 14;
            this.backwardButton.Click += new System.EventHandler(this.backwardButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.guna2ResizeBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 19);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(26, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "aşagı sürükleyin";
            this.label2.Visible = false;
            // 
            // guna2ResizeBox1
            // 
            this.guna2ResizeBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2ResizeBox1.FillColor = System.Drawing.Color.White;
            this.guna2ResizeBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ResizeBox1.Location = new System.Drawing.Point(0, -2);
            this.guna2ResizeBox1.Name = "guna2ResizeBox1";
            this.guna2ResizeBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2ResizeBox1.TabIndex = 27;
            this.guna2ResizeBox1.TargetControl = this.topBarPanel;
            this.guna2ResizeBox1.MouseLeave += new System.EventHandler(this.guna2ResizeBox1_MouseLeave);
            this.guna2ResizeBox1.MouseHover += new System.EventHandler(this.guna2ResizeBox1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 2;
            // 
            // pageViewer
            // 
            this.pageViewer.AutoScroll = true;
            this.pageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageViewer.Location = new System.Drawing.Point(0, 100);
            this.pageViewer.Name = "pageViewer";
            this.pageViewer.Padding = new System.Windows.Forms.Padding(10);
            this.pageViewer.Size = new System.Drawing.Size(800, 284);
            this.pageViewer.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.topPanelAppBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ResizeForm1
            // 
            this.guna2ResizeForm1.TargetForm = this;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 390);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(794, 57);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2ResizeBox2);
            this.panel3.Controls.Add(this.favoriteButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(671, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 65);
            this.panel3.TabIndex = 21;
            // 
            // guna2ResizeBox2
            // 
            this.guna2ResizeBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ResizeBox2.FillColor = System.Drawing.Color.White;
            this.guna2ResizeBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ResizeBox2.Location = new System.Drawing.Point(105, 40);
            this.guna2ResizeBox2.Name = "guna2ResizeBox2";
            this.guna2ResizeBox2.Size = new System.Drawing.Size(20, 20);
            this.guna2ResizeBox2.TabIndex = 22;
            this.guna2ResizeBox2.TargetControl = this;
            // 
            // favoriteButton
            // 
            this.favoriteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.favoriteButton.Animated = true;
            this.favoriteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.favoriteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.favoriteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.favoriteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.favoriteButton.FillColor = System.Drawing.Color.Transparent;
            this.favoriteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.favoriteButton.ForeColor = System.Drawing.Color.White;
            this.favoriteButton.Image = ((System.Drawing.Image)(resources.GetObject("favoriteButton.Image")));
            this.favoriteButton.Location = new System.Drawing.Point(54, 7);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.favoriteButton.Size = new System.Drawing.Size(50, 50);
            this.favoriteButton.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cardThumbPicture);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 65);
            this.panel4.TabIndex = 22;
            // 
            // cardThumbPicture
            // 
            this.cardThumbPicture.ImageRotate = 0F;
            this.cardThumbPicture.Location = new System.Drawing.Point(4, 2);
            this.cardThumbPicture.Name = "cardThumbPicture";
            this.cardThumbPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cardThumbPicture.Size = new System.Drawing.Size(60, 60);
            this.cardThumbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardThumbPicture.TabIndex = 20;
            this.cardThumbPicture.TabStop = false;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BindingContainer = this.pageViewer;
            this.guna2VScrollBar1.BorderRadius = 8;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 284;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(782, 100);
            this.guna2VScrollBar1.Maximum = 305;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 284);
            this.guna2VScrollBar1.SmallChange = 5;
            this.guna2VScrollBar1.TabIndex = 0;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(10)))));
            this.guna2VScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2VScrollBar1_Scroll);
            // 
            // guna2HScrollBar1
            // 
            this.guna2HScrollBar1.BindingContainer = this.pageViewer;
            this.guna2HScrollBar1.BorderRadius = 8;
            this.guna2HScrollBar1.InUpdate = false;
            this.guna2HScrollBar1.LargeChange = 10;
            this.guna2HScrollBar1.Location = new System.Drawing.Point(0, 366);
            this.guna2HScrollBar1.Name = "guna2HScrollBar1";
            this.guna2HScrollBar1.ScrollbarSize = 18;
            this.guna2HScrollBar1.Size = new System.Drawing.Size(800, 18);
            this.guna2HScrollBar1.TabIndex = 0;
            this.guna2HScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(10)))));
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkGreen;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 71);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(800, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel1.Location = new System.Drawing.Point(620, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 16);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.DimGray;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(609, 9);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(8, 8);
            this.guna2CirclePictureBox1.TabIndex = 28;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // LinkUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2HScrollBar1);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.pageViewer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.topBarPanel);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "LinkUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinkUp";
            this.Load += new System.EventHandler(this.LinkUp_Load);
            this.topBarPanel.ResumeLayout(false);
            this.topPanelAppBar.ResumeLayout(false);
            this.topPanelAppBar.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardThumbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pageViewer;
        private EO.WinForm.WebControl webControl1;
        private EO.WebBrowser.WebView webView1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel topPanelAppBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button myLinksBtn;
        private System.Windows.Forms.Button videosBtn;
        private System.Windows.Forms.Button musicBtn;
        private System.Windows.Forms.Button favoritesBtn;
        private Guna.UI2.WinForms.Guna2ResizeBox guna2ResizeBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton nextButton;
        private Guna.UI2.WinForms.Guna2CircleButton backwardButton;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        public Guna.UI2.WinForms.Guna2CircleButton playButton;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ResizeBox guna2ResizeBox2;
        public Guna.UI2.WinForms.Guna2CircleButton favoriteButton;
        private System.Windows.Forms.Panel panel4;
        public Guna.UI2.WinForms.Guna2CirclePictureBox cardThumbPicture;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2HScrollBar guna2HScrollBar1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}

