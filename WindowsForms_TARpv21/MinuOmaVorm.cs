using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_TARpv21
{
    public partial class MinuOmaVorm : Form
    {
        TreeView puu;
        Button nupp;
        Label silt;
        CheckBox aruut1, aruut2;
        RadioButton rnupp1, rnupp2, rnupp3, rnupp4;
        PictureBox pilt;
        ProgressBar rida;
        Timer aeg;
        TextBox tekst;
        public MinuOmaVorm()
        {
            Height = 600;
            Width = 900;
            Text = "Minu oma vorm koos elementidega"; //название формы
            puu= new TreeView();
            puu.Dock = DockStyle.Left;
            puu.Location = new Point(0,0);
            TreeNode oksad= new TreeNode("Elemendid");
            oksad.Nodes.Add(new TreeNode("Nupp-Button"));
            oksad.Nodes.Add(new TreeNode("Silt-Label"));
            oksad.Nodes.Add(new TreeNode("Dialog aken - MessageBox"));
            oksad.Nodes.Add(new TreeNode("Märkeruut - Checkbox"));
            oksad.Nodes.Add(new TreeNode("Radionupp"));
            oksad.Nodes.Add(new TreeNode("ProgressBar"));
            oksad.Nodes.Add(new TreeNode("Tekstkast - Textbox"));
            oksad.Nodes.Add(new TreeNode("MinuVorm"));
            //puu.AfterSelect += Puu_AfterSelect;
            //puu.Nodes.Add(oksad);
            //puu.DoubleClick += Tekst_DoubleClick;





            puu.AfterSelect += Puu_AfterSelect;


            puu.Nodes.Add(oksad);
            this.Controls.Add(puu);


            
            BackColor = Color.White;

        }

        private void Puu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            silt = new Label
            {
                Text = "Minu esimene vorm",
                Font = new Font("ArialBlack", 10),
                Size = new Size(200, 50),
                Location = new Point(150, 0)
            };
            aruut1 = new CheckBox
            {
                Checked = false,
                Text = "TARpv21",
                Location = new Point(silt.Left + silt.Width, 0),
                Height = 25
            };
            aruut2 = new CheckBox
            {
                Checked = false,
                Text = "LOGITpv21",
                Location = new Point(silt.Left + silt.Width, aruut1.Height),
                Height = 25
            };
            if (e.Node.Text == "Nupp-Button")
            {
                nupp = new Button();
                nupp.Text = "Vajuta siia";
                nupp.Height = 30;
                nupp.Width = 100;
                nupp.Location = new Point(200, 100);
                nupp.Click += Nupp_Click;
                this.Controls.Add(nupp);
            }
            else if (e.Node.Text == "Silt-Label")
            {
                silt = new Label
                {
                    Text = "Minu esimene vorm",
                    Font = new Font("ArialBlack", 10),
                    Size = new Size(200, 50),
                    Location = new Point(450, 0)
                };
                silt.MouseEnter += Silt_MouseEnter;
                silt.MouseLeave += Silt_MouseLeave;
                this.Controls.Add(silt);
            }
            else if (e.Node.Text == "Dialog aken - MessageBox")
            {

                MessageBox.Show("Aken", "kõige lihtne aken");
                var vastus = MessageBox.Show("kas paneme aken kinni?", "Valik",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vastus == DialogResult.Yes)
                {
                    this.Close();
                }
                else { }
            }
            else if (e.Node.Text == "Märkeruut - Checkbox")
            {
                aruut1 = new CheckBox
                {
                    Checked = false,
                    Text = "TARpv21",
                    Location = new Point(silt.Left + silt.Width, 0),
                    Height = 25
                };
                aruut2 = new CheckBox
                {
                    Checked = false,
                    Text = "LOGITpv21",
                    Location = new Point(silt.Left + silt.Width, aruut1.Height),
                    Height = 25
                };
                aruut2.CheckedChanged += Aruut_1_2_Changed;
                aruut1.CheckedChanged += Aruut_1_2_Changed;

                this.Controls.Add(aruut1);
                this.Controls.Add(aruut2);

            }
            else if (e.Node.Text == "Radionupp")
            {
                rnupp1 = new RadioButton
                {
                    Text = "Paremale",
                    Width = 112,
                    Location = new Point(aruut2.Left + aruut2.Width, aruut1.Height + aruut2.Height)
                };
                rnupp2 = new RadioButton
                {
                    Text = "Vasakule",
                    Width = 112,
                    Location = new Point(aruut2.Left + aruut2.Width+rnupp1.Width, aruut1.Height + aruut2.Height)
                };
                rnupp3 = new RadioButton
                {
                    Text = "Alla",
                    Width = 112,
                    Location = new Point(aruut2.Left + aruut2.Width+rnupp2.Width + rnupp1.Width, aruut1.Height + aruut2.Height)
                };
                rnupp4 = new RadioButton
                {
                    Text = "Üles",
                    Width = 112,
                    Location = new Point(aruut2.Left + aruut2.Width+rnupp3.Width+rnupp2.Width+rnupp1.Width, aruut1.Height + aruut2.Height)
                };
                pilt = new PictureBox
                {
                    Image=new Bitmap("b02.jpg"),
                    Location = new Point(300,400),
                    Size= new Size(100,200),
                    SizeMode = PictureBoxSizeMode.Zoom

                };
                rnupp1.CheckedChanged += new EventHandler(Rnupud_Changed);
                rnupp2.CheckedChanged += new EventHandler(Rnupud_Changed);
                rnupp3.CheckedChanged += new EventHandler(Rnupud_Changed);
                rnupp4.CheckedChanged += new EventHandler(Rnupud_Changed);

                this.Controls.Add(pilt);
                this.Controls.Add(rnupp1);
                this.Controls.Add(rnupp2);
                this.Controls.Add(rnupp3);
                this.Controls.Add(rnupp4);

            }
            else if (e.Node.Text == "ProgressBar")
            {
                rida = new ProgressBar
                {
                    Width=400,
                    Height=30,
                    Location= new Point(300,450),
                    Value=35,
                    Minimum=0,
                    Maximum=100,
                    Step=1,
                    //Dock=DockStyle.Bottom
                };
                aeg = new Timer();
                aeg.Enabled = true;
                aeg.Tick += Aeg_Tick;
                this.Controls.Add(rida);

            }
            else if (e.Node.Text == "Tekstkast - Textbox")
            {
                tekst = new TextBox
                {
                    Font = new Font("ArialBlack", 34,FontStyle.Italic),
                    Location = new Point(350, 400),
                    Enabled = false,
                };

                //tekst.MouseDoubleClick += Tekst_DoubleClick;
                this.Controls.Add(tekst);
            }
            else if (e.Node.Text=="MinuVorm")
            {
                MinuVorm minu = new MinuVorm("Kuulame muusikat");
                minu.ShowDialog();


            }
        }

        private void Tekst_DoubleClick(object sender, EventArgs e)
        {
            if (tekst.Enabled)
            {
                tekst.Enabled = false;
            }
            else
            {
                tekst.Enabled = true;
            }
        }

        private void Aeg_Tick(object sender, EventArgs e)
        {
            rida.PerformStep();
            MessageBox.Show( "See on Virus");
        }



        int x = 300;
        int y = 300;
        private void Rnupud_Changed(object sender, EventArgs e)
        {
            if(rnupp1.Checked)
            {
                x += 20;
                pilt.Location = new Point(x,y);
                rnupp1.Checked = false;
            }
            if (rnupp2.Checked)
            {
                x -= 20;
                pilt.Location = new Point(x, y);
                rnupp2.Checked = false;
            }
            if (rnupp3.Checked)
            {
                y += 20;
                pilt.Location = new Point(x, y);
                rnupp3.Checked = false;
            }
            if (rnupp4.Checked)
            {
                y -= 20;
                pilt.Location = new Point(x, y);
                rnupp4.Checked = false;
            }
        }


        private void Aruut_1_2_Changed(object sender, EventArgs e)
        {
            if (aruut1.Checked == true && aruut2.Checked == true)
            {
                BackColor = Color.LightGreen;
            }
            else if (aruut1.Checked == true && aruut2.Checked == false)
            {
                BackColor = Color.DarkMagenta;
            }
            else if(aruut1.Checked == false && aruut2.Checked == true)
            {
                BackColor = Color.LightCyan;
            }
            else if(aruut1.Checked == false && aruut2.Checked == false)
            {
                BackColor = Color.DarkRed;
            }
        }


        private void Silt_MouseEnter(object sender, EventArgs e)
        {
            silt.ForeColor = Color.White;
            silt.BackColor = Color.Black;
        }

        private void Silt_MouseLeave(object sender, EventArgs e)
        {
            silt.ForeColor = Color.Black;
            silt.BackColor = Color.Transparent;
        }

        Random random = new Random();
        private void Nupp_Click(object sender, EventArgs e)
        {
            int red, green, blue;
            red = random.Next(255);
            green = random.Next(255);
            blue= random.Next(255);

            this.BackColor = Color.FromArgb(red,green,blue);
        }

    }
}
