using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gazi.KazanMyo.Windows.HelloWorld
{
    public partial class frmOyun : Form
    {
       
        int toplam = 0;
        int sure = 30;

        Random rnd = new Random();
        public frmOyun()
        {

            InitializeComponent();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {

            Button btn = new Button();
            btn.Size = new Size(50, 50);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlGosterge.Width - btn.Width), rnd.Next(this.ClientSize.Height - btn.Height));
            btn.Text = rnd.Next(100).ToString();
            btn.Click += Btn_Click;
            btn.Image = Image.FromFile(@"C:\Users\Violétt\source\repos\Gazi.KazanMyo.Windows.HelloWorld\ss.jpg");
            this.Controls.Add(btn);
            Cursor = Cursors.Cross;




        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);

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

            if (sure == 0)
            {

                tmr1.Stop();
                tmrSure.Stop();
               
                MessageBox.Show($"Oyun Bitti.Skorunuz:{toplam}");
                FileStream fs = new FileStream(@"C:\oyunSkor .txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write($"Skorunuz:{toplam} Tarih:" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "\n");
                sw.Flush();
                sw.Close();
                fs.Close();

                DialogResult dialogResult = MessageBox.Show($"Skorunuz: {toplam},Yeniden oynamak ister misiniz?", "Oyun Bitti!", MessageBoxButtons.YesNo);


                if (dialogResult == DialogResult.Yes)
                {
                    sure = 30;
                    frmOyun_Load(sender, e);
                    toplam = 0;
                    lblSkor.Text = "Skor:0";
                    lblSure.Text = sure.ToString();

                }
                else if (dialogResult == DialogResult.No)
                {
                    System.Windows.Forms.Application.ExitThread();
                }

            }

        }


    }
}
