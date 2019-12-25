using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystAnalys_lr1
{
    class AllRotations
    {
        static List<Point> AllRotationsPoints = new List<Point>();
        static List<Vertex> route23 = new List<Vertex>();
        static List<Vertex> route7 = new List<Vertex>();
        static List<Vertex> route62 = new List<Vertex>();
        static List<Vertex> route43 = new List<Vertex>();
        static List<Vertex> route20 = new List<Vertex>();
        static List<Vertex> route404 = new List<Vertex>();
        static List<Vertex> route107 = new List<Vertex>();
        static List<Vertex> stop = new List<Vertex>();


        public static List<Vertex> GetRoute20()
        {
            route20.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(0, 642))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(0, 642))].Y));
            route20.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(164, 620))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(164, 620))].Y));
            route20.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(163, 579))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(163, 579))].Y));
            route20.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(179, 563))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(179, 563))].Y));
            route20.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(167, 513))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(167, 513))].Y));
            route20.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(213, 484))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(213, 484))].Y));
            route20.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            route20.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(565, 276))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(565, 276))].Y));
            route20.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(629, 275))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(629, 275))].Y));
            route20.Add(new Vertex(AllRotationsPoints[15].X, AllRotationsPoints[15].Y));
            route20.Add(new Vertex(AllRotationsPoints[16].X, AllRotationsPoints[16].Y));
            route20.Add(new Vertex(AllRotationsPoints[17].X, AllRotationsPoints[17].Y));
            route20.Add(new Vertex(AllRotationsPoints[18].X, AllRotationsPoints[18].Y));
            route20.Add(new Vertex(AllRotationsPoints[19].X, AllRotationsPoints[19].Y));
            route20.Add(new Vertex(AllRotationsPoints[20].X, AllRotationsPoints[20].Y));
            return route20;
        }

        public static List<Vertex> GetRoute43()
        {
            route43.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(0, 642))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(0, 642))].Y));
            route43.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(164, 620))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(164, 620))].Y));
            route43.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(163, 579))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(163, 579))].Y));
            route43.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(179, 563))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(179, 563))].Y));
            route43.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(167, 513))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(167, 513))].Y));
            route43.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(213, 484))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(213, 484))].Y));
            route43.Add(route7[1]);
            route43.Add(route7[2]);
            route43.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(623, 314))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(623, 314))].Y));
            route43.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(629, 275))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(629, 275))].Y));
            route43.Add(new Vertex(AllRotationsPoints[15].X, AllRotationsPoints[15].Y));
            route43.Add(new Vertex(AllRotationsPoints[16].X, AllRotationsPoints[16].Y));
            route43.Add(new Vertex(AllRotationsPoints[17].X, AllRotationsPoints[17].Y));
            route43.Add(new Vertex(AllRotationsPoints[18].X, AllRotationsPoints[18].Y));
            route43.Add(new Vertex(AllRotationsPoints[19].X, AllRotationsPoints[19].Y));
            route43.Add(new Vertex(AllRotationsPoints[19].X, AllRotationsPoints[19].Y));
            route43.Add(new Vertex(AllRotationsPoints[18].X, AllRotationsPoints[18].Y));
            route43.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(890, 187))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(890, 187))].Y));
            route43.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1034, 187))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1034, 187))].Y));

            return route43;
        }

        public static List<Vertex> GetRoute107()
        {
       
            route107.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1515, 547))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1515, 547))].Y));
            route107.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1452, 567))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1452, 567))].Y));
            route107.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1411, 573))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1411, 573))].Y));
            route107.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1341, 609))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1341, 609))].Y));
            route107.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1175, 606))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1175, 606))].Y));
            route107.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1151, 507))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1151, 507))].Y));
            route107.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1079, 544))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1079, 544))].Y));
            route107.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1036, 541))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1036, 541))].Y));
            route107.Add(new Vertex(AllRotationsPoints[10].X, AllRotationsPoints[10].Y));
            route107.Add(new Vertex(AllRotationsPoints[11].X, AllRotationsPoints[11].Y));
            route107.Add(new Vertex(AllRotationsPoints[12].X, AllRotationsPoints[12].Y));
            route107.Add(new Vertex(AllRotationsPoints[13].X, AllRotationsPoints[13].Y));
            route107.Add(new Vertex(AllRotationsPoints[14].X, AllRotationsPoints[14].Y));
            route107.Add(new Vertex(AllRotationsPoints[15].X, AllRotationsPoints[15].Y));
            route107.Add(new Vertex(AllRotationsPoints[16].X, AllRotationsPoints[16].Y));
            route107.Add(new Vertex(AllRotationsPoints[17].X, AllRotationsPoints[17].Y));
            route107.Add(new Vertex(AllRotationsPoints[18].X, AllRotationsPoints[18].Y));
            route107.Add(new Vertex(AllRotationsPoints[19].X, AllRotationsPoints[19].Y));
            route107.Add(new Vertex(AllRotationsPoints[20].X, AllRotationsPoints[20].Y));
            return route107;
        }




        public static List<Vertex> GetRoute404()
        {

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
            return route404;
        }



        public static List<Vertex> GetRoute62()
        {
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
            return route62;    
        }      

        private static Vertex CallRotationPoint(List<Point> AllRotationsPoints, int x, int y)
        {
            return new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(x, y))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(x, y))].Y);
        }


        public static List<Vertex> GetStop()
        {
            stop.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            stop.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(164, 620))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(164, 620))].Y));
            stop.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            stop.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(179, 563))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(179, 563))].Y));
            stop.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            stop.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(213, 484))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(213, 484))].Y));
            stop.Add(route7[1]);
            stop.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            stop.Add(route7[3]);
            stop.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            stop.Add(route7[5]);
            stop.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            stop.Add(route7[7]);
            stop.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            stop.Add(route7[9]);
            stop.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            stop.Add(new Vertex(AllRotationsPoints[16].X, AllRotationsPoints[16].Y));
            stop.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            stop.Add(new Vertex(AllRotationsPoints[18].X, AllRotationsPoints[18].Y));
            //stop.Add(new Vertex(AllRotationsPoints[0].X, AllRotationsPoints[0].Y));
            //stop.Add(new Vertex(AllRotationsPoints[20].X, AllRotationsPoints[20].Y));

            return stop;
        }

        public static List<Vertex> GetRoute7()
        {
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

            return route7;
        }

        public static List<Vertex> GetRoute23()
        {
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
          //  route23.Add(new Vertex(AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1034, 187))].X, AllRotationsPoints[AllRotationsPoints.IndexOf(new Point(1034, 187))].Y));

            return route23;
        }

        public static List<Point> GetAllRotationsPoints()
        {
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
            AllRotationsPoints.Add(new Point(1515, 547));
            AllRotationsPoints.Add(new Point(1452, 567));
            AllRotationsPoints.Add(new Point(1411, 573));
            AllRotationsPoints.Add(new Point(1341, 609));
            AllRotationsPoints.Add(new Point(1175, 606));
            AllRotationsPoints.Add(new Point(1151, 507));
            AllRotationsPoints.Add(new Point(1079, 544));
            AllRotationsPoints.Add(new Point(869, 312));
            AllRotationsPoints.Add(new Point(828, 342));
            AllRotationsPoints.Add(new Point(805, 448));
            AllRotationsPoints.Add(new Point(804, 565));
            AllRotationsPoints.Add(new Point(814, 608));
            AllRotationsPoints.Add(new Point(912, 736));
            AllRotationsPoints.Add(new Point(728, 871));
            AllRotationsPoints.Add(new Point(623, 314));
            AllRotationsPoints.Add(new Point(629, 275));
            return AllRotationsPoints;
        }

    }
}