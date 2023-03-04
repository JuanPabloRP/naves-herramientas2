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
        int x, y, baja = 0, enemysVelocityH = 25, enemysVelocityV = 1;
        bool tocaMuroD = false, tocaMuroI = false, llegaAbajo = false, llegaArriba = true;

        int imgPlayerX = 0, imgPlayerY = 0;

        public frmMain()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

       

        private void btnStart_Click(object sender, EventArgs e)
        { 
            tmrFiuu.Enabled = true;
        }

        private void tmrFiuu_Tick(object sender, EventArgs e)
        {
            //obtenemos la posicion del enemy (el rayo mcqueen)
            x = imgEnemy.Location.X;
            y = imgEnemy.Location.Y;

            //Estos ifs sirven para que no se salga de la pantalla ni por arriba ni por abajo
            //verifica que el enemy nunca se pase por afuera de la ventana por encima
            if (imgEnemy.Location.Y <= 0)
            {
                llegaArriba = true;
                llegaAbajo = false;
            }
            //verifica que el enemy no llegue a un height mas alto que el de la ventana
            if (imgEnemy.Location.Y >= (Size.Height - (imgEnemy.Size.Height * 2)))
            {
                llegaAbajo = true;
                llegaArriba = false;
            }

            //verificamos que toque un muro y que no esté por afuera de la pantalla por arriba y lo ponemos a bajar
            if ( ( (tocaMuroD == true || tocaMuroI == true) && (llegaAbajo == false)) || llegaArriba == true ) {
                llegaAbajo = false;
                imgEnemy.Location = new Point(x, y += enemysVelocityV );
            }

            //verificamos que toque un muro y que no esté por afuera de la pantalla por abajo y lo ponemos a subir
            if ( ( (tocaMuroD == true || tocaMuroI == true) && (llegaArriba == false)) || llegaAbajo == true)
            {
                llegaArriba = false;
                imgEnemy.Location = new Point(x, y -= enemysVelocityV);
            }
            

            
            //apenas toque un muro vaya y toque el otro
            if (tocaMuroD == false || tocaMuroI == true)
            {
                imgEnemy.Location = new Point(x + enemysVelocityH, y);
                //if (imgMcQueen.Location.X >= (lblMuroD.Location.X - imgMcQueen.Size.Width))
                if (imgEnemy.Location.X >= (Size.Width - imgEnemy.Size.Width)) {
                    tocaMuroD = true;
                    tocaMuroI = false;
                    baja += 1;
                }
            }
            if (tocaMuroD == true || tocaMuroI == false)
            {
                imgEnemy.Location = new Point(x - enemysVelocityH, y);
                //if (imgMcQueen.Location.X < lblMuroI.Location.X)
                if (imgEnemy.Location.X <= (0 + (imgEnemy.Size.Width/2)))
                {
                    tocaMuroI = true;
                    tocaMuroD = false;
                    baja += 1;
                }
            }



            if (imgEnemy.Location == imgPlayer.Location)
            {
                MessageBox.Show("Perdiste, jaja tonto");
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrFiuu.Enabled = false;
        }


        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            imgPlayerX = imgPlayer.Location.X; 
            imgPlayerY = imgPlayer.Location.Y;


            



            if (e.KeyChar.ToString().ToUpper() == Convert.ToChar(Keys.A).ToString().ToUpper())
            {
                imgPlayerX -= 10;
                imgPlayer.Location = new Point(imgPlayerX, imgPlayerY);
            }else if (e.KeyChar.ToString().ToUpper() == Convert.ToChar(Keys.D).ToString().ToUpper())
            {
                imgPlayerX += 10;
                imgPlayer.Location = new Point(imgPlayerX, imgPlayerY);
            }
            else if (e.KeyChar.ToString().ToUpper() == Convert.ToChar(Keys.W).ToString().ToUpper())
            {
                imgPlayerY -= 10;
                imgPlayer.Location = new Point(imgPlayerX, imgPlayerY);
            }
            else if (e.KeyChar.ToString().ToUpper() == Convert.ToChar(Keys.S).ToString().ToUpper())
            {
                imgPlayerY += 10;
                imgPlayer.Location = new Point(imgPlayerX, imgPlayerY);
            }


        }

        
    }
}
