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

        int imgFrancescoX = 0, imgFrancescoY = 0;

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
            x = imgMcQueen.Location.X;
            y = imgMcQueen.Location.Y;

            //Estos ifs sirven para que no se salga de la pantalla ni por arriba ni por abajo
            //verifica que el enemy nunca se pase por afuera de la ventana por encima
            if (imgMcQueen.Location.Y <= 0)
            {
                llegaArriba = true;
                llegaAbajo = false;
            }
            //verifica que el enemy no llegue a un height mas alto que el de la ventana
            if (imgMcQueen.Location.Y >= (Size.Height - (imgMcQueen.Size.Height * 2)))
            {
                llegaAbajo = true;
                llegaArriba = false;
            }

            //verificamos que toque un muro y que no esté por afuera de la pantalla por arriba y lo ponemos a bajar
            if ( ( (tocaMuroD == true || tocaMuroI == true) && (llegaAbajo == false)) || llegaArriba == true ) {
                llegaAbajo = false;
                imgMcQueen.Location = new Point(x, y += enemysVelocityV );
            }

            //verificamos que toque un muro y que no esté por afuera de la pantalla por abajo y lo ponemos a subir
            if ( ( (tocaMuroD == true || tocaMuroI == true) && (llegaArriba == false)) || llegaAbajo == true)
            {
                llegaArriba = false;
                imgMcQueen.Location = new Point(x, y -= enemysVelocityV);
            }
            

            
            //apenas toque un muro vaya y toque el otro
            if (tocaMuroD == false || tocaMuroI == true)
            {
                imgMcQueen.Location = new Point(x + enemysVelocityH, y);
                if (imgMcQueen.Location.X >= (lblMuroD.Location.X - imgMcQueen.Size.Width)) {
                    tocaMuroD = true;
                    tocaMuroI = false;
                    baja += 1;
                }
            }
            if (tocaMuroD == true || tocaMuroI == false)
            {
                imgMcQueen.Location = new Point(x - enemysVelocityH, y);
                if (imgMcQueen.Location.X < lblMuroI.Location.X)
                {
                    tocaMuroI = true;
                    tocaMuroD = false;
                    baja += 1;
                }
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
            imgFrancescoX = imgFrancesco.Location.X; 
            imgFrancescoY = imgFrancesco.Location.Y;


            label1.Text = "A: " + e.KeyChar;



            if (e.KeyChar.ToString().ToUpper() == Convert.ToChar(Keys.A).ToString().ToUpper())
            {
                imgFrancescoX -= 10;
                imgFrancesco.Location = new Point(imgFrancescoX, imgFrancescoY);
            }else if (e.KeyChar.ToString().ToUpper() == Convert.ToChar(Keys.D).ToString().ToUpper())
            {
                imgFrancescoX += 10;
                imgFrancesco.Location = new Point(imgFrancescoX, imgFrancescoY);
            }
            

        }

        
    }
}
