
namespace projeplatform
{
    partial class level1
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
            this.Movement = new System.Windows.Forms.Timer(this.components);
            this.Animation = new System.Windows.Forms.Timer(this.components);
            this.score_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.flag = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.pictureBox87 = new System.Windows.Forms.PictureBox();
            this.pictureBox90 = new System.Windows.Forms.PictureBox();
            this.pictureBox81 = new System.Windows.Forms.PictureBox();
            this.pictureBox84 = new System.Windows.Forms.PictureBox();
            this.pictureBox86 = new System.Windows.Forms.PictureBox();
            this.pictureBox89 = new System.Windows.Forms.PictureBox();
            this.pictureBox80 = new System.Windows.Forms.PictureBox();
            this.pictureBox83 = new System.Windows.Forms.PictureBox();
            this.pictureBox85 = new System.Windows.Forms.PictureBox();
            this.pictureBox88 = new System.Windows.Forms.PictureBox();
            this.pictureBox79 = new System.Windows.Forms.PictureBox();
            this.pictureBox82 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox75 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox73 = new System.Windows.Forms.PictureBox();
            this.pictureBox78 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).BeginInit();
            this.SuspendLayout();
            // 
            // Movement
            // 
            this.Movement.Enabled = true;
            this.Movement.Interval = 10;
            this.Movement.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Animation
            // 
            this.Animation.Enabled = true;
            this.Animation.Interval = 320;
            this.Animation.Tick += new System.EventHandler(this.Animation_Tick);
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_label.Location = new System.Drawing.Point(893, 11);
            this.score_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(115, 31);
            this.score_label.TabIndex = 10;
            this.score_label.Text = "Score: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeplatform.Properties.Resources.basesmall;
            this.pictureBox1.Location = new System.Drawing.Point(464, 460);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "base";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::projeplatform.Properties.Resources.basebig;
            this.pictureBox6.Location = new System.Drawing.Point(0, 630);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1647, 62);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "base";
            // 
            // flag
            // 
            this.flag.Image = global::projeplatform.Properties.Resources.downflag;
            this.flag.Location = new System.Drawing.Point(1611, 270);
            this.flag.Margin = new System.Windows.Forms.Padding(4);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(36, 78);
            this.flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flag.TabIndex = 9;
            this.flag.TabStop = false;
            // 
            // door
            // 
            this.door.Image = global::projeplatform.Properties.Resources.door;
            this.door.Location = new System.Drawing.Point(1525, 507);
            this.door.Margin = new System.Windows.Forms.Padding(4);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(113, 122);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door.TabIndex = 8;
            this.door.TabStop = false;
            // 
            // pictureBox87
            // 
            this.pictureBox87.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox87.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox87.Location = new System.Drawing.Point(1088, 202);
            this.pictureBox87.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox87.Name = "pictureBox87";
            this.pictureBox87.Size = new System.Drawing.Size(40, 37);
            this.pictureBox87.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox87.TabIndex = 7;
            this.pictureBox87.TabStop = false;
            this.pictureBox87.Tag = "coin";
            // 
            // pictureBox90
            // 
            this.pictureBox90.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox90.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox90.Location = new System.Drawing.Point(481, 415);
            this.pictureBox90.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox90.Name = "pictureBox90";
            this.pictureBox90.Size = new System.Drawing.Size(40, 37);
            this.pictureBox90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox90.TabIndex = 7;
            this.pictureBox90.TabStop = false;
            this.pictureBox90.Tag = "coin";
            // 
            // pictureBox81
            // 
            this.pictureBox81.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox81.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox81.Location = new System.Drawing.Point(1088, 485);
            this.pictureBox81.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox81.Name = "pictureBox81";
            this.pictureBox81.Size = new System.Drawing.Size(40, 37);
            this.pictureBox81.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox81.TabIndex = 7;
            this.pictureBox81.TabStop = false;
            this.pictureBox81.Tag = "coin";
            // 
            // pictureBox84
            // 
            this.pictureBox84.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox84.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox84.Location = new System.Drawing.Point(684, 415);
            this.pictureBox84.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox84.Name = "pictureBox84";
            this.pictureBox84.Size = new System.Drawing.Size(40, 37);
            this.pictureBox84.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox84.TabIndex = 7;
            this.pictureBox84.TabStop = false;
            this.pictureBox84.Tag = "coin";
            // 
            // pictureBox86
            // 
            this.pictureBox86.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox86.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox86.Location = new System.Drawing.Point(1020, 202);
            this.pictureBox86.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox86.Name = "pictureBox86";
            this.pictureBox86.Size = new System.Drawing.Size(40, 37);
            this.pictureBox86.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox86.TabIndex = 7;
            this.pictureBox86.TabStop = false;
            this.pictureBox86.Tag = "coin";
            // 
            // pictureBox89
            // 
            this.pictureBox89.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox89.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox89.Location = new System.Drawing.Point(413, 415);
            this.pictureBox89.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox89.Name = "pictureBox89";
            this.pictureBox89.Size = new System.Drawing.Size(40, 37);
            this.pictureBox89.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox89.TabIndex = 7;
            this.pictureBox89.TabStop = false;
            this.pictureBox89.Tag = "coin";
            // 
            // pictureBox80
            // 
            this.pictureBox80.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox80.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox80.Location = new System.Drawing.Point(1020, 484);
            this.pictureBox80.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox80.Name = "pictureBox80";
            this.pictureBox80.Size = new System.Drawing.Size(40, 37);
            this.pictureBox80.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox80.TabIndex = 7;
            this.pictureBox80.TabStop = false;
            this.pictureBox80.Tag = "coin";
            // 
            // pictureBox83
            // 
            this.pictureBox83.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox83.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox83.Location = new System.Drawing.Point(616, 415);
            this.pictureBox83.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox83.Name = "pictureBox83";
            this.pictureBox83.Size = new System.Drawing.Size(40, 37);
            this.pictureBox83.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox83.TabIndex = 7;
            this.pictureBox83.TabStop = false;
            this.pictureBox83.Tag = "coin";
            // 
            // pictureBox85
            // 
            this.pictureBox85.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox85.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox85.Location = new System.Drawing.Point(955, 202);
            this.pictureBox85.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox85.Name = "pictureBox85";
            this.pictureBox85.Size = new System.Drawing.Size(40, 37);
            this.pictureBox85.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox85.TabIndex = 7;
            this.pictureBox85.TabStop = false;
            this.pictureBox85.Tag = "coin";
            // 
            // pictureBox88
            // 
            this.pictureBox88.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox88.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox88.Location = new System.Drawing.Point(348, 415);
            this.pictureBox88.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox88.Name = "pictureBox88";
            this.pictureBox88.Size = new System.Drawing.Size(40, 37);
            this.pictureBox88.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox88.TabIndex = 7;
            this.pictureBox88.TabStop = false;
            this.pictureBox88.Tag = "coin";
            // 
            // pictureBox79
            // 
            this.pictureBox79.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox79.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox79.Location = new System.Drawing.Point(955, 485);
            this.pictureBox79.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox79.Name = "pictureBox79";
            this.pictureBox79.Size = new System.Drawing.Size(40, 37);
            this.pictureBox79.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox79.TabIndex = 7;
            this.pictureBox79.TabStop = false;
            this.pictureBox79.Tag = "coin";
            // 
            // pictureBox82
            // 
            this.pictureBox82.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox82.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox82.Location = new System.Drawing.Point(551, 415);
            this.pictureBox82.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox82.Name = "pictureBox82";
            this.pictureBox82.Size = new System.Drawing.Size(40, 37);
            this.pictureBox82.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox82.TabIndex = 7;
            this.pictureBox82.TabStop = false;
            this.pictureBox82.Tag = "coin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projeplatform.Properties.Resources.base3;
            this.pictureBox2.Location = new System.Drawing.Point(69, 266);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "base";
            // 
            // pictureBox30
            // 
            this.pictureBox30.Location = new System.Drawing.Point(125, 507);
            this.pictureBox30.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(0, 62);
            this.pictureBox30.TabIndex = 3;
            this.pictureBox30.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::projeplatform.Properties.Resources.standinggirl;
            this.player.Location = new System.Drawing.Point(16, 560);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(51, 69);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::projeplatform.Properties.Resources.basesmall;
            this.pictureBox4.Location = new System.Drawing.Point(320, 460);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(260, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "base";
            // 
            // pictureBox48
            // 
            this.pictureBox48.Image = global::projeplatform.Properties.Resources.basesmall;
            this.pictureBox48.Location = new System.Drawing.Point(911, 529);
            this.pictureBox48.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(260, 62);
            this.pictureBox48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox48.TabIndex = 1;
            this.pictureBox48.TabStop = false;
            this.pictureBox48.Tag = "base";
            // 
            // pictureBox63
            // 
            this.pictureBox63.Image = global::projeplatform.Properties.Resources.basesmall;
            this.pictureBox63.Location = new System.Drawing.Point(246, 239);
            this.pictureBox63.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(112, 32);
            this.pictureBox63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox63.TabIndex = 1;
            this.pictureBox63.TabStop = false;
            this.pictureBox63.Tag = "base";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::projeplatform.Properties.Resources.basesmall;
            this.pictureBox3.Location = new System.Drawing.Point(125, 348);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "base";
            // 
            // pictureBox58
            // 
            this.pictureBox58.Image = global::projeplatform.Properties.Resources.basesmall;
            this.pictureBox58.Location = new System.Drawing.Point(711, 72);
            this.pictureBox58.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(260, 33);
            this.pictureBox58.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox58.TabIndex = 1;
            this.pictureBox58.TabStop = false;
            this.pictureBox58.Tag = "base";
            // 
            // pictureBox38
            // 
            this.pictureBox38.Image = global::projeplatform.Properties.Resources.basesmall;
            this.pictureBox38.Location = new System.Drawing.Point(911, 250);
            this.pictureBox38.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(260, 62);
            this.pictureBox38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox38.TabIndex = 1;
            this.pictureBox38.TabStop = false;
            this.pictureBox38.Tag = "base";
            // 
            // pictureBox75
            // 
            this.pictureBox75.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox75.Image = global::projeplatform.Properties.Resources.cloud;
            this.pictureBox75.Location = new System.Drawing.Point(0, -59);
            this.pictureBox75.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox75.Name = "pictureBox75";
            this.pictureBox75.Size = new System.Drawing.Size(284, 128);
            this.pictureBox75.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox75.TabIndex = 5;
            this.pictureBox75.TabStop = false;
            // 
            // pictureBox45
            // 
            this.pictureBox45.Image = global::projeplatform.Properties.Resources.basesmall;
            this.pictureBox45.Location = new System.Drawing.Point(1387, 348);
            this.pictureBox45.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(251, 62);
            this.pictureBox45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox45.TabIndex = 1;
            this.pictureBox45.TabStop = false;
            this.pictureBox45.Tag = "base";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::projeplatform.Properties.Resources.base2small_;
            this.pictureBox9.Location = new System.Drawing.Point(662, 100);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(220, 31);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 4;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "base";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::projeplatform.Properties.Resources.base2small_;
            this.pictureBox8.Location = new System.Drawing.Point(599, 123);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(220, 31);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "base";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::projeplatform.Properties.Resources.base2small_;
            this.pictureBox7.Location = new System.Drawing.Point(543, 151);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(220, 31);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "base";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::projeplatform.Properties.Resources.base2small_;
            this.pictureBox5.Location = new System.Drawing.Point(481, 180);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(220, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "base";
            // 
            // pictureBox73
            // 
            this.pictureBox73.Image = global::projeplatform.Properties.Resources.base2small_;
            this.pictureBox73.Location = new System.Drawing.Point(425, 208);
            this.pictureBox73.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox73.Name = "pictureBox73";
            this.pictureBox73.Size = new System.Drawing.Size(220, 31);
            this.pictureBox73.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox73.TabIndex = 4;
            this.pictureBox73.TabStop = false;
            this.pictureBox73.Tag = "base";
            // 
            // pictureBox78
            // 
            this.pictureBox78.Image = global::projeplatform.Properties.Resources.cloud2;
            this.pictureBox78.Location = new System.Drawing.Point(689, 15);
            this.pictureBox78.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox78.Name = "pictureBox78";
            this.pictureBox78.Size = new System.Drawing.Size(305, 116);
            this.pictureBox78.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox78.TabIndex = 6;
            this.pictureBox78.TabStop = false;
            // 
            // level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1702, 690);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.flag);
            this.Controls.Add(this.door);
            this.Controls.Add(this.pictureBox87);
            this.Controls.Add(this.pictureBox90);
            this.Controls.Add(this.pictureBox81);
            this.Controls.Add(this.pictureBox84);
            this.Controls.Add(this.pictureBox86);
            this.Controls.Add(this.pictureBox89);
            this.Controls.Add(this.pictureBox80);
            this.Controls.Add(this.pictureBox83);
            this.Controls.Add(this.pictureBox85);
            this.Controls.Add(this.pictureBox88);
            this.Controls.Add(this.pictureBox79);
            this.Controls.Add(this.pictureBox82);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox48);
            this.Controls.Add(this.pictureBox63);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox58);
            this.Controls.Add(this.pictureBox38);
            this.Controls.Add(this.pictureBox75);
            this.Controls.Add(this.pictureBox45);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox73);
            this.Controls.Add(this.pictureBox78);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "base";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer Movement;
        private System.Windows.Forms.Timer Animation;
        private System.Windows.Forms.PictureBox pictureBox38;
        private System.Windows.Forms.PictureBox pictureBox45;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox48;
        private System.Windows.Forms.PictureBox pictureBox58;
        private System.Windows.Forms.PictureBox pictureBox63;
        private System.Windows.Forms.PictureBox pictureBox73;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox75;
        private System.Windows.Forms.PictureBox pictureBox78;
        private System.Windows.Forms.PictureBox pictureBox82;
        private System.Windows.Forms.PictureBox pictureBox83;
        private System.Windows.Forms.PictureBox pictureBox84;
        private System.Windows.Forms.PictureBox pictureBox79;
        private System.Windows.Forms.PictureBox pictureBox80;
        private System.Windows.Forms.PictureBox pictureBox81;
        private System.Windows.Forms.PictureBox pictureBox85;
        private System.Windows.Forms.PictureBox pictureBox86;
        private System.Windows.Forms.PictureBox pictureBox87;
        private System.Windows.Forms.PictureBox pictureBox88;
        private System.Windows.Forms.PictureBox pictureBox89;
        private System.Windows.Forms.PictureBox pictureBox90;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox flag;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}

