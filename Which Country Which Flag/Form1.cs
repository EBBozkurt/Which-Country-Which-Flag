using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*[TR]
Başkent, Bayrak ve Ülke yarışmamıza hoşgeldiniz. Amacımız ülkelerin başkentlerini, bayraklarını ve ülkeleri karışık biçimde bilmek.
Başlata tıklayarak başlayabilirsiniz.

[EN]
Welcome to our Capital, Flag and Country contest. Our aim is to know the capitals, flags and countries of the countries mixed and find it.
Press ''Başlat'' and start.

Github hesabım = https://github.com/EBBozkurt
Bu Proje C# Dersi için tasarlanmıştır.

Ekin Berk Bozkurt - 181906067 

*/

//Gradient Color kullanıldı [EN] Gradient Color used.
//Gif ve Animasyonlar eklendi. [EN] Gifs and animations were added.
//Yaklaşık 300 satır kod yazıldı. [EN] About 300 lines of code were written.
//Doğru Yanlış sayıları belirtildi. [EN] True and false numbers are specified.
//Form Düzenlemesi ve Form başarılı bir şekilde çalıştı. [EN] Form Editing and Form worked successfully.

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        int puan = 0;
        int sure = 60;
        int dogru = 0;
        int yanlıs = 0;
        int yeniBoyut = 30;

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn1.Enabled = false;
            button9.Size = new Size(355, 133);
            button9.Location = new Point(276, 429);
            Btn1.Visible = false;
            Btn2.Enabled = false;
            Btn2.Visible = false;
            label6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            lblPuan.Visible = false;
            pB1.Visible = false;
            pB2.Visible = false;
            pB3.Visible = false;
            pB4.Visible = false;
            pB5.Visible = false;
            label1.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            label8.BackColor = System.Drawing.Color.Transparent;
            label9.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            lblSure.BackColor = System.Drawing.Color.Transparent;
            lblPuan.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Location = new Point(50, 50);
            label10.Text = "[TR]\nBaşkent, Bayrak ve Ülke yarışmamıza hoşgeldiniz. Amacımız ülkelerin başkentlerini,\n" +
            "bayraklarını ve ülkeleri karışık biçimde bilmek.\n" +
            "Başlata tıklayarak başlayabilirsiniz.\n\n" +
            "[EN]\nWelcome to our Capital, Flag and Country contest. Our aim is to know the capitals, \n" +
            "flags and countries of the countries mixed and find it.\n" +
            "Press ''Başlat'' and start.\n\n" +
            "Github = github.com/EBBozkurt \n" +
            "This Project is designed for Visual Programming Lesson\n\n" +
            "Ekin Berk Bozkurt";
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label4.Visible = false;
            lblSure.Visible = false;
            button9.Font = new Font(button9.Font.FontFamily, yeniBoyut);

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            sayac++;
            button9.Text = "Next";
            timer1.Start();
            pB1.Visible = true;
            Btn1.Enabled = true;
            Btn1.Visible = true;
            Btn2.Enabled = true;
            Btn2.Visible = true;
            button9.Enabled = false;
            label6.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            lblSure.Visible = true;
            lblPuan.Visible = true;
            pB2.Visible = false;
            pB3.Visible = false;
            pB4.Visible = false;
            pB5.Visible = false;
            Btn1.BackgroundImage = base.BackgroundImage;
            Btn2.BackgroundImage = base.BackgroundImage;
            pB1.BackgroundImage = base.BackgroundImage;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label4.Visible = true;
            label8.Text = ""+dogru;
            label9.Text = ""+yanlıs;
            label10.Visible = false;
            yeniBoyut = 12;
            button9.Font = new Font(button9.Font.FontFamily, yeniBoyut);

            Btn1.BackColor = Color.LightGray;
            Btn2.BackColor = Color.LightGray;
            button9.Size = new Size(101, 51);
            button9.Location = new Point(398, 461);
            Btn1.TabStop = false;
            Btn1.FlatStyle = FlatStyle.Flat;
            Btn1.FlatAppearance.BorderSize = 0;
            Btn2.TabStop = false;
            Btn2.FlatStyle = FlatStyle.Flat;
            Btn2.FlatAppearance.BorderSize = 0;

            if (sayac == 1)
            {
                label6.Text = "Which country is this place ?";
                Btn1.Text = "Turkey";
                Btn2.Text = "Azerbaijan";
                pB1.BackgroundImage = Proje1.Properties.Resources.Ankara;
                label3.Text = "Turkey";
                label6.Location = new Point(345, 320);
               
            }

            if (sayac == 2)
            {
                label6.Text = "Flag of the previous country ";
                Btn1.Text = "  ";
                Btn2.Text = "    ";
                label3.Text = "  ";
                pB1.BackgroundImage = Proje1.Properties.Resources.soruIsareti;
                Btn1.BackgroundImage = Proje1.Properties.Resources.Türkiye;
                Btn2.BackgroundImage = Proje1.Properties.Resources.ly;
                label6.Location = new Point(345, 320);
            }

            if (sayac == 3)
            {
                label6.Text = "Where is this capital ? ";
                Btn1.Text = "Germany";
                Btn2.Text = "France";
                pB1.BackgroundImage = Proje1.Properties.Resources.EyfelKulesi;
                label3.Text = "France";
                label6.Location = new Point(335, 320);

            }

            if (sayac == 4)
            {
                label6.Text = "Which country's flag is this?";
                Btn1.Text = "Italy";
                Btn2.Text = "Spain";
                pB1.BackgroundImage = Proje1.Properties.Resources.İtalya;
                label3.Text = "Italy";
                label6.Location = new Point(335, 320);
            }

            if (sayac == 5)
            {
                label6.Text = "What is the flag of the two previous countries ? ";
                Btn1.Text = " ";
                Btn2.Text = "   ";
                Btn1.BackgroundImage = Proje1.Properties.Resources.Fransa;
                Btn2.BackgroundImage = Proje1.Properties.Resources.lu;
                pB1.BackgroundImage = Proje1.Properties.Resources.soruIsareti;
                label3.Text = " ";
                label6.Location = new Point(300, 320);
            }

            if (sayac == 6)
            {
                label6.Text = "Where is this place?";
                Btn1.Text = "Canada";
                Btn2.Text = "USA";
                pB1.BackgroundImage = Proje1.Properties.Resources.OzAnıtı;
                label3.Text = "USA";
                label6.Location = new Point(300, 320);
            }

            if (sayac == 7)
            {
                label6.Text = "What is the flag of the country in the picture?";
                Btn1.Text = " ";
                Btn2.Text = "  ";
                pB1.BackgroundImage = Proje1.Properties.Resources.Londra;
                Btn1.BackgroundImage = Proje1.Properties.Resources.İngiltere_2;
                Btn2.BackgroundImage = Proje1.Properties.Resources.İngiltere;
                label3.Text = "  ";
                label6.Location = new Point(295, 320);

            }

            if (sayac == 8)
            {
                label6.Text = "Where is the Capital of Japan?";
                Btn1.Text = "Tokyo";
                Btn2.Text = "Hiroshima";
                pB1.BackgroundImage = Proje1.Properties.Resources.Japonya;
                label3.Text = "Tokyo";
                label6.Location = new Point(320, 320);
            }

            if (sayac == 9)
            {
                label6.Text = "What is the Flag of Germany?";
                Btn1.Text = " ";
                Btn2.Text = "  ";
                pB1.BackgroundImage = Proje1.Properties.Resources.soruIsareti;
                Btn1.BackgroundImage = Proje1.Properties.Resources.Almanya_2;
                Btn2.BackgroundImage = Proje1.Properties.Resources.Almanya;
                label3.Text = "  ";
            }

            if (sayac == 10)
            {
                label6.Text = "Which country in the picture?";
                Btn1.Text = "Russia";
                Btn2.Text = "Moldova";
                pB1.BackgroundImage = Proje1.Properties.Resources.Rusya;
                label3.Text = "Russia";
                label6.Location = new Point(330, 320);
            }

            if (sayac == 11)
            {
                puan = puan + Convert.ToInt32(lblSure.Text);
                lblPuan.Text = puan.ToString();
                timer1.Stop();
                Btn1.Enabled = false;
                Btn2.Enabled = false;
                button9.Enabled = false;
                lblSure.Text = "The game is over, your remaining time " + sure + " is stated by adding to the score.";
                lblSure.Location = new Point(90, 168);
                label2.Location = new Point(354, 355);
                label4.Location = new Point(354, 256);
                label7.Location = new Point(354, 300);
                label8.Location = new Point(505, 256);
                label9.Location = new Point(505, 300);
                lblPuan.Location = new Point(505, 355);
                label1.Visible = false;
                label6.Text = "THANKS for playing, Producer = Ekin Berk Bozkurt.\nThank you for playing the game";
                label6.Location = new Point(120, 425);
                Btn1.Visible = false;
                Btn2.Visible = false;
                button9.Visible = false;
                pB1.Visible = false;
            }
        }

        
        private void Btn1_Click(object sender, EventArgs e)
        {
            label5.Text = Btn1.Text;

            if (label3.Text == label5.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                Btn1.BackColor = Color.Green;
                pB2.Visible = true;
                dogru++;
                timer1.Stop();
            }
            else
            {
                Btn1.BackColor = Color.Red;
                pB5.Visible = true;
                yanlıs++;
            }
            Btn1.Enabled = false;
            Btn2.Enabled = false;
            button9.Enabled = true;
            timer1.Stop();
        }

        private void Btn2_Click_1(object sender, EventArgs e)
        {
            label5.Text = Btn2.Text;
            if (label3.Text == label5.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                Btn2.BackColor = Color.Green;
                pB4.Visible = true;
                dogru++;
                timer1.Stop();
            }
            else
            {
                Btn2.BackColor = Color.Red;
                pB3.Visible = true;
                yanlıs++;
            }
            Btn1.Enabled = false;
            Btn2.Enabled = false;
            button9.Enabled = true;
            timer1.Stop();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (sure > 0)
            {
                sure--;
                lblSure.Text = sure.ToString();

            }
            else
            {
                lblSure.Text = "YOUR TIME IS FINISHED, YOUR POINTS ARE INDICATED BELOW.";
                lblSure.Location = new Point(175, 168);
                Btn1.Visible = false;
                Btn2.Visible = false;
                button9.Visible = false;
                Btn1.Enabled = false;
                Btn2.Enabled = false;
                button9.Enabled = false;
                pB1.Visible = false;
                pB2.Visible = false;
                pB3.Visible = false;
                pB4.Visible = false;
                pB5.Visible = false;
                label6.Text = "THANKS for playing, Producer = Ekin Berk Bozkurt.\nThank you for playing the game";
                label6.Text = "THANKS for playing, Producer = Ekin Berk Bozkurt.\nThank you for playing the game";
                label6.Location = new Point(120, 425);
                label2.Location = new Point(354, 355);
                lblPuan.Location = new Point(505, 355);
                label4.Location = new Point(354, 256);
                label7.Location = new Point(354, 300);
                label8.Location = new Point(505, 256);
                label9.Location = new Point(505, 300);
                label1.Visible = false;
            }
        }
    }
}
