using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SystAnalys_lr1
{
    public partial class Form1 : Form
    {
        List<Epicenter> Epics;
        DrawGraph G;
        DisplayEpicenters Ep;
        List<Vertex> route7;
        List<Vertex> route23;
        List<Vertex> route62;
        List<Vertex> route404;
        List<Vertex> route20;
        List<Vertex> route43;
        List<Vertex> route107;

        List<Vertex> stop;
        List<Edge> E;
        List<Point> AllRotationsPoints;
        static BusPark Bus7_1, Bus7_2, Bus7_3, Bus7_4, Bus7_5, Bus7_6, Bus7_7, Bus7_8, Bus7_9, Bus7_10, Bus7_11, Bus7_12, Bus7_13, Bus7_14, Bus7_15, Bus7_16, Bus23_1,
            Bus23_2, Bus62_1, Bus404_1, Bus404_2,
            Bus_107, Bus_43, Bus_20;

        private void button2_Click(object sender, EventArgs e)
        {

            Bus7_1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Bus23_1.Move();
            Bus23_2.Move();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = e.X.ToString() + ";" + e.Y.ToString();
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = e.X.ToString() + ";" + e.Y.ToString();
        }

        List<BusPark> a = new List<BusPark>() { Bus7_1, Bus7_2, Bus7_3, Bus7_4, Bus7_5, Bus7_6, Bus7_7, Bus7_8, Bus7_9, Bus7_10, Bus7_11, Bus7_12, Bus7_13, Bus7_14, Bus7_15, Bus7_16, Bus23_1,
            Bus23_2, Bus62_1, Bus404_1, Bus404_2 };
        List<string> b = new List<string>() { "7", "2", "6", "4" };
        List<string> ab = new List<string>() { "Bus7_1", "Bus7_2", "Bus7_3", "Bus7_4", "Bus7_5", "Bus7_6", "Bus7_7", "Bus7_8", "Bus7_9",
            "Bus7_10", "Bus7_11", "Bus23_2", "Bus62_1", "Bus404_1", "Bus404_2" };

        //int[,] myArr = new int[4, 5];

        //void Test()
        //{

        //    for (int i = 0; i < b.Count(); i++)
        //    {
        //        for (int j = 0; j < ab.Count(); j++)
        //        {
        //            if(ab[j].Substring(3, 1) == b[i])
        //            {
        //                myArr[i, j] = 1;
        //                label1.Text += myArr[i, j] + " ";  /////////////// ПОПЫТКА РЕАЛИЗАЦИИ МАТРИЦЫ)
        //            }
        //            else
        //            {
        //                myArr[i, j] = 0;
        //                label1.Text += myArr[i, j] + " ";
        //            }     

        //        }
        //    }

        //}

        public Form1()
        {
            InitializeComponent();
            // Test();
            AllRotations rotations = new AllRotations();
            G = new DrawGraph(sheet.Width, sheet.Height);
            E = new List<Edge>();

            AllRotationsPoints = AllRotations.GetAllRotationsPoints();
            route7 = AllRotations.GetRoute7();
            route23 = AllRotations.GetRoute23();
            stop = AllRotations.GetStop();
            route62 = AllRotations.GetRoute62();
            route404 = AllRotations.GetRoute404();
            route107 = AllRotations.GetRoute107();
            route43 = AllRotations.GetRoute43();
            route20 = AllRotations.GetRoute20();

            Routes(route107);
            Routes(route7);
            Routes(route62);
            Routes(route23);
            Routes(route43);

            AddEpicenters();

            AddBuses();

            //timer1.Interval = 1;
            //timer1.Start();

            //timer2.Interval = 1;
            //timer2.Start();




            DisplayEpicenters Ep = new DisplayEpicenters(Epics);

            Ep.Show();
            Ep.Draw();

        }

        private void AddBuses()
        {
            Bus7_1 = new BusPark(route7, pictureBus7_1, 0, stop, pictureBox5, Epics);

          //  Bus7_1.Start();

            Bus7_2 = new BusPark(route7, pictureBox7_3, 10, stop, pictureBox5, Epics);
            Bus7_3 = new BusPark(route7, pictureBus7_2, 20, stop, pictureBox5, Epics);
            Bus7_4 = new BusPark(route7, pictureBox1, 1, stop, pictureBox5, Epics);
            Bus7_5 = new BusPark(route7, pictureBox2, 3, true, stop, pictureBox5, Epics);
            Bus7_6 = new BusPark(route7, pictureBox3, 5, stop, pictureBox5, Epics);
            Bus7_7 = new BusPark(route7, pictureBox4, 7, stop, pictureBox5, Epics);
            Bus7_8 = new BusPark(route7, pictureBox6, 9, true, stop, pictureBox5, Epics);
            Bus7_9 = new BusPark(route7, pictureBox8, 16, stop, pictureBox5, Epics);
            Bus7_10 = new BusPark(route7, pictureBox9, 13, stop, pictureBox5, Epics);
            Bus7_11 = new BusPark(route7, pictureBox10, 14, stop, pictureBox5, Epics);
            Bus7_12 = new BusPark(route7, pictureBox11, 16, true, stop, pictureBox5, Epics);
            Bus7_13 = new BusPark(route7, pictureBox12, 18, stop, pictureBox5, Epics);
            Bus7_14 = new BusPark(route7, pictureBox13, 20, stop, pictureBox5, Epics);
            Bus7_15 = new BusPark(route7, pictureBox14, 6, stop, pictureBox5, Epics);
            Bus7_16 = new BusPark(route7, pictureBox7, 10, true, stop, pictureBox5, Epics);

            Bus23_1 = new BusPark(route23, pictureBus23_1, 5, stop, pictureBox5, Epics);
            Bus23_1.Start();
            Bus23_2 = new BusPark(route23, pictureBus23_2, 14, stop, pictureBox5, Epics);
            Bus62_1 = new BusPark(route62, pictureBus62_1, 1, stop, pictureBox5, Epics);
            Bus404_1 = new BusPark(route404, pictureBus404_1, 1, stop, pictureBox5, Epics);
            Bus404_2 = new BusPark(route404, pictureBus404_2, route404.Count - 1, stop, pictureBox5, Epics);

            Bus_107 = new BusPark(route107, pictureBox15, 0, stop, pictureBox5, Epics);
            Bus_43 = new BusPark(route43, pictureBox16, 0, stop, pictureBox5, Epics);
            Bus_20 = new BusPark(route20, pictureBox17, 0, stop, pictureBox5, Epics);
        }

        private void Routes(List<Vertex> route)
        {
            for (int i = 0; i < route.Count; i++)
            {
                G.drawVertex(route[i].x, route[i].y, route.Count.ToString());
                sheet.Image = G.GetBitmap();
                if (i + 1 < route.Count)
                {
                    E.Add(new Edge(i, i + 1));
                    G.drawEdge(route[i], route[i + 1], E[E.Count - 1], E.Count - 1);
                    sheet.Image = G.GetBitmap();
                }
            }
        }


        private void AddEpicenters()
        {
            Epics = new List<Epicenter>();
            Epics.Add(new Epicenter(pictureBox5, 500, 500, 300));
            Epics.Add(new Epicenter(pictureBox5, 930, 400, 150));
            Epics.Add(new Epicenter(pictureBox5, 700, 730, 250));
            Epics.Add(new Epicenter(pictureBox5, 800, 100, 220));
            Epics.Add(new Epicenter(pictureBox5, 400, 370, 120));
            Epics.Add(new Epicenter(pictureBox5, 900, 790, 134));
            Epics.Add(new Epicenter(pictureBox5, 817, 395, 300));
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Epics.Count; i++)
            {
                Epics[i].DrawEpicenter(pictureBox5);
            }
           
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //Bus7_1.Move();
            //Bus7_2.Move();
            //Bus7_3.Move();
            //Bus7_4.Move();
            //Bus7_5.Move();
            //Bus7_6.Move();
            //Bus7_7.Move();
            //Bus7_8.Move();
            //Bus7_9.Move();
            //Bus7_10.Move();
            //Bus7_11.Move();
            //Bus7_12.Move();
            //Bus7_13.Move();
            //Bus7_14.Move();
            //Bus7_15.Move();
            //Bus7_16.Move();

            //Bus23_2.Move();
            //Bus62_1.Move();
            //Bus404_1.Move();
            //Bus404_2.Move();

            //Bus_43.Move();

            //Bus_107.Move();


            //Bus_20.Move();
        }


    }
}
