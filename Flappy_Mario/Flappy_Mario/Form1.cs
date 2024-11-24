using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Mario
{
    public partial class Flappy_Mario : Form
    {
        public Flappy_Mario()
        {
            InitializeComponent();
        }

        //Engellerin  geliş hızı
        int pipe_speed = 28;
        //space tuşunun bırakınca karakterin ne kadar aşağı gideceği değer
        int gravity = 5;
        //oyuncu skoru
        int score = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

           //boruların sola doğru hareketi
            pictureBoxdown.Left -= pipe_speed;
            pictureBoxup.Left -= pipe_speed;

            //skor güncelleme
            label2.Text = "Score: "+score;

            //Mario düşme efekti olarak belirlediğimiz gravity değeri ekleniyor
            pictureBoxmario.Top += gravity;

            // Borular ekranın dışına çıktığında pozisyonlarını sıfırla ve skoru artır
            if (pictureBoxdown.Left < -150)
            {
                //boruyu sa ğa sıfırlar
                pictureBoxdown.Left = 800;
                score++;
                
            }

            if (pictureBoxup.Left < -180)
            {
                //Boruyu sağa sıfırlar
                pictureBoxup.Left = 950;
                score++;
                
            }
            // Mario ile borular ya da ekran sınırları (üst/alt) arasında çarpışma kontrolü
            if (pictureBoxmario.Bounds.IntersectsWith(pictureBoxdown.Bounds) ||
    pictureBoxmario.Bounds.IntersectsWith(pictureBoxup.Bounds) ||
    pictureBoxmario.Top < 0 || pictureBoxmario.Bottom > ClientSize.Height)
            {
                //Çarpışma olursa GameOver fonksiyonu çağrılır
                GameOver();
            }


            if (score >= 20)
            {
                pictureBox1.Visible = true;
                GameOver();
            }


        }

        private void Flappy_Mario_Load(object sender, EventArgs e)
        {

            timer1.Start();                    
                
        }
     

       

        private void Flappy_Mario_KeyUp(object sender, KeyEventArgs e)
        {
            //Space tuşunu atama
            if(e.KeyCode == Keys.Space)
            {
                //Marioyu Yukarı hareket ettirme
                pictureBoxmario.Top -= 60;
            }
        }
        private void GameOver()
        {
           
            timer1.Stop();
            label2.Text += " - Game Over!";
            MessageBox.Show("Game Over! Your score is: " + score);
            //score sıfırlanır
            score = 0;
            pictureBox1.Visible = false;

            //Marioyu ortalar yeni oyuna hazrı hale getirir
            pictureBoxmario.Top = ClientSize.Height / 2;

            //Boruları yeni oyuna hazır hale getirir sağa yanaştırır
            pictureBoxdown.Left = 800;
            pictureBoxup.Left = 950;

            //timer yeniden başlatılır
            timer1.Start();
        }
    }
}
