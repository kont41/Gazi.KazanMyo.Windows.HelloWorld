namespace Gazi.KazanMyo.Windows.HelloWorld
{
    partial class frmOyun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.pnlGosterge = new System.Windows.Forms.Panel();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.pnlGosterge.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr1
            // 
            this.tmr1.Interval = 200;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // pnlGosterge
            // 
            this.pnlGosterge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlGosterge.Controls.Add(this.lblSure);
            this.pnlGosterge.Controls.Add(this.lblSkor);
            this.pnlGosterge.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGosterge.Location = new System.Drawing.Point(650, 0);
            this.pnlGosterge.Name = "pnlGosterge";
            this.pnlGosterge.Size = new System.Drawing.Size(150, 450);
            this.pnlGosterge.TabIndex = 0;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(30, 18);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(46, 17);
            this.lblSkor.TabIndex = 0;
            this.lblSkor.Text = "label1";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(29, 39);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(46, 17);
            this.lblSure.TabIndex = 1;
            this.lblSure.Text = "label2";
            // 
            // tmrSure
            // 
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGosterge);
            this.Name = "frmOyun";
            this.Text = "frmOyun";
            this.Load += new System.EventHandler(this.frmOyun_Load);
            this.pnlGosterge.ResumeLayout(false);
            this.pnlGosterge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Panel pnlGosterge;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Timer tmrSure;
    }
}