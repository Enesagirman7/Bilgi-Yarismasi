using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo=0,dogru=0,yanlis=0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled=false;
            btnB.Enabled=false;
            btnC.Enabled=false;
            btnD.Enabled=false;
            btnSonrakiSoru.Enabled=true;
            label5.Text=btnB.Text;
            if (label4.Text==label5.Text)
            {  
                dogru++;
                lblDogru.Text=dogru.ToString();
                pictureBox1.Visible=true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text=yanlis.ToString();
                pictureBox2.Visible=true;
            }
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled=false;
            btnB.Enabled=false;
            btnC.Enabled=false;
            btnD.Enabled=false;
            btnSonrakiSoru.Enabled=true;
            label5.Text=btnC.Text;
            if (label4.Text==label5.Text)
            {  
                dogru++;
                lblDogru.Text=dogru.ToString();
                pictureBox1.Visible=true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text=yanlis.ToString();
                pictureBox2.Visible=true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled=false;
            btnB.Enabled=false;
            btnC.Enabled=false;
            btnD.Enabled=false;
            btnSonrakiSoru.Enabled=true;
            label5.Text=btnD.Text;
            if (label4.Text==label5.Text)
            {  
                dogru++;
                lblDogru.Text=dogru.ToString();
                pictureBox1.Visible=true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text=yanlis.ToString();
                pictureBox2.Visible=true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled=false;
            btnB.Enabled=false;
            btnC.Enabled=false;
            btnD.Enabled=false;
            btnSonrakiSoru.Enabled=true;
            label5.Text=btnA.Text;
            if (label4.Text==label5.Text)
            {  
                dogru++;
                lblDogru.Text=dogru.ToString();
                pictureBox1.Visible=true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text=yanlis.ToString();
                pictureBox2.Visible=true;
            }

        }

        private void btnSonrakiSoru_Click(object sender, EventArgs e)
        {
            btnA.Enabled=true;
            btnB.Enabled=true;
            btnC.Enabled=true;
            btnD.Enabled=true;
            pictureBox1.Visible=false;
            pictureBox2.Visible=false;
            soruNo=soruNo+1;
            lblSoruNo.Text=soruNo.ToString();

            if (soruNo==1)
            {
                richTextBox1.Text="Cumhuriyet Kaç Yılında İlan Edilmiştir?";
                btnA.Text="1920";
            btnB.Text="1921";
            btnC.Text="1925";
            btnD.Text="1923";
            label4.Text="1923";
            }
            if (soruNo==2)
            { 
                richTextBox1.Text="Türkiye'nin Tek 4 yıldızlı Takımı Hangisidir?";
                btnA.Text="Beşiktaş";
                btnB.Text="Galatasaray";
                btnC.Text="Fenerbahce";
                btnD.Text="Trabzonspor";
                label4.Text="Galatasaray";
            }
            if (soruNo==3)
            {
                richTextBox1.Text="Hangi Araba Markası İtalyandır?";
                btnA.Text="Audi";
                btnB.Text="BMW";
                btnC.Text="Ferrari";
                btnD.Text="Mercedes";
                label4.Text="Ferrari";
                btnSonrakiSoru.Text="Sonuclar";
            }
            if (soruNo==4)
            {
                btnA.Enabled=false;
                btnB.Enabled=false;
                btnC.Enabled=false;
                btnD.Enabled=false;
                btnSonrakiSoru.Enabled=false;
                MessageBox.Show(" Doğru: " + dogru + " \n " + " Yanlış: " + yanlis);
            }

                



           


        }
    }
}
