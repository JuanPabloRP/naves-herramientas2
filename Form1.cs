using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        int imgEnemyX, imgEnemyY, enemysVelocityH = 40, enemysVelocityV = 4, playersVelocityWithArrows = 20, playersVelocityWithLetters = 7;
        bool tocaMuroD = false, tocaMuroI = false, llegaAbajo = false, llegaArriba = true;
        int imgEnemyPosInitX = 0, imgEnemyPosInitY = 0;

        /// <summary>
        ///  Juan Pablo Roldan Patiño
        ///  2023
        ///  juego de naves, haciendo uso del teclado
        /// </summary>

        public frmMain()
        {
            InitializeComponent();
            KeyPreview = true;
            imgEnemyPosInitX = imgEnemy.Location.X;
            imgEnemyPosInitY = imgEnemy.Location.Y;

            imgDisparo.Location = new Point(imgPlayer.Location.X + (imgPlayer.Width / 2), imgPlayer.Location.Y + 5);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrFiuu.Enabled = true;
            tmrDisparo.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrFiuu.Enabled = false;
            tmrDisparo.Enabled = false;

        }

        private void tmrFiuu_Tick(object sender, EventArgs e)
        {
            
            //obtenemos la posicion del enemy (el rayo mcqueen)
            imgEnemyX = imgEnemy.Location.X;
            imgEnemyY = imgEnemy.Location.Y;

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
            if (((tocaMuroD == true || tocaMuroI == true) && (llegaAbajo == false)) || llegaArriba == true)
            {
                llegaAbajo = false;
                imgEnemy.Location = new Point(imgEnemyX, imgEnemyY += enemysVelocityV);
            }

            //verificamos que toque un muro y que no esté por afuera de la pantalla por abajo y lo ponemos a subir
            if (((tocaMuroD == true || tocaMuroI == true) && (llegaArriba == false)) || llegaAbajo == true)
            {
                llegaArriba = false;
                imgEnemy.Location = new Point(imgEnemyX, imgEnemyY -= enemysVelocityV);
            }



            //apenas toque un muro vaya y toque el otro
            if (tocaMuroD == false || tocaMuroI == true)
            {
                imgEnemy.Location = new Point(imgEnemyX + enemysVelocityH, imgEnemyY);
                //if (imgMcQueen.Location.X >= (lblMuroD.Location.X - imgMcQueen.Size.Width))
                if (imgEnemy.Location.X >= (Size.Width - imgEnemy.Size.Width))
                {
                    tocaMuroD = true;
                    tocaMuroI = false;

                }
            }
            if (tocaMuroD == true || tocaMuroI == false)
            {
                imgEnemy.Location = new Point(imgEnemyX - enemysVelocityH, imgEnemyY);
                //if (imgMcQueen.Location.X < lblMuroI.Location.X)
                if (imgEnemy.Location.X <= (0 + (imgEnemy.Size.Width / 2)))
                {
                    tocaMuroI = true;
                    tocaMuroD = false;

                }
            }


            if(imgEnemy.Bounds.IntersectsWith(imgPlayer.Bounds))
            {
                tmrFiuu.Enabled = false;
                tmrDisparo.Enabled = false;
                MessageBox.Show("Perdiste");
                imgEnemy.Location = new Point(imgEnemyPosInitX, imgEnemyPosInitY);
                imgDisparo.Location = new Point(imgPlayer.Location.X + (imgPlayer.Width / 2), imgPlayer.Location.Y + 5);
            }

            if (imgEnemy.Bounds.IntersectsWith(imgDisparo.Bounds))
            {
                tmrFiuu.Enabled = false;
                tmrDisparo.Enabled = false;
                MessageBox.Show("Ganaste");
                imgEnemy.Location = new Point(imgEnemyPosInitX, imgEnemyPosInitY);
                imgDisparo.Location = new Point(imgPlayer.Location.X + (imgPlayer.Width / 2), imgPlayer.Location.Y + 5);
            }


        }

        private void tmrDisparo_Tick(object sender, EventArgs e)
        {
            while(imgDisparo.Location.Y > 0 && tmrFiuu.Enabled == true)
            {
                //a
                imgDisparo.Location = new Point(imgDisparo.Location.X, imgDisparo.Location.Y - 5);
                Application.DoEvents(); // Permite actualizar la ventana
                Thread.Sleep(20); // Retrasar el hilo durante 20 milisegundos
            }

            if (imgDisparo.Location.Y >= 0)
            {
                imgDisparo.Location = new Point(imgPlayer.Location.X + (imgPlayer.Width / 2), imgPlayer.Location.Y + 5);
            }
            
        }

        
        //Puede moverse de dos maneras

        //1-Spameando A o D pero cada paso es mas lento que usando las flechas
        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (imgPlayer.Location.X >= btnStart.Location.X)
            {
                if (e.KeyChar.ToString().ToUpper() == Convert.ToChar(Keys.A).ToString().ToUpper())
                {
                    imgPlayer.Location = new Point(imgPlayer.Location.X - playersVelocityWithLetters, imgPlayer.Location.Y);
                }
            }
            
            if(imgPlayer.Location.X <= (btnStop.Location.X + (btnStop.Size.Width * 0.2) ))
            {
                if (e.KeyChar.ToString().ToUpper() == Convert.ToChar(Keys.D).ToString().ToUpper())
                {

                    imgPlayer.Location = new Point(imgPlayer.Location.X + playersVelocityWithLetters, imgPlayer.Location.Y);
                }
            }
        }

        //2- Con las teclas no se puede spamear pero cada paso es mas largo que usando A o D
        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (imgPlayer.Location.X >= (0 + (imgPlayer.Width * 0.5)))
            {
                if (e.KeyCode == Keys.Left)
                {
                    imgPlayer.Location = new Point(imgPlayer.Location.X - playersVelocityWithArrows, imgPlayer.Location.Y);
                }
            }

            if (imgPlayer.Location.X <= (Size.Width - (imgPlayer.Width * 2)))
            {
                if (e.KeyCode == Keys.Right)
                {
                    imgPlayer.Location = new Point(imgPlayer.Location.X + playersVelocityWithArrows, imgPlayer.Location.Y);
                }
            }


            if(e.KeyCode == Keys.Space)
            {
               



                
               
                

               
            }

            

        }

    }
}


