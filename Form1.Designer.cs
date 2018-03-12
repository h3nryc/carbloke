namespace carbloke
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.RoadMover = new System.Windows.Forms.Timer(this.components);
            this.CAR = new System.Windows.Forms.PictureBox();
            this.right_mover = new System.Windows.Forms.Timer(this.components);
            this.left_mover = new System.Windows.Forms.Timer(this.components);
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.end_text = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.score_timer = new System.Windows.Forms.Timer(this.components);
            this.coin = new System.Windows.Forms.PictureBox();
            this.coin_timer = new System.Windows.Forms.Timer(this.components);
            this.coin_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvl_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(58, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(58, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 77);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(58, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 77);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(58, 328);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 93);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(147, 328);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 94);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(147, 224);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 77);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(147, 118);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 77);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(147, -3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(10, 86);
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            // 
            // RoadMover
            // 
            this.RoadMover.Enabled = true;
            this.RoadMover.Interval = 10;
            this.RoadMover.Tick += new System.EventHandler(this.RoadMover_Tick);
            // 
            // CAR
            // 
            this.CAR.Image = ((System.Drawing.Image)(resources.GetObject("CAR.Image")));
            this.CAR.Location = new System.Drawing.Point(91, 374);
            this.CAR.Name = "CAR";
            this.CAR.Size = new System.Drawing.Size(37, 75);
            this.CAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CAR.TabIndex = 8;
            this.CAR.TabStop = false;
            // 
            // right_mover
            // 
            this.right_mover.Interval = 10;
            this.right_mover.Tick += new System.EventHandler(this.right_mover_Tick);
            // 
            // left_mover
            // 
            this.left_mover.Interval = 10;
            this.left_mover.Tick += new System.EventHandler(this.left_mover_Tick);
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(11, 54);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(40, 69);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 9;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(130, 12);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(40, 69);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 10;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(186, 328);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(40, 69);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 11;
            this.enemy3.TabStop = false;
            // 
            // end_text
            // 
            this.end_text.AutoSize = true;
            this.end_text.BackColor = System.Drawing.Color.White;
            this.end_text.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_text.ForeColor = System.Drawing.Color.DarkRed;
            this.end_text.Location = new System.Drawing.Point(57, 100);
            this.end_text.Name = "end_text";
            this.end_text.Size = new System.Drawing.Size(115, 23);
            this.end_text.TabIndex = 12;
            this.end_text.Text = "YOU LOSE!";
            this.end_text.Visible = false;
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.ForeColor = System.Drawing.Color.Red;
            this.score_label.Location = new System.Drawing.Point(194, 8);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(19, 19);
            this.score_label.TabIndex = 13;
            this.score_label.Text = "0";
            // 
            // score_timer
            // 
            this.score_timer.Enabled = true;
            this.score_timer.Interval = 1000;
            this.score_timer.Tick += new System.EventHandler(this.score_timer_Tick);
            // 
            // coin
            // 
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(186, 118);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(26, 25);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 14;
            this.coin.TabStop = false;
            // 
            // coin_timer
            // 
            this.coin_timer.Interval = 15;
            this.coin_timer.Tick += new System.EventHandler(this.coin_timer_Tick);
            // 
            // coin_label
            // 
            this.coin_label.AutoSize = true;
            this.coin_label.BackColor = System.Drawing.Color.Transparent;
            this.coin_label.ForeColor = System.Drawing.Color.Gold;
            this.coin_label.Location = new System.Drawing.Point(39, 9);
            this.coin_label.Name = "coin_label";
            this.coin_label.Size = new System.Drawing.Size(13, 13);
            this.coin_label.TabIndex = 15;
            this.coin_label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Coins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Level:";
            // 
            // lvl_label
            // 
            this.lvl_label.AutoSize = true;
            this.lvl_label.BackColor = System.Drawing.Color.White;
            this.lvl_label.Location = new System.Drawing.Point(122, 9);
            this.lvl_label.Name = "lvl_label";
            this.lvl_label.Size = new System.Drawing.Size(13, 13);
            this.lvl_label.TabIndex = 18;
            this.lvl_label.Text = "1";
            this.lvl_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(224, 461);
            this.Controls.Add(this.end_text);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coin_label);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.CAR);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvl_label);
            this.MaximumSize = new System.Drawing.Size(240, 500);
            this.MinimumSize = new System.Drawing.Size(240, 500);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer RoadMover;
        private System.Windows.Forms.PictureBox CAR;
        private System.Windows.Forms.Timer right_mover;
        private System.Windows.Forms.Timer left_mover;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label end_text;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Timer score_timer;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Timer coin_timer;
        private System.Windows.Forms.Label coin_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lvl_label;
    }
}

