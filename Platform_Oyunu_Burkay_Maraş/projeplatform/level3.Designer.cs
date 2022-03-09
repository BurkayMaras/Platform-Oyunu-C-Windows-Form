
namespace projeplatform
{
    partial class level3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("serhat");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("karaatorak");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("nenennenene");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(level3));
            this.score_label = new System.Windows.Forms.Label();
            this.Movement = new System.Windows.Forms.Timer(this.components);
            this.Animation = new System.Windows.Forms.Timer(this.components);
            this.restart_menu = new System.Windows.Forms.GroupBox();
            this.returnlv2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.returnlv1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flag = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.bigbase = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.boss = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.speedup = new System.Windows.Forms.PictureBox();
            this.finish = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nick_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ScoreTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.restart_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedup)).BeginInit();
            this.finish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_label.Location = new System.Drawing.Point(670, 9);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(92, 25);
            this.score_label.TabIndex = 11;
            this.score_label.Text = "Score: 0";
            // 
            // Movement
            // 
            this.Movement.Enabled = true;
            this.Movement.Interval = 10;
            this.Movement.Tick += new System.EventHandler(this.Movement_Tick);
            // 
            // Animation
            // 
            this.Animation.Enabled = true;
            this.Animation.Interval = 320;
            this.Animation.Tick += new System.EventHandler(this.Animation_Tick_1);
            // 
            // restart_menu
            // 
            this.restart_menu.BackColor = System.Drawing.Color.DarkGray;
            this.restart_menu.Controls.Add(this.returnlv2);
            this.restart_menu.Controls.Add(this.label5);
            this.restart_menu.Controls.Add(this.returnlv1);
            this.restart_menu.Controls.Add(this.label4);
            this.restart_menu.Controls.Add(this.label3);
            this.restart_menu.Controls.Add(this.label2);
            this.restart_menu.Controls.Add(this.label1);
            this.restart_menu.Font = new System.Drawing.Font("AlphaSmart 3000", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.restart_menu.Location = new System.Drawing.Point(218, 119);
            this.restart_menu.Name = "restart_menu";
            this.restart_menu.Size = new System.Drawing.Size(349, 272);
            this.restart_menu.TabIndex = 18;
            this.restart_menu.TabStop = false;
            this.restart_menu.Text = "Menu";
            this.restart_menu.Visible = false;
            // 
            // returnlv2
            // 
            this.returnlv2.AutoSize = true;
            this.returnlv2.Location = new System.Drawing.Point(259, 230);
            this.returnlv2.Name = "returnlv2";
            this.returnlv2.Size = new System.Drawing.Size(78, 17);
            this.returnlv2.TabIndex = 20;
            this.returnlv2.Text = "level 2";
            this.returnlv2.Click += new System.EventHandler(this.returnlv2_Click);
            this.returnlv2.MouseEnter += new System.EventHandler(this.returnlv2_MouseEnter);
            this.returnlv2.MouseLeave += new System.EventHandler(this.returnlv2_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Return to-->";
            // 
            // returnlv1
            // 
            this.returnlv1.AutoSize = true;
            this.returnlv1.Location = new System.Drawing.Point(259, 213);
            this.returnlv1.Name = "returnlv1";
            this.returnlv1.Size = new System.Drawing.Size(78, 17);
            this.returnlv1.TabIndex = 20;
            this.returnlv1.Text = "level 1";
            this.returnlv1.Click += new System.EventHandler(this.returnlv1_Click);
            this.returnlv1.MouseEnter += new System.EventHandler(this.returnlv1_MouseEnter);
            this.returnlv1.MouseLeave += new System.EventHandler(this.returnlv1_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("AlphaSmart 3000", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AlphaSmart 3000", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(129, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AlphaSmart 3000", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(105, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restart";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AlphaSmart 3000", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(89, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over!";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::projeplatform.Properties.Resources.hellbasesmall;
            this.pictureBox4.Location = new System.Drawing.Point(1021, 412);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(146, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "base";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::projeplatform.Properties.Resources._1hell;
            this.pictureBox14.Location = new System.Drawing.Point(692, 347);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(52, 44);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 20;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "base";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::projeplatform.Properties.Resources.hellbasesmall;
            this.pictureBox12.Location = new System.Drawing.Point(480, 256);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(146, 50);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 20;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "base";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::projeplatform.Properties.Resources.hellbasesmall;
            this.pictureBox3.Location = new System.Drawing.Point(665, 369);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "base";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projeplatform.Properties.Resources.hellbasesmall;
            this.pictureBox2.Location = new System.Drawing.Point(421, 435);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "base";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::projeplatform.Properties.Resources.lava1;
            this.pictureBox9.Location = new System.Drawing.Point(942, 512);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(187, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "lava";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::projeplatform.Properties.Resources.lava1;
            this.pictureBox8.Location = new System.Drawing.Point(446, 512);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(168, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "lava";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::projeplatform.Properties.Resources.lava1;
            this.pictureBox7.Location = new System.Drawing.Point(612, 512);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "lava";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::projeplatform.Properties.Resources.lava1;
            this.pictureBox5.Location = new System.Drawing.Point(1129, 512);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(168, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "lava";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeplatform.Properties.Resources.lava1;
            this.pictureBox1.Location = new System.Drawing.Point(777, 512);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "lava";
            // 
            // flag
            // 
            this.flag.Image = global::projeplatform.Properties.Resources.downflag;
            this.flag.Location = new System.Drawing.Point(-200, 190);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(25, 60);
            this.flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flag.TabIndex = 14;
            this.flag.TabStop = false;
            // 
            // door
            // 
            this.door.Image = global::projeplatform.Properties.Resources.door;
            this.door.Location = new System.Drawing.Point(-300, 300);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(85, 99);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door.TabIndex = 13;
            this.door.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox13.Location = new System.Drawing.Point(478, 212);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(30, 30);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "coin";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox10.Location = new System.Drawing.Point(1048, 302);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 12;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "coin";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::projeplatform.Properties.Resources.coin;
            this.pictureBox11.Location = new System.Drawing.Point(1339, 476);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 12;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "coin";
            // 
            // bigbase
            // 
            this.bigbase.Image = global::projeplatform.Properties.Resources.hellbigbase;
            this.bigbase.Location = new System.Drawing.Point(0, 512);
            this.bigbase.Name = "bigbase";
            this.bigbase.Size = new System.Drawing.Size(1929, 50);
            this.bigbase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bigbase.TabIndex = 2;
            this.bigbase.TabStop = false;
            this.bigbase.Tag = "base";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::projeplatform.Properties.Resources.standinggirl;
            this.player.Location = new System.Drawing.Point(295, 455);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(38, 56);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // boss
            // 
            this.boss.Image = global::projeplatform.Properties.Resources.boss4;
            this.boss.Location = new System.Drawing.Point(-275, 110);
            this.boss.Margin = new System.Windows.Forms.Padding(2);
            this.boss.Name = "boss";
            this.boss.Size = new System.Drawing.Size(317, 401);
            this.boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss.TabIndex = 16;
            this.boss.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::projeplatform.Properties.Resources._1hell;
            this.pictureBox15.Location = new System.Drawing.Point(736, 347);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(52, 44);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 20;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "base";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::projeplatform.Properties.Resources._1hell;
            this.pictureBox16.Location = new System.Drawing.Point(710, 319);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(52, 44);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 20;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "base";
            // 
            // speedup
            // 
            this.speedup.Location = new System.Drawing.Point(1399, 190);
            this.speedup.Name = "speedup";
            this.speedup.Size = new System.Drawing.Size(1, 372);
            this.speedup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.speedup.TabIndex = 20;
            this.speedup.TabStop = false;
            this.speedup.Tag = "speedup";
            this.speedup.Visible = false;
            // 
            // finish
            // 
            this.finish.BackColor = System.Drawing.Color.DimGray;
            this.finish.Controls.Add(this.button2);
            this.finish.Controls.Add(this.button1);
            this.finish.Controls.Add(this.nick_textbox);
            this.finish.Controls.Add(this.label8);
            this.finish.Controls.Add(this.ScoreTable);
            this.finish.Controls.Add(this.label7);
            this.finish.Controls.Add(this.label6);
            this.finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.finish.Location = new System.Drawing.Point(11, 9);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(751, 526);
            this.finish.TabIndex = 21;
            this.finish.TabStop = false;
            this.finish.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nick_textbox
            // 
            this.nick_textbox.Location = new System.Drawing.Point(427, 183);
            this.nick_textbox.Name = "nick_textbox";
            this.nick_textbox.Size = new System.Drawing.Size(138, 29);
            this.nick_textbox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Write your nick here! -->";
            // 
            // ScoreTable
            // 
            this.ScoreTable.BackColor = System.Drawing.Color.PowderBlue;
            this.ScoreTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ScoreTable.HideSelection = false;
            this.ScoreTable.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.ScoreTable.Location = new System.Drawing.Point(205, 285);
            this.ScoreTable.Name = "ScoreTable";
            this.ScoreTable.Size = new System.Drawing.Size(342, 217);
            this.ScoreTable.TabIndex = 2;
            this.ScoreTable.UseCompatibleStateImageBehavior = false;
            this.ScoreTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nickname";
            this.columnHeader1.Width = 192;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Score";
            this.columnHeader2.Width = 141;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("AlphaSmart 3000", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(280, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Burkay Maras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("AlphaSmart 3000", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(725, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gazi Universitesi Bilgisayar Muhendisligi Final Projesi";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.restart_menu);
            this.Controls.Add(this.boss);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flag);
            this.Controls.Add(this.door);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.bigbase);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.speedup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "level3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "level3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.restart_menu.ResumeLayout(false);
            this.restart_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedup)).EndInit();
            this.finish.ResumeLayout(false);
            this.finish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bigbase;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Timer Movement;
        private System.Windows.Forms.Timer Animation;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox flag;
        private System.Windows.Forms.PictureBox boss;
        private System.Windows.Forms.GroupBox restart_menu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox speedup;
        private System.Windows.Forms.Label returnlv2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label returnlv1;
        private System.Windows.Forms.GroupBox finish;
        private System.Windows.Forms.ListView ScoreTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nick_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}