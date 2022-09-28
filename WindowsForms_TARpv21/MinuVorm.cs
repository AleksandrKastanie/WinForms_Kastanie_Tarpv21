using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_TARpv21
{
    public class MinuVorm : MinuOmaVorm
    {

        public MinuVorm() { }

        public MinuVorm(string Pealkiri)
        {

            // Задаем размер окна и названик окна
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Text = Pealkiri;

            // Задаем кнопки 
            // Перввая кнопка (картинка) - плей, запускает музыку  
            Button play = new Button
            {
                Image = Image.FromFile(@"..\..\Play.png"),
                Location = new System.Drawing.Point(635, 700),
                Size = new System.Drawing.Size(50, 50),
                BackColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat,
            };
            play.Click += Music_Click;
           

            // Вторая кнопка остановки музыки
            Button stop = new Button
            {
                Image = Image.FromFile(@"..\..\Stop.png"),
                Location = new System.Drawing.Point(575, 700),
                Size = new System.Drawing.Size(50, 50),
                BackColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            stop.Click += Stop_Click;

            // третья кнопка запускает рандомную песню
            Button randomS = new Button
            {
                Image = Image.FromFile(@"..\..\shuffle.png"),
                Location = new System.Drawing.Point(690, 700),
                Size = new System.Drawing.Size(100, 100),
                BackColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            randomS.Click += Random_Click;

            // Первая песня 
            Button song1 = new Button
            {
                Location = new System.Drawing.Point(200, 100),
                Text = string.Format("Play"),
                Size = new System.Drawing.Size(100, 100),
                BackColor = System.Drawing.Color.Red,
            };
            Label FailName = new Label
            {
                Text = string.Format(" - Pumped up kicks"),
                Location = new System.Drawing.Point(330, 110),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };

            PictureBox pilt = new PictureBox
            {
                Image = Image.FromFile(@"..\..\21.jpg"),
                Location = new Point(700, 200),
                Size = new Size(300, 300),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            song1.Click += Nupp_Click1;

            // Вторая песня
            Button song2 = new Button
            {
                Location = new System.Drawing.Point(200, 175),
                Text = string.Format("Play"),
                Size = new System.Drawing.Size(100, 100),
                BackColor = System.Drawing.Color.Red,
            };

            Label Claster = new Label
            {
                Text = string.Format(" - MONTERO - LIL NAS"),
                Location = new System.Drawing.Point(330, 185),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };

            PictureBox zoomer = new PictureBox
            {
                Image = Image.FromFile(@"..\..\23.jpg"),
                Location = new Point(700, 200),
                Size = new Size(300, 300),
                SizeMode = PictureBoxSizeMode.Zoom

            };

            song2.Click += Nupp_Click2;

            // Третья песня
            Button song3 = new Button
            {
                Location = new System.Drawing.Point(200, 250),
                Text = string.Format("Play"),
                Size = new System.Drawing.Size(100, 100),
                BackColor = System.Drawing.Color.Red,
            };

            Label Flamaster = new Label
            {
                Text = string.Format(" - Life Goes On - Oliver Tree"),
                Location = new System.Drawing.Point(330, 185),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };

            PictureBox wanish = new PictureBox
            {
                Image = Image.FromFile(@"..\..\22.jpg"),
                Location = new Point(700, 200),
                Size = new Size(300, 300),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            song3.Click += Nupp_Click3;

            if (song1.Enabled == true)
            {
                this.Controls.Add(FailName);
                this.Controls.Add(pilt);
            }
            else if (song2.Enabled == true)
            {
                this.Controls.Add(Claster);
                this.Controls.Add(zoomer);

            }
            else if (song3.Enabled == true)
            {
                this.Controls.Add(Flamaster);
                this.Controls.Add(wanish);

            }
            
            

            this.Controls.Add(song3);
            this.Controls.Add(song2);
            this.Controls.Add(song1);
            this.Controls.Add(play);
            this.Controls.Add(stop);
            this.Controls.Add(randomS);

            
        }
        public void Nupp_Click1(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Sa oled kindel et taha muusika kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {

                using (var muusika = new SoundPlayer(@"..\..\1.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("Pumped up kicks");
                }           
            }
            else
            {
                MessageBox.Show(">_<");
            }
        }
        public void Nupp_Click2(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Sa oled kindel et taha muusika kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {

                using (var muusika = new SoundPlayer(@"..\..\2.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("MONTERO - LIL NAS");
                }
            }
            else
            {
                MessageBox.Show(">_<");
            }
        }
        public void Nupp_Click3(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Sa oled kindel et taha muusika kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {

                using (var muusika = new SoundPlayer(@"..\..\3.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("Life Goes On - Oliver Tree");
                }
            }
            else
            {
                MessageBox.Show(">_<");
            }
        }

        public void Music_Click(object sender, EventArgs e)
        {
                using (var muusika = new SoundPlayer(@"..\..\1.wav"))
                {
                    muusika.Play();
                }
                using (var muusika = new SoundPlayer(@"..\..\2.wav"))
                {
                    muusika.Play();
                }
                using (var muusika = new SoundPlayer(@"..\..\3.wav"))
                {
                    muusika.Play();
                }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            
            using (var muusika = new SoundPlayer(@"..\..\1.wav"))
            {
                muusika.Stop();
            }
            using (var muusika = new SoundPlayer(@"..\..\2.wav"))
            {
                muusika.Stop();
            }
            using (var muusika = new SoundPlayer(@"..\..\3.wav"))
            {
                muusika.Stop();
            }
          
            }

        private void Random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int b = rnd.Next(1, 4);
            if (b == 1)
            {
                using (var muusika = new SoundPlayer(@"..\..\1.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("Pumped up kicks");
                }
            }
            else if (b == 2)
            {
                using (var muusika = new SoundPlayer(@"..\..\2.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("MONTERO - LIL NAS");
                }
            }
            else
            {
                using (var muusika = new SoundPlayer(@"..\..\3.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("Life Goes On - Oliver Tree");
                }
            }
            //{
            //    this.ClientSize = new System.Drawing.Size(700, 700);
            //    this.Text = Pealkiri;

            //    //первая песня
            //    Button nupp = new Button
            //    {
            //        Text = Nupp,
            //        Location = new System.Drawing.Point(150, 50),
            //        Size = new System.Drawing.Size(100,50),
            //        BackColor = System.Drawing.Color.YellowGreen,
            //    };
            //    nupp.Click += Nupp_Click;
            //    Label failisnimi = new Label
            //    {
            //        Text = Fail,
            //        Location = new System.Drawing.Point(150, 100),
            //        Size = new System.Drawing.Size(100, 50),
            //        BackColor = System.Drawing.Color.White,
            //    };

            //    //Вторая песня
            //    Button nupp1 = new Button
            //    {
            //        Text = Nupp,
            //        Location = new System.Drawing.Point(150, 50),
            //        Size = new System.Drawing.Size(100, 50),
            //        BackColor = System.Drawing.Color.Yellow,
            //    };
            //    nupp1.Click += Nupp_Click;
            //    Label failisnimi1 = new Label
            //    {
            //        Text = Fail,
            //        Location = new System.Drawing.Point(150, 100),
            //        Size = new System.Drawing.Size(100, 50),
            //        BackColor = System.Drawing.Color.White,
            //    };

            //    //Третья песня
            //    Button nupp2 = new Button
            //    {
            //        Text = Nupp,
            //        Location = new System.Drawing.Point(150, 50),
            //        Size = new System.Drawing.Size(100, 50),
            //        BackColor = System.Drawing.Color.Green,
            //    };
            //    nupp2.Click += Nupp_Click;
            //    Label failisnimi2 = new Label
            //    {
            //        Text = Fail,
            //        Location = new System.Drawing.Point(150, 100),
            //        Size = new System.Drawing.Size(100, 50),
            //        BackColor = System.Drawing.Color.White,
            //    };
            //    this.Controls.Add(nupp);
            //    this.Controls.Add(failisnimi);
            //    this.Controls.Add(nupp1);
            //    this.Controls.Add(failisnimi1);
            //    this.Controls.Add(nupp2);
            //    this.Controls.Add(failisnimi2);
            //}

            //private void nupp_click(object sender, eventargs e)
            //{
            //    button nupp_sender = (button)sender;
            //    var vastus = messagebox.show("kas tahad muusikat kuulata?", "küsimus",messageboxbuttons.yesno);
            //    if (vastus == dialogresult.yes)
            //    {
            //        using (var muusika = new soundplayer(@"..\..\123.wav"))
            //        {
            //            var soundmessage = messagebox.show("playing: pumped up kicks");
            //            muusika.play();
            //        }
            //    }
            //    else
            //    {
            //        messagebox.show(">_<");
            //    }
            //    this.controls.add(nupp_sender);
            //}
        }
    }
}
