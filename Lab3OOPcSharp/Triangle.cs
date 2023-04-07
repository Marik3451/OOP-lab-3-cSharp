using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3OOPcSharp
{
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }
        public class Triangle
        {
            public Point A { get; set; }
            public Point B { get; set; }
            public Point C { get; set; }
            public double SideAB => Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            public double SideAC => Math.Sqrt(Math.Pow(C.X - A.X, 2) + Math.Pow(C.Y - A.Y, 2));
            public double SideBC => Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));
            public double Perimeter => SideAB + SideAC + SideBC;
            public double Area => Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - SideAB) * (Perimeter / 2 - SideAC) * (Perimeter / 2 - SideBC));
            public Point MedianCrossPoint => new Point((A.X + B.X + C.X) / 3, (A.Y + B.Y + C.Y) / 3);
            public Triangle(double xA, double yA, double xB, double yB, double xC, double yC)
            {
                A = new Point(xA, yA);
                B = new Point(xB, yB);
                C = new Point(xC, yC);
            }
            public class Point
            {
                public double X { get; set; }
                public double Y { get; set; }

                public Point(double x, double y)
                {
                    X = x;
                    Y = y;
                }
            }
            public static string IsExist(double xA, double yA, double xB, double yB, double xC, double yC)
               // public static string IsExist1(Point A,Point B,Point C)
            {
                double sideAB = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
                double sideAC = Math.Sqrt(Math.Pow(xC - xA, 2) + Math.Pow(yC - yA, 2));
                double sideBC = Math.Sqrt(Math.Pow(xC - xB, 2) + Math.Pow(yC - yB, 2));
                if (sideAB + sideAC <= sideBC || sideAC + sideBC <= sideAB || sideAB + sideBC <= sideAC)
                {
                    throw new ArgumentException("Triangle does not exist");
                }
               
                return "Triangle exist"; 
            }
            public double Distance(Point first,Point second)
            {
               return Math.Sqrt(Math.Pow((second.X - first.X), 2) + Math.Pow((second.Y - first.X),2));
            }
         
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
         if (double.TryParse(XAtextBox.Text, out double xA) &&
             double.TryParse(YAtextBox.Text, out double yA) &&
             double.TryParse(XBtextBox.Text, out double xB) &&
             double.TryParse(YBtextBox.Text, out double yB) &&
             double.TryParse(XCtextBox.Text, out double xC) &&
             double.TryParse(YCtextBox.Text, out double yC)) 
            {
                Triangle triangle = new Triangle(xA, yA, xB, yB, xC, yC);
                try
                {
                    SideABtextBox.Text = triangle.SideAB.ToString();
                    SideACtextBox.Text = triangle.SideAC.ToString();
                    SideBCtextBox.Text = triangle.SideBC.ToString();
                    PerimetertextBox.Text = triangle.Perimeter.ToString();
                    AreatextBox.Text = triangle.Area.ToString();
                    MedianCrossPointtextBox.Text = $"{triangle.MedianCrossPoint.X}, {triangle.MedianCrossPoint.Y}";
                    IsExisttextBox.Text = Triangle.IsExist(xA, yA, xB, yB, xC, yC).ToString();
                }
                catch (ArgumentException ex)
                {
                    IsExisttextBox.Text = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Enter the correct values!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}