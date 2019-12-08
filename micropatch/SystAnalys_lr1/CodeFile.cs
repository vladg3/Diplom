using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystAnalys_lr1
{
    class Vertex
    {
        public int x, y;
        private Point point;

        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vertex(Point point, int y)
        {
            this.point = point;
            this.y = y;
        }
    }

    class Edge
    {
        public int v1, v2;

        public Edge(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }

    class DrawGraph
    {
        Bitmap bitmap;
        Pen blackPen;
        Pen redPen;
        Pen darkGoldPen;
        Graphics gr;
        Font fo;
        Brush br;
        PointF point;
        public int R = 20; //радиус окружности вершины

        public DrawGraph(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            gr = Graphics.FromImage(bitmap);
            clearSheet();
            blackPen = new Pen(Color.Black);
            blackPen.Width = 2;
            redPen = new Pen(Color.Red);
            redPen.Width = 2;
            darkGoldPen = new Pen(Color.DarkGoldenrod);
            darkGoldPen.Width = 2;
            fo = new Font("Arial", 15);
            br = Brushes.Black;
        }

        public Bitmap GetBitmap()
        {
            return bitmap;
        }

        public void clearSheet()
        {
            gr.Clear(Color.White);
        }

        public void drawVertex(int x, int y, string number)
        {
            gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
            gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
            point = new PointF(x - 9, y - 9);
            gr.DrawString(number, fo, br, point);
        }

        public void drawSelectedVertex(int x, int y)
        {
            gr.DrawEllipse(redPen, (x - R), (y - R), 2 * R, 2 * R);
        }

        public void drawEdge(Vertex V1, Vertex V2, Edge E, int numberE)
        {
            if (E.v1 == E.v2)
            {
                gr.DrawArc(darkGoldPen, (V1.x - 2 * R), (V1.y - 2 * R), 2 * R, 2 * R, 90, 270);
                point = new PointF(V1.x - (int)(2.75 * R), V1.y - (int)(2.75 * R));
                gr.DrawString(((char)('a' + numberE)).ToString(), fo, br, point);
                drawVertex(V1.x, V1.y, (E.v1 + 1).ToString());
            }
            else
            {
                gr.DrawLine(darkGoldPen, V1.x, V1.y, V2.x, V2.y);
                point = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
                gr.DrawString(((char)('a' + numberE)).ToString(), fo, br, point);
                drawVertex(V1.x, V1.y, (E.v1 + 1).ToString());
                drawVertex(V2.x, V2.y, (E.v2 + 1).ToString());
            }
        }

        public void drawALLGraph(List<Vertex> V, List<Edge> E)
        {
            //рисуем ребра
            for (int i = 0; i < E.Count; i++)
            {
                if (E[i].v1 == E[i].v2)
                {
                    gr.DrawArc(darkGoldPen, (V[E[i].v1].x - 2 * R), (V[E[i].v1].y - 2 * R), 2 * R, 2 * R, 90, 270);
                    point = new PointF(V[E[i].v1].x - (int)(2.75 * R), V[E[i].v1].y - (int)(2.75 * R));
                    gr.DrawString(((char)('a' + i)).ToString(), fo, br, point);
                }
                else
                {
                    gr.DrawLine(darkGoldPen, V[E[i].v1].x, V[E[i].v1].y, V[E[i].v2].x, V[E[i].v2].y);
                    point = new PointF((V[E[i].v1].x + V[E[i].v2].x) / 2, (V[E[i].v1].y + V[E[i].v2].y) / 2);
                    gr.DrawString(((char)('a' + i)).ToString(), fo, br, point);
                }
            }
            //рисуем вершины
            for (int i = 0; i < V.Count; i++)
            {
                drawVertex(V[i].x, V[i].y, (i + 1).ToString());
            }
        }

        //заполняет матрицу смежности
        public void fillAdjacencyMatrix(int numberV, List<Edge> E, int[,] matrix)
        {
            for (int i = 0; i < numberV; i++)
                for (int j = 0; j < numberV; j++)
                    matrix[i, j] = 0;
            for (int i = 0; i < E.Count; i++)
            {
                matrix[E[i].v1, E[i].v2] = 1;
                matrix[E[i].v2, E[i].v1] = 1;
            }
        }

        //заполняет матрицу инцидентности
        public void fillIncidenceMatrix(int numberV, List<Edge> E, int[,] matrix)
        {
            for (int i = 0; i < numberV; i++)
                for (int j = 0; j < E.Count; j++)
                    matrix[i, j] = 0;
            for (int i = 0; i < E.Count; i++)
            {
                matrix[E[i].v1, i] = 1;
                matrix[E[i].v2, i] = 1;
            }
        }

        
    }
 
    class BusPark
    {
        private List<Vertex> V;
        private List<Epicenters> Epicenters;
        private double  angle,x,y;
        private int PositionAt;
        private bool TurnBack;
        private PictureBox Bus;
        private PictureBox Map;

        public BusPark(List<Vertex> m, PictureBox Bus, int PositionAt, List<Epicenters> Epicenters, PictureBox Map)
        {
            this.Map = Map;
            V = new List<Vertex>();
            this.Epicenters = new List<Epicenters>();
            this.Epicenters = Epicenters;
            for (int i = 0; i < m.Count; i++)
            {
                V.Add(new Vertex(m[i].x, m[i].y));
            }
            this.Bus = Bus;
            x = Bus.Left;
            y = Bus.Top;
            this.PositionAt = PositionAt;
            angle = GetAngle(this.V[PositionAt].x, this.V[PositionAt].y);
            TurnBack = false;
        }

        public BusPark(List<Vertex> m, PictureBox Bus, int PositionAt, bool Turn, List<Epicenters> Epicenters, PictureBox Map)
        {
            this.Map = Map;
            V = new List<Vertex>();
            this.Epicenters = new List<Epicenters>();
            this.Epicenters = Epicenters;
            for (int i = 0; i < m.Count; i++)
            {
                V.Add(new Vertex(m[i].x, m[i].y));
            }
            this.Bus = Bus;
            x = Bus.Left;
            y = Bus.Top;
            this.PositionAt = PositionAt;
            angle = GetAngle(this.V[PositionAt].x, this.V[PositionAt].y);
            TurnBack = Turn;
        }

        double GetAngle(double x2, double y2)
        {
            return Math.Atan2((x - x2), (y - y2));
        }

        public void Move()
        {
            if (TurnBack == false)
            {
                if ((TurnBack == false) && (Math.Abs((Math.Abs(x) + Math.Abs(y)) - (Math.Abs((V[PositionAt].x) + Math.Abs(V[PositionAt].y))))) > 3)
                {
                    for (int i = 0; i < Epicenters.Count; i++)
                    {
                        if (GetDistance((double)Bus.Left, (double)Bus.Top, (double)Epicenters[i].x, (double)Epicenters[i].y) < Epicenters[i].radius)
                        // if (this.Bus.Left == (Epicenters[i].x))
                        {

                            // this.Bus.CreateGraphics().DrawLine(new Pen(Color.FromArgb(128, 255, 255, 0)), Bus.Left, Bus.Top, Bus.Left, Bus.Top);
                            // this.Map.CreateGraphics().FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 255, 0)), Epicenters[i].x - Epicenters[i].radius /2, Epicenters[i].y - Epicenters[i].radius /2, Epicenters[i].radius, Epicenters[i].radius);
                            this.Map.CreateGraphics().DrawLine(new Pen(Color.Black), Bus.Left - 5, Bus.Top - 5, Bus.Left - 6, Bus.Top - 6);
                        }
                    }
                    x -= Math.Sin(angle);
                    y -= Math.Cos(angle);


                    Bus.Left = (int)x  ;
                    Bus.Top = (int)y ;
                  
                }
                else
                {
                    if (PositionAt >= V.Count - 1)
                    {
                        TurnBack = true;
                        PositionAt = PositionAt - 1;
                        angle = GetAngle(V[PositionAt].x, V[PositionAt].y);


                    }
                    else
                    {
                        PositionAt++;
                        angle = GetAngle(V[PositionAt].x, V[PositionAt].y);
                    }
                }
            }
            if (TurnBack == true)
            {
                if ((Math.Abs((Math.Abs(x) + Math.Abs(y)) - (Math.Abs(V[PositionAt].x + Math.Abs(V[PositionAt].y))))) > 3)
                {
                    for (int i = 0; i < Epicenters.Count; i++)
                    {
                        if (GetDistance((double)Bus.Left, (double)Bus.Top, (double)Epicenters[i].x, (double)Epicenters[i].y) < Epicenters[i].radius)
                        // if (this.Bus.Left == (Epicenters[i].x))
                        {

                            // this.Bus.CreateGraphics().DrawLine(new Pen(Color.FromArgb(128, 255, 255, 0)), Bus.Left, Bus.Top, Bus.Left, Bus.Top);
                            // this.Map.CreateGraphics().FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 255, 0)), Epicenters[i].x - Epicenters[i].radius /2, Epicenters[i].y - Epicenters[i].radius /2, Epicenters[i].radius, Epicenters[i].radius);
                            this.Map.CreateGraphics().DrawLine(new Pen(Color.Black), Bus.Left - 5, Bus.Top - 5, Bus.Left - 6, Bus.Top - 6);
                        }
                    }
                    x -= Math.Sin(angle);
                    y -= Math.Cos(angle);


                    Bus.Left = (int)x ;
                    Bus.Top = (int)y;

                  
                }
                else 
                {
                    if (PositionAt == 0)
                    {
                        TurnBack = false;
                    }
                    else
                    {
                        PositionAt = PositionAt - 1;
                        angle = GetAngle(V[PositionAt].x, V[PositionAt].y);
                    }

                }
            }
         
        }
        private  double GetDistance(double x1, double y1, double x2, double y2)
        {
            return (int)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
    class Epicenters
    {

        private PictureBox Map;
        public int x, y, radius; 
        public Epicenters(PictureBox Map,int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
           //this.height = height;
            this.Map = Map;

            //this.Map.CreateGraphics().FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 255, 0)), x-radius/2, y-radius/2, radius, radius);
            //this.Map.CreateGraphics().FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 128, 0)), (x + radius / 4)-radius / 2, (y + radius / 4)-radius / 2, radius / 2, radius / 2);
            //this.Map.CreateGraphics().FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 0, 0)), ((int)(x + (double)radius / 2.7))-radius / 2, ((int)(y + (double)radius / 2.7)) - radius / 2, radius / 4, radius / 4) ;
        }
        public void DrawEpicenter()
        {

            this.Map.CreateGraphics().FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 255, 0)), x - radius / 2, y - radius / 2, radius, radius);
            this.Map.CreateGraphics().FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 128, 0)), (x + radius / 4) - radius / 2, (y + radius / 4) - radius / 2, radius / 2, radius / 2);
            this.Map.CreateGraphics().FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 0, 0)), ((int)(x + (double)radius / 2.7)) - radius / 2, ((int)(y + (double)radius / 2.7)) - radius / 2, radius / 4, radius / 4);
        }
    }
}