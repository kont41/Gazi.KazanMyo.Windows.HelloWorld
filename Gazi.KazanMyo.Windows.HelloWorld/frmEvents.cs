using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.KazanMyo.Windows.HelloWorld
{
    public partial class frmEvents : Form
    {
        Random rnd = new Random();                                        //burada değişkenlermizi global tanımlıyoruz
        int hsp;
        public frmEvents()
        {
            InitializeComponent();
            button1.Text = rnd.Next(20).ToString();                    //burada açıldığında ilk 3 butona rastgele sayılar atılıyor(20 ye kadar yaptım işlemin büyük olmaması için)
            button2.Text = rnd.Next(20).ToString();
            button3.Text = rnd.Next(20).ToString();
            //constructorlar metod atama işlemi için daha  uygundur

        }
        public void Metod(object sender, EventArgs e)
        {
           
            Button btn = (Button)sender;
            btn.Enabled = false;//butonun özelliklerini kullanabilmek için sender  buton olarak tanımlanıyor
            hsp += int.Parse(btn.Text);                             // bu satır btn.text te ne varsa hsp içine atıp eşitliyor
        }
        public void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + hsp);
        }

        private void frmEvents_Load(object sender, EventArgs e)
        {
            //form açıldığında yapılacak olan işler
            tmrButton.Start();
        }

        private void tmrButton_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }


}

