
namespace projeplatform
{
    partial class gamemenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamemenu));
            this.exitbutton = new System.Windows.Forms.PictureBox();
            this.playbutton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.exitbutton.Image = global::projeplatform.Properties.Resources.exitbutton;
            this.exitbutton.Location = new System.Drawing.Point(298, 228);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(177, 74);
            this.exitbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitbutton.TabIndex = 1;
            this.exitbutton.TabStop = false;
            this.exitbutton.Click += new System.EventHandler(this.pictureBox2_Click);
            this.exitbutton.MouseLeave += new System.EventHandler(this.exitbutton_MouseLeave);
            this.exitbutton.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.Color.Transparent;
            this.playbutton.Image = global::projeplatform.Properties.Resources.playbutton;
            this.playbutton.Location = new System.Drawing.Point(298, 130);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(177, 62);
            this.playbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playbutton.TabIndex = 0;
            this.playbutton.TabStop = false;
            this.playbutton.Click += new System.EventHandler(this.pictureBox1_Click);
            this.playbutton.MouseLeave += new System.EventHandler(this.playbutton_MouseLeave);
            this.playbutton.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // gamemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.playbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gamemenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.exitbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playbutton;
        private System.Windows.Forms.PictureBox exitbutton;
    }
}