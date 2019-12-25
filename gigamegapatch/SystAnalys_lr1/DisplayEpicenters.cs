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
            for (int i = 0; i < Epics.Count; i++)
            {
                Epics[i].DrawEpicenter(pictureBox1);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
