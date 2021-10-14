
namespace Recorder
{
    partial class Grabadora
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
            this.shotsBox = new System.Windows.Forms.PictureBox();
            this.CaptureBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.shotsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shotsBox
            // 
            this.shotsBox.Location = new System.Drawing.Point(12, 12);
            this.shotsBox.Name = "shotsBox";
            this.shotsBox.Size = new System.Drawing.Size(776, 341);
            this.shotsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shotsBox.TabIndex = 0;
            this.shotsBox.TabStop = false;
            // 
            // CaptureBtn
            // 
            this.CaptureBtn.Location = new System.Drawing.Point(226, 392);
            this.CaptureBtn.Name = "CaptureBtn";
            this.CaptureBtn.Size = new System.Drawing.Size(103, 33);
            this.CaptureBtn.TabIndex = 1;
            this.CaptureBtn.Text = "Capturar";
            this.CaptureBtn.UseVisualStyleBackColor = true;
            this.CaptureBtn.Click += new System.EventHandler(this.CaptureBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(412, 392);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(103, 33);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Grabadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.CaptureBtn);
            this.Controls.Add(this.shotsBox);
            this.Name = "Grabadora";
            this.Text = "Grabadora de pantalla";
            ((System.ComponentModel.ISupportInitialize)(this.shotsBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox shotsBox;
        private System.Windows.Forms.Button CaptureBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

