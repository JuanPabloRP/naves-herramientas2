using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        int x;
        int y;
        int baja = 0;
        bool tocaMuroD = false;
        bool tocaMuroI = false;
        int enemysVelocityH = 25;
        int enemysVelocityV = 15;

        private int pictureBoxX = 0;
        private int pictureBoxY = 0;

        public frmMain()
        {
            InitializeComponent();
            this.KeyPreview = true;

            this.KeyPreview = true;
            pictureBox1 = new PictureBox();
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.BackColor = Color.Red;
            this.Controls.Add(pictureBox1);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData == Keys.Left)
        {
            pictureBoxX -= 10;
            pictureBox1.Location = new Point(pictureBoxX, pictureBoxY);
            return true;
        }
        else if (keyData == Keys.Right)
        {
            pictureBoxX += 10;
            pictureBox1.Location = new Point(pictureBoxX, pictureBoxY);
            return true;
        }
        else if (keyData == Keys.Up)
        {
            pictureBoxY -= 10;
            pictureBox1.Location = new Point(pictureBoxX, pictureBoxY);
            return true;
        }
        else if (keyData == Keys.Down)
        {
            pictureBoxY += 10;
            pictureBox1.Location = new Point(pictureBoxX, pictureBoxY);
            return true;
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            tmrFiuu.Enabled = true;
            
        }

        private void tmrFiuu_Tick(object sender, EventArgs e)
        {
            x = imgMcQueen.Location.X;
            y = imgMcQueen.Location.Y;

            //
            
            if (tocaMuroD == false)
            {
                imgMcQueen.Location = new Point(x + enemysVelocityH, y);
                if (imgMcQueen.Location.X > lblMuroD.Location.X) {
                    tocaMuroD = true;
                    tocaMuroI = false;
                    baja += 1;
                }

                if (baja % 2 == 0 && baja != 0)
                {
                    imgMcQueen.Location = new Point(x, y += enemysVelocityV);
                }
            }

            if (tocaMuroD == true)
            {
                imgMcQueen.Location = new Point(x - enemysVelocityH, y);
                
                
            }
            

            //
            
            if (tocaMuroI == false)
            {
                imgMcQueen.Location = new Point(x - enemysVelocityH, y);
                if (imgMcQueen.Location.X < lblMuroI.Location.X)
                {
                    tocaMuroI = true;
                    tocaMuroD = false;
                    baja += 1;
                }
            }

            if (tocaMuroI == true)
            {
                imgMcQueen.Location = new Point(x + enemysVelocityH, y);
            }


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrFiuu.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblInicio_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = "A: " + e.KeyChar;
            
            if (e.KeyChar == Convert.ToChar(Keys.A))
            {
                MessageBox.Show("a");
            }
            
        }

        
    }
}
