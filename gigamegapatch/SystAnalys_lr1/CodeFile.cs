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

        ////заполняет матрицу смежности
        //public void fillAdjacencyMatrix(int numberV, List<Edge> E, int[,] matrix)
        //{
        //    for (int i = 0; i < numberV; i++)
        //        for (int j = 0; j < numberV; j++)
        //            matrix[i, j] = 0;
        //    for (int i = 0; i < E.Count; i++)
        //    {
        //        matrix[E[i].v1, E[i].v2] = 1;
        //        matrix[E[i].v2, E[i].v1] = 1;
        //    }
        //}

        ////заполняет матрицу инцидентности
        //public void fillIncidenceMatrix(int numberV, List<Edge> E, int[,] matrix)
        //{
        //    for (int i = 0; i < numberV; i++)
        //        for (int j = 0; j < E.Count; j++)
        //            matrix[i, j] = 0;
        //    for (int i = 0; i < E.Count; i++)
        //    {
        //        matrix[E[i].v1, i] = 1;
        //        matrix[E[i].v2, i] = 1;
        //    }
        //}


    }
    class BusPark
    {
        Timer MovingTimer;
        Timer DetectTimer;
        private List<Epicenter> Epicenters;
        private List<grid_part> Rectangles;
        private PictureBox Map;
        private List<Vertex> V;
        private double angle, x, y;
        private int PositionAt;
        private bool TurnBack;
        List<Vertex> stop;
        private PictureBox Bus;
        private int route;
        private double _date;
        private int total;

        public int getTotal()
        {
            return total;
        }

        public void setTotal()
        {
            this.total += 1;
        }

        public double Date
        {
            get { return _date; }
            set { _date = value; }
        }


        public BusPark(List<Vertex> m, PictureBox Bus, int PositionAt, List<Vertex> s)
        {

            stop = new List<Vertex>();
            this.stop = s;
            V = new List<Vertex>();
            this.V = m;
            this.Bus = Bus;
            x = Bus.Left;
            y = Bus.Top;
            this.PositionAt = PositionAt;
            angle = GetAngle(this.V[PositionAt].x, this.V[PositionAt].y);
            TurnBack = false;
        }

        public BusPark(List<Vertex> m, PictureBox Bus, int PositionAt, List<Vertex> s, PictureBox Map, List<Epicenter> Epicenters, List<grid_part> Rectangles, int route)
        {
           
            this.Map = Map;

            this.Rectangles = new List<grid_part>();
            this.Rectangles = Rectangles;

            this.Epicenters = new List<Epicenter>();
            this.Epicenters = Epicenters;

            stop = new List<Vertex>();
            this.stop = s;

            V = new List<Vertex>();
            this.V = m;

            this.Bus = Bus;
            x = Bus.Left;
            y = Bus.Top;
            this.PositionAt = PositionAt;
            angle = GetAngle(this.V[PositionAt].x, this.V[PositionAt].y);
            TurnBack = false;
            this.route = route;
        }

        public BusPark(List<Vertex> m, PictureBox Bus, int PositionAt, bool Turn, List<Vertex> s)
        {

            V = new List<Vertex>();
            this.V = m;
            stop = new List<Vertex>();
            this.stop = s;

            this.Bus = Bus;
            x = Bus.Left;
            y = Bus.Top;
            this.PositionAt = PositionAt;
            angle = GetAngle(this.V[PositionAt].x, this.V[PositionAt].y);
            TurnBack = Turn;
        }

        public BusPark(List<Vertex> m, PictureBox Bus, int PositionAt, bool Turn, List<Vertex> s, PictureBox Map, List<Epicenter> Epicenters, int route)
        {
          
            this.Map = Map;
            this.Epicenters = new List<Epicenter>();
            this.Epicenters = Epicenters;
            V = new List<Vertex>();
            this.V = m;
            stop = new List<Vertex>();
            this.stop = s;
            this.Bus = Bus;
            x = Bus.Left;
            y = Bus.Top;
            this.PositionAt = PositionAt;
            angle = GetAngle(this.V[PositionAt].x, this.V[PositionAt].y);
            TurnBack = Turn;
            this.route = route;
        }

        public int getRoute()
        {
            return route;
        }

        double GetAngle(double x2, double y2)
        {
            return Math.Atan2((x - x2), (y - y2));
        }

        public double GetDistance(double x1, double y1, double x2, double y2)
        {
            return (int)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        private void DetectEpicenter()
        {
            for (int i = 0; i < Epicenters.Count; i++)
            {
                if ( GetDistance((double)Bus.Left + Bus.Width / 2, (double)Bus.Top + Bus.Height / 2, (double)Epicenters[i].x, (double)Epicenters[i].y) < ((Epicenters[i].radius / 2) / 2) / 2)
                {
                    
                    this.Map.CreateGraphics().DrawLine(new Pen(Color.DarkRed), Bus.Left + Bus.Width / 2, Bus.Top + Bus.Height, Bus.Left + Bus.Width / 2 + 1, Bus.Top + Bus.Height + 1);
                    this.Map.CreateGraphics().DrawLine(new Pen(Color.DarkRed), Bus.Left + Bus.Width / 2, Bus.Top - 1, Bus.Left + Bus.Width / 2 + 1, Bus.Top - 1);
                    this.Date += 2;
                    setTotal();

                }
                else
                if (Epicenters[i].check == false && GetDistance((double)Bus.Left + Bus.Width / 2, (double)Bus.Top + Bus.Height / 2, (double)Epicenters[i].x, (double)Epicenters[i].y) < (Epicenters[i].radius / 2) / 2)
                {
                   
                    this.Map.CreateGraphics().DrawLine(new Pen(Color.DarkOrange), Bus.Left + Bus.Width / 2, Bus.Top + Bus.Height, Bus.Left + Bus.Width / 2 + 1, Bus.Top + Bus.Height + 1);
                    this.Map.CreateGraphics().DrawLine(new Pen(Color.DarkOrange), Bus.Left + Bus.Width / 2, Bus.Top - 1, Bus.Left + Bus.Width / 2 + 1, Bus.Top - 1);
                    this.Date += 5;
                    setTotal();
                }
                else
                if (Rectangles[i].check == false && GetDistance((double)Bus.Left + Bus.Width / 2, (double)Bus.Top + Bus.Height / 2, (double)Epicenters[i].x, (double)Epicenters[i].y) < Epicenters[i].radius / 2)
                {
                    
                    this.Map.CreateGraphics().DrawLine(new Pen(Color.Yellow), Bus.Left + Bus.Width / 2, Bus.Top + Bus.Height, Bus.Left + Bus.Width / 2 + 1, Bus.Top + Bus.Height + 1);
                    this.Map.CreateGraphics().DrawLine(new Pen(Color.Yellow), Bus.Left + Bus.Width / 2, Bus.Top - 1, Bus.Left + Bus.Width / 2 + 1, Bus.Top - 1);
                    this.Date += 10;
                    setTotal();
                }

            }
        }


        private void DetectRectangle()
        {
            for (int i = 0; i < Rectangles.Count; i++)
            {
                if (GetDistance((double)Bus.Left + Bus.Width / 2, (double)Bus.Top + Bus.Height / 2, (double)Rectangles[i].x+ Rectangles[i].width /2, (double)Rectangles[i].y+ Rectangles[i].height /2) < Rectangles[i].width /2 )
                {

                    //Rectangles[i].check = true;
                    Rectangles[i].res += 1;
                    setTotal();

                }

            }
        }


        private void TimerDetectProcessor(object sender, EventArgs e)
        {
            DetectEpicenter();
            DetectRectangle();
        }
        private void TimerMoveProcessor(object sender, EventArgs e)
        {
            Move();
        }
        public void Start()
        {
            MovingTimer = new Timer();
            MovingTimer.Interval = 1;
            DetectTimer = new Timer();
            DetectTimer.Interval =1;
            MovingTimer.Tick += new EventHandler(TimerMoveProcessor);
            DetectTimer.Tick += new EventHandler(TimerDetectProcessor);
            MovingTimer.Start();
            DetectTimer.Start();
        }

        public void Move()
        {
            if (TurnBack == false)
            {
                if ((TurnBack == false) && (Math.Abs((Math.Abs(x) + Math.Abs(y)) - (Math.Abs((V[PositionAt].x) + Math.Abs(V[PositionAt].y))))) > 3)
                {
                 
                    x -= Math.Sin(angle);
                    y -= Math.Cos(angle);

                    Bus.Left = (int)x;
                    Bus.Top = (int)y;

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
                //  System.Threading.Thread.Sleep(500);
                //Timer.Enabled = true;

            }
            if (TurnBack == true)
            {

                if ((Math.Abs((Math.Abs(x) + Math.Abs(y)) - (Math.Abs(V[PositionAt].x + Math.Abs(V[PositionAt].y))))) > 3)
                {
              
                    x -= Math.Sin(angle);
                    y -= Math.Cos(angle);


                    Bus.Left = (int)x;
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
    }
    public class Epicenter
    {

        //private PictureBox Map;
        public int x, y, radius, res;
        public bool check = false;  //todo

        public Epicenter(PictureBox Map, int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            //this.height = height;
            //this.Map = Map;

            //this.Map.CreateGraphics().FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 255, 0)), x-radius/2, y-radius/2, radius, radius);
            //this.Map.CreateGraphics().FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 128, 0)), (x + radius / 4)-radius / 2, (y + radius / 4)-radius / 2, radius / 2, radius / 2);
            //this.Map.CreateGraphics().FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 0, 0)), ((int)(x + (double)radius / 2.7))-radius / 2, ((int)(y + (double)radius / 2.7)) - radius / 2, radius / 4, radius / 4) ;
        }
        public void DrawEpicenter(Graphics g)
        {

            g.FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 255, 0)), x - radius / 2, y - radius / 2, radius, radius);
            g.FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 128, 0)), (x + radius / 4) - radius / 2, (y + radius / 4) - radius / 2, radius / 2, radius / 2);
            g.FillEllipse(new SolidBrush(Color.FromArgb(128, 255, 0, 0)), ((int)(x + (double)radius / 2.7)) - radius / 2, ((int)(y + (double)radius / 2.7)) - radius / 2, radius / 4, radius / 4);
            //this.Map.CreateGraphics().FillRectangle(new SolidBrush(Color.FromArgb(128, 255, 255, 0)), x - radius / 2, y - radius / 2, radius, radius);
        }
    }

    public class grid_part
    {


        public int x, y, width, height, res;
        public bool check = false;  //todo

        public grid_part(int x, int y, int height, int width)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        public void setRes() {
            this.res += 1;
        }

        public void DrawPart(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black, 1), x, y, width, height);
        }
    }


}