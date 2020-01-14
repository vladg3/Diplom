using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystAnalys_lr1
{
    public partial class DisplayEpicenters : Form
    {
        private List<Epicenter> Epics;
    
        public DisplayEpicenters(List<Epicenter> E)
        {
            InitializeComponent();
            this.Epics = E;
            Draw();
        }
        public void Draw()
        {
      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Draw();
        }
        private PictureBox pictureBox2 = new PictureBox();

        private void DisplayEpicenters_Load(object sender, EventArgs e)
        {
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Width = 1500;
            pictureBox2.Height = 904;
            //Bitmap image1 = new Bitmap("Resources/xxx.png");
            //pictureBox2.Image = image1;
            //pictureBox2.Load(@"C:\Users\pako2\Desktop\Diplom\Vlad\gigamegapatch\SystAnalys_lr1\Resources\Map.PNG");
            pictureBox2.Load("../../Resources/Map.PNG");
            pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);

            // Add the PictureBox control to the Form.
            this.Controls.Add(pictureBox2);

        }
        private void pictureBox2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            for (int i = 0; i < Epics.Count; i++)
            {
                Epics[i].DrawEpicenter(g);
            }
        }
    }
}
