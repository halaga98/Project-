using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public string fileName { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select an Image";
            ofd.Filter = "Gif Images|*.gif|JPEG Images|*.jpg";
            ofd.FilterIndex = 2;
            ofd.Multiselect = false;
            DialogResult result = ofd.ShowDialog();
            
            if (result == DialogResult.Cancel)
                return;
            txtBrowse.Text = ofd.FileName;
            Image image = Image.FromFile(ofd.FileName);
            pictureBox.Image = image;

            pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            txtBrowse.BackColor = Color.Lime;
            fileName = ofd.FileName;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            
           
        }

        private void btnStrecth_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnPicPreset_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Image.FromFile(@"C:\Users\huso\source\repos\Quiz\WindowsFormsApp6\Image\Manzara.jpg");
        }

        private void btnUIPreset_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.DrawRectangle(Pens.White, new Rectangle(125, 62, 100, 70));
        }

        private void btnDrawBorder_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.fileName);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawRectangle(Pens.Green, new Rectangle(1, 1, 50, 50));

            // Graphics g = pictureBox.CreateGraphics();
            //g.DrawRectangle(Pens.Black, new Rectangle(125, 62, 100, 70));


        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Clean or Not ", "Clean", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                txtBrowse.Text = "";
                pictureBox.Image = null;
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                txtBrowse.BackColor = Color.White;
            }
        }
    }
}
