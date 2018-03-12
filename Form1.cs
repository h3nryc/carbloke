using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carbloke
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        int score = 0;
        int coins = 0;
        int lvl = 1;
        
        PictureBox[] road = new PictureBox[8];
       
        public Form1()
           
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            coin_timer.Start();
            road[0] = pictureBox1;
            road[1] = pictureBox2;
            road[2] = pictureBox3;
            road[3] = pictureBox4;
            road[4] = pictureBox5;
            road[5] = pictureBox6;
            road[6] = pictureBox7;
            road[7] = pictureBox8;

            cars.Add(new Car("enemy1", enemy1, 2));
            cars.Add(new Car("enemy2", enemy2, 2.1f));
            cars.Add(new Car("enemy3", enemy3, 2.2f));
        }

        private void RoadMover_Tick(object sender, EventArgs e)
        {
          for (int i = 0; i <= 7; i++)
            {
                road[i].Top += 2;
                if (road[i].Top >= this.Height)
                {
                    road[i].Top = -road[i].Height;
                }
                
            }

            foreach (Car car in cars) {
                if (car.HitPlayer(CAR)) {
                    gameover();
                };
            }
            foreach (Car car in cars)
            {
                    car.Move();
               
            }
            if (CAR.Bounds.IntersectsWith(coin.Bounds))
            {
                coin.Visible = false;
                coins = coins + 1;
                string coin_text = coins.ToString();
                coin_label.Text = coin_text;
            }
        }

        private void gameover()
        {
            end_text.Visible = true;
            RoadMover.Stop();
            score_timer.Stop();
            coin_timer.Stop();

        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                right_mover.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                left_mover.Start();
            }
            if(e.KeyCode == Keys.R)
            {
                end_text.Visible = false;
                RoadMover.Start();
                score_timer.Start();
                coin_timer.Start();
                score = 0;
                coins = 0;
                lvl = 1;
                foreach (Car car in cars)
                {
                    car.Reset();
                }
                lvl_label.Text = "1";
                coin_label.Text = "0";
            }

        }


        private void left_mover_Tick(object sender, EventArgs e)
        {
            if(CAR.Location.X > 0)
            {
                CAR.Left -= 5;
            }
            
        }

        private void right_mover_Tick(object sender, EventArgs e)
        {
            if(CAR.Location.X < 190)
            {
                CAR.Left += 5;
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            right_mover.Stop();
            left_mover.Stop();
        }


        private void score_timer_Tick(object sender, EventArgs e)
        {
            score = score + 1;
            string score_text = score.ToString();
            score_label.Text = score_text;
            if (score % 15 == 0)
            {
                updateLvl();
                lvl = lvl + 1;
                string lvl_text = lvl.ToString();
                lvl_label.Text = lvl_text;

            }
        }
        private void updateLvl()
        {
            foreach (Car car in cars)
            {
                car.speed += 1;
            }
        }
        private void coin_timer_Tick(object sender, EventArgs e)
        {
            coin.Top += 2;
            if (coin.Top >= 600)
            {
                Random random = new Random();
                int y = random.Next(0, 150);
                Random random2 = new Random();
                int x = random2.Next(0, 190);
                coin.Visible = true;
                coin.Top = -y + coin.Height;
                coin.Left = x + 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    public class Car
    {
        public string name;
        public PictureBox sprite;
        public float top;
        public float startSpeed;
        public float speed;

        public Car(string name, PictureBox sprite, float startSpeed)
        {
            this.name = name;
            this.sprite = sprite;
            Random random = new Random();
            this.top = random.Next(-150, 0);
            this.startSpeed = startSpeed;
            this.speed = startSpeed;
        }

        public void Reset()
        {
  
            this.speed = startSpeed;
            top = 10000;
            this.top = 100000;
            this.Move();

        }

        public void Move() {


            top += speed;
            if (top >= 600)
            {
                Random random = new Random();
                int y = random.Next(0, 150);
                Random random2 = new Random();
                int x = random2.Next(0, 190);
                top = sprite.Height - y;
                sprite.Left = x + 0;
            }

            sprite.Top = (int)top;
        }

        public void updateName(string updatedName)
        {
            this.name = updatedName;
        }

        public bool HitPlayer(PictureBox player)
        {
            return player.Bounds.IntersectsWith(sprite.Bounds);
        }
    }
}
