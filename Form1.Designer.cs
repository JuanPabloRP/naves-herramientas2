namespace WindowsFormsApp1
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tmrFiuu = new System.Windows.Forms.Timer(this.components);
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.lblMuroI = new System.Windows.Forms.Label();
            this.lblMuroD = new System.Windows.Forms.Label();
            this.imgEnemy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 415);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(708, 415);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmrFiuu
            // 
            this.tmrFiuu.Tick += new System.EventHandler(this.tmrFiuu_Tick);
            // 
            // imgPlayer
            // 
            this.imgPlayer.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayer.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayer.Image")));
            this.imgPlayer.Location = new System.Drawing.Point(352, 344);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(48, 43);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPlayer.TabIndex = 5;
            this.imgPlayer.TabStop = false;
            // 
            // lblMuroI
            // 
            this.lblMuroI.AutoSize = true;
            this.lblMuroI.ForeColor = System.Drawing.Color.Silver;
            this.lblMuroI.Location = new System.Drawing.Point(774, 399);
            this.lblMuroI.Name = "lblMuroI";
            this.lblMuroI.Size = new System.Drawing.Size(9, 13);
            this.lblMuroI.TabIndex = 6;
            this.lblMuroI.Text = "|";
            this.lblMuroI.Visible = false;
            // 
            // lblMuroD
            // 
            this.lblMuroD.AutoSize = true;
            this.lblMuroD.ForeColor = System.Drawing.Color.Silver;
            this.lblMuroD.Location = new System.Drawing.Point(12, 399);
            this.lblMuroD.Name = "lblMuroD";
            this.lblMuroD.Size = new System.Drawing.Size(9, 13);
            this.lblMuroD.TabIndex = 7;
            this.lblMuroD.Text = "|";
            this.lblMuroD.Visible = false;
            // 
            // imgEnemy
            // 
            this.imgEnemy.BackColor = System.Drawing.Color.Transparent;
            this.imgEnemy.Image = ((System.Drawing.Image)(resources.GetObject("imgEnemy.Image")));
            this.imgEnemy.Location = new System.Drawing.Point(352, 12);
            this.imgEnemy.Name = "imgEnemy";
            this.imgEnemy.Size = new System.Drawing.Size(48, 38);
            this.imgEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEnemy.TabIndex = 8;
            this.imgEnemy.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.imgEnemy);
            this.Controls.Add(this.lblMuroD);
            this.Controls.Add(this.lblMuroI);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMain";
            this.Text = "Main form";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmrFiuu;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Label lblMuroI;
        private System.Windows.Forms.Label lblMuroD;
        private System.Windows.Forms.PictureBox imgEnemy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

