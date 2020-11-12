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
    public partial class frmOyun : Form
    {
        static int toplam = 0;
        static int sure = 3;
        Random rnd = new Random();
        public frmOyun()
        {
            InitializeComponent();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
           
            Button btn = new Button();
            btn.Size = new Size(50, 50);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width-pnlGosterge.Width-btn.Width),rnd.Next(this.ClientSize.Height-btn.Height));
            btn.Text = rnd.Next(100).ToString();
            btn.Click += Btn_Click;
            this.Controls.Add(btn);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam+= int.Parse(btn.Text);
            lblSkor.Text = $"Skor:{toplam}";
            btn.Dispose();
        }

        private void frmOyun_Load(object sender, EventArgs e)
        {
            tmr1.Start();
            tmrSure.Start();
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
        }
    }
}
