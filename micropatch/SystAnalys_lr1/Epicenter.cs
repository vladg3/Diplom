using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystAnalys_lr1
{
    public class Epicenter : Panel
    {
        GraphicsPath path;
        PathGradientBrush pthGrBrush;
        public Epicenter()
        {
            
            //path = new GraphicsPath();
            //path.AddEllipse(10, 10, 100, 100);
            //Color[] colors = {
            //    Color.Yellow,
            //};

            //pthGrBrush = new PathGradientBrush(path);
            //pthGrBrush.CenterColor = Color.Red;
            //pthGrBrush.SurroundColors = colors;
            //this.CreateGraphics().FillEllipse(pthGrBrush, 10, 10, 100, 100);
            //this.Region = new Region(path);

        }
    }
}
