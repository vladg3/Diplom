using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace SystAnalys_lr1
{
    public partial class Form1 : Form
    {
        DrawGraph G;
        List<Epicenters> testim;
        List<Vertex> route7;
        List<Vertex> route23;
        List<Vertex> route62;
        List<Vertex> route404;
        List<Edge> E;
        List<Point> AllRotationsPoints;
        BusPark Bus7_1, Bus7_2, Bus7_3, Bus7_4, Bus7_5, Bus7_6, Bus7_7, Bus7_8, Bus7_9, Bus7_10, Bus7_11, Bus7_12, Bus7_13, Bus7_14, Bus7_15, Bus7_16, Bus23_1, Bus23_2, Bus62_1, Bus404_1, Bus404_2;//////////////////////////////////////////////////////////////////////////NEW
        Epicenters test;


        int[,] AMatrix; //матрица смежности
        int[,] IMatrix; //матрица инцидентности

        int selected1; //выбранные вершины, для соединения линиями
        int selected2;

    

        public Form1()
        {
            InitializeComponent();
            AllRotationsPoints = new List<Point>();
            
            AllRotationsPoints.Add(new Point(204, 438));
            AllRotationsPoints.Add(new Point(247, 577));
            AllRotationsPoints.Add(new Point(490, 530));
            AllRotationsPoints.Add(new Point(574, 708));
            AllRotationsPoints.Add(new Point(642, 728));            
            AllRotationsPoints.Add(new Point(739, 658));
            AllRotationsPoints.Add(new Point(854, 794));
            AllRotationsPoints.Add(new Point(1063, 633));
            AllRotationsPoints.Add(new Point(1043, 575));
            AllRotationsPoints.Add(new Point(1036, 541));
            AllRotationsPoints.Add(new Point(931, 390));
            AllRotationsPoints.Add(new Point(1029, 320));
            AllRotationsPoints.Add(new Point(974, 247));
            AllRotationsPoints.Add(new Point(878, 311));
            AllRotationsPoints.Add(new Point(848, 277));
            AllRotationsPoints.Add(new Point(680, 268));
            AllRotationsPoints.Add(new Point(684, 69));
            AllRotationsPoints.Add(new Point(797, 68));
            AllRotationsPoints.Add(new Point(847, 121));
            AllRotationsPoints.Add(new Point(1032, 2));
            AllRotationsPoints.Add(new Point(1109, 12));
            AllRotationsPoints.Add(new Point(213, 484));
            AllRotationsPoints.Add(new Point(167, 513));
            AllRotationsPoints.Add(new Point(179, 563));
            AllRotationsPoints.Add(new Point(163, 579));
            AllRotationsPoints.Add(new Point(164, 620));
            AllRotationsPoints.Add(new Point(0, 642));
            AllRotationsPoints.Add(new Point(888, 278));
            AllRotationsPoints.Add(new Point(890, 187));
            AllRotationsPoints.Add(new Point(373, 377));
            AllRotationsPoints.Add(new Point(400, 375));
            AllRotationsPoints.Add(new Point(565, 276));
            AllRotationsPoints.Add(new Point(1034, 187));
            ////
            AllRotationsPoints.Add(new Point(1515, 547));
            AllRotationsPoints.Add(new Point(1452, 567));
            AllRotationsPoints.Add(new Point(1411, 573));
            AllRotationsPoints.Add(new Point(1341, 609));
            AllRotationsPoints.Add(new Point(1175, 606));
            AllRotationsPoints.Add(new Point(1151, 507));
            AllRotationsPoints.Add(new Point(1079, 544));
            //AllRotationsPoints.Add(new Point(1036, 541));
            AllRotationsPoints.Add(new Point(869, 312));
            AllRotationsPoints.Add(new Point(828, 342));
            AllRotationsPoints.Add(new Point(805, 448));
            AllRotationsPoints.Add(new Point(804, 565));
            AllRotationsPoints.Add(new Point(814, 608));
            AllRotationsPoints.Add(new Point(912, 736));
            AllRotationsPoints.Add(new Point(728, 871));


            route7 = new List<Vertex>();

            route7.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            route7.Add(new Vertex(AllRotationsPoints[1].X, AllRotationsPoints[1].Y));
            route7.Add(new Vertex(AllRotationsPoints[2].X, AllRotationsPoints[2].Y));
            route7.Add(new Vertex(AllRotationsPoints[3].X, AllRotationsPoints[3].Y));
            route7.Add(new Vertex(AllRotationsPoints[4].X, AllRotationsPoints[4].Y));
            route7.Add(new Vertex(AllRotationsPoints[5].X, AllRotationsPoints[5].Y));
            route7.Add(new Vertex(AllRotationsPoints[6].X, AllRotationsPoints[6].Y));
            route7.Add(new Vertex(AllRotationsPoints[7].X, AllRotationsPoints[7].Y));
            route7.Add(new Vertex(AllRotationsPoints[8].X, AllRotationsPoints[8].Y));
            route7.Add(new Vertex(AllRotationsPoints[9].X, AllRotationsPoints[9].Y));
            route7.Add(new Vertex(AllRotationsPoints[10].X, AllRotationsPoints[10].Y));
            route7.Add(new Vertex(AllRotationsPoints[11].X, AllRotationsPoints[11].Y));
            route7.Add(new Vertex(AllRotationsPoints[12].X, AllRotationsPoints[12].Y));
            route7.Add(new Vertex(AllRotationsPoints[13].X, AllRotationsPoints[13].Y));
            route7.Add(new Vertex(AllRotationsPoints[14].X, AllRotationsPoints[14].Y));
            route7.Add(new Vertex(AllRotationsPoints[15].X, AllRotationsPoints[15].Y));
            route7.Add(new Vertex(AllRotationsPoints[16].X, AllRotationsPoints[16].Y));
            route7.Add(new Vertex(AllRotationsPoints[17].X, AllRotationsPoints[17].Y));
            route7.Add(new Vertex(AllRotationsPoints[18].X, AllRotationsPoints[18].Y));
            route7.Add(new Vertex(AllRotationsPoints[19].X, AllRotationsPoints[19].Y));
            route7.Add(new Vertex(AllRotationsPoints[20].X, AllRotationsPoints[20].Y));

           
            route62 = new List<Vertex>();
       
            route62.Add(CallRotationPoint(AllRotationsPoints, 1034, 187));
            route62.Add(CallRotationPoint(AllRotationsPoints, 890, 187));
            route62.Add(CallRotationPoint(AllRotationsPoints, 888, 278));
            route62.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(565, 276))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(565, 276))].Y));
            route62.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(400, 375))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(400, 375))].Y));
            route62.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(373, 377))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(373, 377))].Y));
            route62.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            route62.Add(route7[1]);
            route62.Add(route7[2]);
            route62.Add(route7[3]);
            route62.Add(route7[4]);
            route62.Add(route7[5]);
            route62.Add(route7[6]);
            route62.Add(route7[7]);
            route62.Add(route7[8]);
            route62.Add(route7[9]);
            route62.Add(route7[14]);
            route62.Add(CallRotationPoint(AllRotationsPoints, 888, 278));
            route62.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(890, 187))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(890, 187))].Y));
            route62.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1034, 187))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1034, 187))].Y));
           
            route23 = new List<Vertex>();

            route23.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(0, 642))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(0, 642))].Y));
            route23.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(164, 620))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(164, 620))].Y));
            route23.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(163, 579))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(163, 579))].Y));
            route23.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(179, 563))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(179, 563))].Y));
            route23.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(167, 513))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(167, 513))].Y));
            route23.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(213, 484))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(213, 484))].Y));
            route23.Add(route7[1]);
            route23.Add(route7[2]);
            route23.Add(route7[3]);
            route23.Add(route7[4]);
            route23.Add(route7[5]);
            route23.Add(route7[6]);
            route23.Add(route7[7]);
            route23.Add(route7[8]);
            route23.Add(route7[9]);
            route23.Add(route7[14]);
            route23.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(888, 278))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(888, 278))].Y));
            route23.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(890, 187))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(890, 187))].Y));
            route23.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1034, 187))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1034, 187))].Y));

            route404 = new List<Vertex>();

            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1515, 547))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1515, 547))].Y));
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1452, 567))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1452, 567))].Y));
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1411, 573))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1411, 573))].Y));
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1341, 609))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1341, 609))].Y));
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1175, 606))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1175, 606))].Y));
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1151, 507))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1151, 507))].Y)); 
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1079, 544))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1079, 544))].Y));
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1036, 541))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1036, 541))].Y));
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(869, 312))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(869, 312))].Y));
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(828, 342))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(828, 342))].Y));
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(805, 448))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(805, 448))].Y)); 
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(804, 565))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(804, 565))].Y));
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(814, 608))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(814, 608))].Y));
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(912, 736))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(912, 736))].Y));
            route404.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(728, 871))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(728, 871))].Y));


       

            G = new DrawGraph(sheet.Width, sheet.Height);
            E = new List<Edge>();

            for (int i = 0; i < route62.Count; i++)
            {
                G.drawVertex(route62[i].x, route62[i].y, route62.Count.ToString());
                sheet.Image = G.GetBitmap();
                if (i + 1 < route62.Count)
                {
                    E.Add(new Edge(i, i + 1));
                    G.drawEdge(route62[i], route62[i + 1], E[E.Count - 1], E.Count - 1);
                    sheet.Image = G.GetBitmap();
                }
            }
            for (int i = 0; i < route7.Count; i++)
            {
                G.drawVertex(route7[i].x, route7[i].y, route7.Count.ToString());
                sheet.Image = G.GetBitmap();
                if (i + 1 < route7.Count)
                {
                    E.Add(new Edge(i, i + 1));
                    G.drawEdge(route7[i], route7[i + 1], E[E.Count - 1], E.Count - 1);
                    sheet.Image = G.GetBitmap();
                }
            }
            for (int i = 0; i < route23.Count; i++)
            {
                G.drawVertex(route23[i].x, route23[i].y, route23.Count.ToString());
                sheet.Image = G.GetBitmap();
                if(i + 1 < route23.Count)
                {
                    E.Add(new Edge(i, i + 1));
                    G.drawEdge(route23[i], route23[i + 1], E[E.Count - 1], E.Count - 1);
                    sheet.Image = G.GetBitmap();
                }
              
            }

            testim = new List<Epicenters>();
            testim.Add(new Epicenters(pictureBox5, 500, 500, 100));
            testim.Add(new Epicenters(pictureBox5, 900, 400, 50));

            Bus7_1 = new BusPark(route7, pictureBus7_1, 0, testim, pictureBox5);
            Bus7_2 = new BusPark(route7, pictureBox7_3, 10, testim, pictureBox5);
            Bus7_3 = new BusPark(route7, pictureBus7_2, 20, testim, pictureBox5);
            Bus7_4 = new BusPark(route7, pictureBox1, 1, testim, pictureBox5);
            Bus7_5 = new BusPark(route7, pictureBox2, 3, true, testim, pictureBox5);
            Bus7_6 = new BusPark(route7, pictureBox3, 5, testim, pictureBox5);
            Bus7_7 = new BusPark(route7, pictureBox4, 7, testim, pictureBox5);
            Bus7_8 = new BusPark(route7, pictureBox6, 9, true, testim, pictureBox5);
            Bus7_9 = new BusPark(route7, pictureBox8, 16, testim, pictureBox5);
            Bus7_10 = new BusPark(route7, pictureBox9, 13, testim, pictureBox5);
            Bus7_11 = new BusPark(route7, pictureBox10, 14, testim, pictureBox5);
            Bus7_12 = new BusPark(route7, pictureBox11, 16, true, testim, pictureBox5);
            Bus7_13 = new BusPark(route7, pictureBox12, 18, testim, pictureBox5);
            Bus7_14 = new BusPark(route7, pictureBox13, 20, testim, pictureBox5);
            Bus7_15 = new BusPark(route7, pictureBox14, 6, testim, pictureBox5);
            Bus7_16 = new BusPark(route7, pictureBox7, 10, true, testim, pictureBox5);

            Bus23_1 = new BusPark(route23, pictureBus23_1, 5, testim, pictureBox5);
            Bus23_2 = new BusPark(route23, pictureBus23_2, 14, testim, pictureBox5);
            Bus62_1 = new BusPark(route62, pictureBus62_1, 1, testim, pictureBox5);
            Bus404_1 = new BusPark(route404, pictureBus404_1, 1, testim, pictureBox5);
            Bus404_2 = new BusPark(route404, pictureBus404_2, route404.Count-1, testim, pictureBox5);
           // pictureBox5.CreateGraphics().FillEllipse(new LinearGradientBrush(new Point(0, 10), new Point(200, 10), Color.FromArgb(255, 255, 0, 0), Color.FromArgb(255, 0, 0, 255)), 0, 30, 200, 100);

            timer1.Interval = 1;
            timer1.Start();

       
        }

        private void button1_Click(object sender, EventArgs e)
        {

           // test = new Epicenters(pictureBox5,500,500, 350);
            
            testim[0].DrawEpicenter();
            testim[1].DrawEpicenter();
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private Vertex CallRotationPoint(List<Point> AllRotationsPoints,int x, int y)
        {
            return new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(x, y))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(x, y))].Y);
        }

        //кнопка - выбрать вершину
        private void selectButton_Click(object sender, EventArgs e)
        {
            selectButton.Enabled = false;
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            deleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(route7, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
        }

        //кнопка - рисовать вершину
        private void drawVertexButton_Click(object sender, EventArgs e)
        {
            drawVertexButton.Enabled = false;
            selectButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            deleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(route7, E);
            sheet.Image = G.GetBitmap();
        }

        //кнопка - рисовать ребро
        private void drawEdgeButton_Click(object sender, EventArgs e)
        {
            drawEdgeButton.Enabled = false;
            selectButton.Enabled = true;
            drawVertexButton.Enabled = true;
            deleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(route7, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
            selected2 = -1;
        }

        //кнопка - удалить элемент
        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteButton.Enabled = false;
            selectButton.Enabled = true;
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(route7, E);
            sheet.Image = G.GetBitmap();
        }

        //кнопка - удалить граф
        private void deleteALLButton_Click(object sender, EventArgs e)
        {
            selectButton.Enabled = true;
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            deleteButton.Enabled = true;
            const string message = "Вы действительно хотите полностью удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                route7.Clear();
                E.Clear();
                G.clearSheet();
                sheet.Image = G.GetBitmap();
            }
        }

        //кнопка - матрица смежности
        private void buttonAdj_Click(object sender, EventArgs e)
        {
            createAdjAndOut();
        }

        //кнопка - матрица инцидентности 
        private void buttonInc_Click(object sender, EventArgs e)
        {
            createIncAndOut();
        }

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            //нажата кнопка "выбрать вершину", ищем степень вершины
            if (selectButton.Enabled == false)
            {
                for (int i = 0; i < route7.Count; i++)
                {
                    if (Math.Pow((route7[i].x - e.X), 2) + Math.Pow((route7[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        if (selected1 != -1)
                        {
                            selected1 = -1;
                            G.clearSheet();
                            G.drawALLGraph(route7, E);
                            sheet.Image = G.GetBitmap();
                        }
                        if (selected1 == -1)
                        {
                            G.drawSelectedVertex(route7[i].x, route7[i].y);
                            selected1 = i;
                            sheet.Image = G.GetBitmap();
                            createAdjAndOut();
                            listBoxMatrix.Items.Clear();
                            int degree = 0;
                            for (int j = 0; j < route7.Count; j++)
                                degree += AMatrix[selected1, j];
                            listBoxMatrix.Items.Add("Степень вершины №" + (selected1 + 1) + " равна " + degree);
                            break;
                        }
                    }
                }
            }
            //нажата кнопка "рисовать вершину"
            if (drawVertexButton.Enabled == false)
            {
                route7.Add(new Vertex(e.X, e.Y));
                G.drawVertex(e.X, e.Y, route7.Count.ToString());
                sheet.Image = G.GetBitmap();
            }
            //нажата кнопка "рисовать ребро"
            if (drawEdgeButton.Enabled == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < route7.Count; i++)
                    {
                        if (Math.Pow((route7[i].x - e.X), 2) + Math.Pow((route7[i].y - e.Y), 2) <= G.R * G.R)
                        {
                            if (selected1 == -1)
                            {
                                G.drawSelectedVertex(route7[i].x, route7[i].y);
                                selected1 = i;
                                sheet.Image = G.GetBitmap();
                                break;
                            }
                            if (selected2 == -1)
                            {
                                G.drawSelectedVertex(route7[i].x, route7[i].y);
                                selected2 = i;
                                E.Add(new Edge(selected1, selected2));
                                G.drawEdge(route7[selected1], route7[selected2], E[E.Count - 1], E.Count - 1);
                                selected1 = -1;
                                selected2 = -1;
                                sheet.Image = G.GetBitmap();
                                break;
                            }
                        }
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    if ((selected1 != -1) &&
                        (Math.Pow((route7[selected1].x - e.X), 2) + Math.Pow((route7[selected1].y - e.Y), 2) <= G.R * G.R))
                    {
                        G.drawVertex(route7[selected1].x, route7[selected1].y, (selected1 + 1).ToString());
                        selected1 = -1;
                        sheet.Image = G.GetBitmap();
                    }
                }
            }
            //нажата кнопка "удалить элемент"
            if (deleteButton.Enabled == false)
            {
                bool flag = false; //удалили ли что-нибудь по ЭТОМУ клику
                //ищем, возможно была нажата вершина
                for (int i = 0; i < route7.Count; i++)
                {
                    if (Math.Pow((route7[i].x - e.X), 2) + Math.Pow((route7[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        for (int j = 0; j < E.Count; j++)
                        {
                            if ((E[j].v1 == i) || (E[j].v2 == i))
                            {
                                E.RemoveAt(j);
                                j--;
                            }
                            else
                            {
                                if (E[j].v1 > i) E[j].v1--;
                                if (E[j].v2 > i) E[j].v2--;
                            }
                        }
                        route7.RemoveAt(i);
                        flag = true;
                        break;
                    }
                }
                //ищем, возможно было нажато ребро
                if (!flag)
                {
                    for (int i = 0; i < E.Count; i++)
                    {
                        if (E[i].v1 == E[i].v2) //если это петля
                        {
                            if ((Math.Pow((route7[E[i].v1].x - G.R - e.X), 2) + Math.Pow((route7[E[i].v1].y - G.R - e.Y), 2) <= ((G.R + 2) * (G.R + 2))) &&
                                (Math.Pow((route7[E[i].v1].x - G.R - e.X), 2) + Math.Pow((route7[E[i].v1].y - G.R - e.Y), 2) >= ((G.R - 2) * (G.R - 2))))
                            {
                                E.RemoveAt(i);
                                flag = true;
                                break;
                            }
                        }
                        else //не петля
                        {
                            if (((e.X - route7[E[i].v1].x) * (route7[E[i].v2].y - route7[E[i].v1].y) / (route7[E[i].v2].x - route7[E[i].v1].x) + route7[E[i].v1].y) <= (e.Y + 4) &&
                                ((e.X - route7[E[i].v1].x) * (route7[E[i].v2].y - route7[E[i].v1].y) / (route7[E[i].v2].x - route7[E[i].v1].x) + route7[E[i].v1].y) >= (e.Y - 4))
                            {
                                if ((route7[E[i].v1].x <= route7[E[i].v2].x && route7[E[i].v1].x <= e.X && e.X <= route7[E[i].v2].x) ||
                                    (route7[E[i].v1].x >= route7[E[i].v2].x && route7[E[i].v1].x >= e.X && e.X >= route7[E[i].v2].x))
                                {
                                    E.RemoveAt(i);
                                    flag = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                //если что-то было удалено, то обновляем граф на экране
                if (flag)
                {
                    G.clearSheet();
                    G.drawALLGraph(route7, E);
                    sheet.Image = G.GetBitmap();
                }
            }
        }

        //создание матрицы смежности и вывод в листбокс
        private void createAdjAndOut()
        {
            AMatrix = new int[route7.Count, route7.Count];
            G.fillAdjacencyMatrix(route7.Count, E, AMatrix);
            listBoxMatrix.Items.Clear();
            string sOut = "    ";
            for (int i = 0; i < route7.Count; i++)
                sOut += (i + 1) + " ";
            listBoxMatrix.Items.Add(sOut);
            for (int i = 0; i < route7.Count; i++)
            {
                sOut = (i + 1) + " | ";
                for (int j = 0; j < route7.Count; j++)
                    sOut += AMatrix[i, j] + " ";
                listBoxMatrix.Items.Add(sOut);
            }
        }

        //создание матрицы инцидентности и вывод в листбокс
        private void createIncAndOut()
        {
            if (E.Count > 0)
            {
                IMatrix = new int[route7.Count, E.Count];
                G.fillIncidenceMatrix(route7.Count, E, IMatrix);
                listBoxMatrix.Items.Clear();
                string sOut = "    ";
                for (int i = 0; i < E.Count; i++)
                    sOut += (char)('a' + i) + " ";
                listBoxMatrix.Items.Add(sOut);
                for (int i = 0; i < route7.Count; i++)
                {
                    sOut = (i + 1) + " | ";
                    for (int j = 0; j < E.Count; j++)
                        sOut += IMatrix[i, j] + " ";
                    listBoxMatrix.Items.Add(sOut);
                }
            }
            else
                listBoxMatrix.Items.Clear();
        }

        //поиск элементарных цепей
        private void chainButton_Click(object sender, EventArgs e)
        {
            listBoxMatrix.Items.Clear();
            //1-white 2-black
            int[] color = new int[route7.Count];
            for (int i = 0; i < route7.Count - 1; i++)
                for (int j = i + 1; j < route7.Count; j++)
                {
                    for (int k = 0; k < route7.Count; k++)
                        color[k] = 1;
                    DFSchain(i, j, E, color, (i + 1).ToString());
                }
        }

        //обход в глубину. поиск элементарных цепей. (1-white 2-black)
        private void DFSchain(int u, int endV, List<Edge> E, int[] color, string s)
        {
            //вершину не следует перекрашивать, если u == endV (возможно в нее есть несколько путей)
            if (u != endV)  
                color[u] = 2;
            else
            {
                listBoxMatrix.Items.Add(s);
                return;
            }
            for (int w = 0; w < E.Count; w++)
            {
                if (color[E[w].v2] == 1 && E[w].v1 == u)
                {
                    DFSchain(E[w].v2, endV, E, color, s + "-" + (E[w].v2 + 1).ToString());
                    color[E[w].v2] = 1;
                }
                else if (color[E[w].v1] == 1 && E[w].v2 == u)
                {
                    DFSchain(E[w].v1, endV, E, color, s + "-" + (E[w].v1 + 1).ToString());
                    color[E[w].v1] = 1;
                }
            }
        }

        //поиск элементарных циклов
        private void cycleButton_Click(object sender, EventArgs e)
        {
            listBoxMatrix.Items.Clear();
            //1-white 2-black
            int[] color = new int[route7.Count];
            for (int i = 0; i < route7.Count; i++)
            {
                for (int k = 0; k < route7.Count; k++)
                    color[k] = 1;
                List<int> cycle = new List<int>();
                cycle.Add(i + 1);
                DFScycle(i, i, E, color, -1, cycle);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
          
            label2.Text = e.X.ToString() + ";" + e.Y.ToString();
            
        }

        //обход в глубину. поиск элементарных циклов. (1-white 2-black)
        //Вершину, для которой ищем цикл, перекрашивать в черный не будем. Поэтому, для избежания неправильной
        //работы программы, введем переменную unavailableEdge, в которой будет хранится номер ребра, исключаемый
        //из рассмотрения при обходе графа. В действительности это необходимо только на первом уровне рекурсии,
        //чтобы избежать вывода некорректных циклов вида: 1-2-1, при наличии, например, всего двух вершин.

        private void DFScycle(int u, int endV, List<Edge> E, int[] color, int unavailableEdge, List<int> cycle)
        {
            //если u == endV, то эту вершину перекрашивать не нужно, иначе мы в нее не вернемся, а вернуться необходимо
            if (u != endV)
                color[u] = 2;
            else
            {
                if (cycle.Count >= 2)
                {
                    cycle.Reverse();
                    string s = cycle[0].ToString();
                    for (int i = 1; i < cycle.Count; i++)
                        s += "-" + cycle[i].ToString();
                    bool flag = false; //есть ли палиндром для этого цикла графа в листбоксе?
                    for (int i = 0; i < listBoxMatrix.Items.Count; i++)
                        if (listBoxMatrix.Items[i].ToString() == s)
                        {
                            flag = true;
                            break;
                        }
                    if (!flag)
                    {
                        cycle.Reverse();
                        s = cycle[0].ToString();
                        for (int i = 1; i < cycle.Count; i++)
                            s += "-" + cycle[i].ToString();
                        listBoxMatrix.Items.Add(s);
                    }
                    return;
                }
            }
            for (int w = 0; w < E.Count; w++)
            {
                if (w == unavailableEdge)
                    continue;
                if (color[E[w].v2] == 1 && E[w].v1 == u)
                {
                    List<int> cycleNEW = new List<int>(cycle);
                    cycleNEW.Add(E[w].v2 + 1);
                    DFScycle(E[w].v2, endV, E, color, w, cycleNEW);
                    color[E[w].v2] = 1;
                }
                else if (color[E[w].v1] == 1 && E[w].v2 == u)
                {
                    List<int> cycleNEW = new List<int>(cycle);
                    cycleNEW.Add(E[w].v1 + 1);
                    DFScycle(E[w].v1, endV, E, color, w, cycleNEW);
                    color[E[w].v1] = 1;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (sheet.Image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sheet.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////NEW
        private void timer1_Tick(object sender, EventArgs e)
        {

            Bus7_1.Move();
            Bus7_2.Move();
            Bus7_3.Move();
            Bus7_4.Move();
            Bus7_5.Move();
            Bus7_6.Move();
            Bus7_7.Move();
            Bus7_8.Move();
            Bus7_9.Move();
            Bus7_10.Move();
            Bus7_11.Move();
            Bus7_12.Move();
            Bus7_13.Move();
            Bus7_14.Move();
            Bus7_15.Move();
            Bus7_16.Move();
            Bus23_1.Move();
            Bus23_2.Move();
            Bus62_1.Move();
            Bus404_1.Move();
            Bus404_2.Move();
        }
    }
}
