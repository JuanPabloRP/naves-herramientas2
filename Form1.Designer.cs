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
            this.imgFrancesco = new System.Windows.Forms.PictureBox();
            this.lblMuroI = new System.Windows.Forms.Label();
            this.lblMuroD = new System.Windows.Forms.Label();
            this.imgMcQueen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFrancesco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMcQueen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(27, 415);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(695, 415);
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
            // imgFrancesco
            // 
            this.imgFrancesco.Image = ((System.Drawing.Image)(resources.GetObject("imgFrancesco.Image")));
            this.imgFrancesco.Location = new System.Drawing.Point(266, 184);
            this.imgFrancesco.Name = "imgFrancesco";
            this.imgFrancesco.Size = new System.Drawing.Size(111, 105);
            this.imgFrancesco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFrancesco.TabIndex = 5;
            this.imgFrancesco.TabStop = false;
            // 
            // lblMuroI
            // 
            this.lblMuroI.AutoSize = true;
            this.lblMuroI.Location = new System.Drawing.Point(12, 0);
            this.lblMuroI.Name = "lblMuroI";
            this.lblMuroI.Size = new System.Drawing.Size(9, 533);
            this.lblMuroI.TabIndex = 6;
            this.lblMuroI.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n\r\n";
            // 
            // lblMuroD
            // 
            this.lblMuroD.AutoSize = true;
            this.lblMuroD.Location = new System.Drawing.Point(776, 0);
            this.lblMuroD.Name = "lblMuroD";
            this.lblMuroD.Size = new System.Drawing.Size(87, 546);
            this.lblMuroD.TabIndex = 7;
            this.lblMuroD.Text = resources.GetString("lblMuroD.Text");
            // 
            // imgMcQueen
            // 
            this.imgMcQueen.Image = ((System.Drawing.Image)(resources.GetObject("imgMcQueen.Image")));
            this.imgMcQueen.Location = new System.Drawing.Point(323, 12);
            this.imgMcQueen.Name = "imgMcQueen";
            this.imgMcQueen.Size = new System.Drawing.Size(99, 68);
            this.imgMcQueen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMcQueen.TabIndex = 8;
            this.imgMcQueen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgMcQueen);
            this.Controls.Add(this.lblMuroD);
            this.Controls.Add(this.lblMuroI);
            this.Controls.Add(this.imgFrancesco);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMain";
            this.Text = "Main form";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.imgFrancesco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMcQueen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmrFiuu;
        private System.Windows.Forms.PictureBox imgFrancesco;
        private System.Windows.Forms.Label lblMuroI;
        private System.Windows.Forms.Label lblMuroD;
        private System.Windows.Forms.PictureBox imgMcQueen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

