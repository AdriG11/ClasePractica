using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class FrmOptimizar : Form
    {
        private ImageRepository imageRepository;
        public FrmOptimizar()
        {
            InitializeComponent();
            imageRepository = new ImageRepository();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de imagen|*.jpg;.jpeg;.png";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = imageRepository.LoadImage(dialog.FileName);
                pictureBox1.Image = imageRepository.ProcessImage(image);
            }
        }

        
    }
}
