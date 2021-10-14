using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Recorder
{
    public partial class Grabadora : Form
    {
        int contador = 0;
        public Grabadora()
        {
            InitializeComponent();
        }

        private void CaptureBtn_Click(object sender, EventArgs e)
        {
            contador = 0;
            timer1.Start();
            this.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador == 1)
            {
                Rectangle limites = Screen.GetBounds(Point.Empty);
                Bitmap bmp = new Bitmap(limites.Width, limites.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.CopyFromScreen(Point.Empty, Point.Empty, limites.Size);
                shotsBox.Image = bmp;
                this.Visible = true;
                timer1.Stop();
            }
            contador++;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Imagen | .png";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageFormat format = ImageFormat.Png;
                shotsBox.Image.Save(sfd.FileName, format);
            }
        }
    }
}
