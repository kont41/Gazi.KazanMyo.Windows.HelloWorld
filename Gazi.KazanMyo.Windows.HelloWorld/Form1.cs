using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.KazanMyo.Windows.HelloWorld
{
    public partial class Form1 : Form
    {
         Button btn = new Button();
        Random rnd = new Random();
        public Form1()
        {
          
            InitializeComponent();
            Button btn1 = new Button();
            btn1.Size = new Size(100, 50);
            btn1.Text = "ggazi";
            btn1.BackColor = Color.Black;
            btn1.ForeColor = Color.White;
           // btn1.Click += Btn1_Click;
            btn1.Click += Metod;
            this.Controls.Add(btn1);
           


            btn.Size = new Size(100, 50);
            btn.Location = new Point(50, 60);
            btn.Text = "Gazi";
            btn.BackColor = Color.Blue; //veya
            btn.BackColor = Color.FromArgb(150, 50, 175); //veya// BUNLARI AKTİF ETMEK İÇİN DESİGNER.CS DEKİ BUTON CLİCK VE AŞAĞIDAKİ AÇIKLAMALARI KALDIR.


            btn.ForeColor = Color.White;
            this.Controls.Add(btn);
          


        }

        //private void Btn1_Click(object sender, EventArgs e) btnclick ile açarsak void metodunu kapatmak gerek.
        //{
        //    MessageBox.Show("selam");
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));//this yerine btn yazarsak sadece butonun rengi değişir
            
        }
        void Metod(object o, EventArgs e)
        {
            MessageBox.Show("deneme");
        }
      
       
    }
}

