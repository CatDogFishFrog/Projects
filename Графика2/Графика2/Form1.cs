using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Графика2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle); //где рисуем
            Pen pen = new Pen(Color.Black);//чем рисуем
            Brush brush = Brushes.White;
            Brush brush1 = Brushes.Blue;
            HatchBrush brush2 = new HatchBrush(HatchStyle.Cross, ForeColor, BackColor); //Определяет заливку в виде сетки
            HatchBrush brush3 = new HatchBrush(HatchStyle.DiagonalCross, ForeColor, BackColor); //Определяет заливку в виде диагональной сетки
            HatchBrush brush4 = new HatchBrush(HatchStyle.ForwardDiagonal, ForeColor, BackColor); //Определяет заливку в виде диагональной прямой
            HatchBrush brush5 = new HatchBrush(HatchStyle.BackwardDiagonal, ForeColor, BackColor); //Определяет заливку в виде обратной диагонали

            Point[] p = //ну это наверное определяется местоположение первого рисунка
            {
                new Point(10,0),
                new Point(80,70),
                new Point(90,50),
                new Point(50,90),
            };

            Point[] p1 = //а это, я думаю, местоположение второго рисунка
            {
                new Point(0,110),
                new Point(80,180),
                new Point(90,160),
                new Point(50,200),
            };
            Rectangle rect = new Rectangle(0, 0, 110, 220);
            Rectangle rect1 = new Rectangle(10, 0, 10, 100); //а вот теперь я уже совсем не понимаю что где определяет
            Rectangle rect2= new Rectangle(10, 110, 100, 100);

            g.FillRectangle(brush, rect);

            if (comboBox2.SelectedIndex == 0) //начало выбора стилей линии
            {
                pen.DashStyle = DashStyle.Dash;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                pen.DashStyle = DashStyle.DashDot;
            }
            if (comboBox2.SelectedIndex == 2)
            {
                pen.DashStyle = DashStyle.DashDotDot;
            }
            if (comboBox2.SelectedIndex == 3)
            {
                pen.DashStyle = DashStyle.Dot;
            }                                 //конец выбора стилей линии


            if (comboBox4.SelectedIndex == 0) //начало выбора стиля заливки
            {
                brush1 = brush2;
            }
            if (comboBox4.SelectedIndex == 1)
            {
                brush1 = brush3;
            }
            if (comboBox4.SelectedIndex == 2)
            {
                brush1 = brush4;
            }
            if (comboBox4.SelectedIndex == 3)
            {
                brush1 = brush5;
            }                                 // конец выбора стиля заливки


            if (comboBox1.SelectedIndex == 3)   //3 DrawRectangle
            {
                g.DrawRectangle(pen, rect1);
            }
            if (comboBox3.SelectedIndex == 1)   //1 FillRectangle
            {
                g.FillRectangle(brush1,10,110,100,100);
            }
            if (comboBox1.SelectedIndex == 4)   //4 DrawPolygon
            {
                g.DrawPolygon(pen, p);
            }
            if (comboBox3.SelectedIndex == 2) //2 FillPolygon
            {
                g.FillPolygon(brush1, p1);
            }
            if (comboBox1.SelectedIndex == 5)  //5 DrawEllipse
            {
                g.DrawEllipse(pen,rect1);
            }
            if (comboBox3.SelectedIndex == 3) //3 FillEllipse
            {
                g.FillEllipse(brush1,10,110,100,100);
            }
            if (comboBox1.SelectedIndex == 7) //7 DrawPie
            {
                g.DrawPie(pen, rect1,50,250);
            }
            if (comboBox3.SelectedIndex == 4) //4 FillPie
            {
                g.FillPie(brush1, rect1, 50, 250);
            }
            if (comboBox1.SelectedIndex == 1) //1 DrawCurve
            {
                g.DrawCurve(pen, p);
            }
            if (comboBox1.SelectedIndex == 2) //2 DrawClosedCurve
            {
                g.DrawClosedCurve(pen, p);
            }
            if (comboBox3.SelectedIndex == 0) //0 FillClosedCurve
            {
                g.FillClosedCurve(brush1, p1);
            }
            if (comboBox1.SelectedIndex == 6) //6 DrawArc
            {
                g.DrawArc(pen, rect1,50,250);
            }
            if (comboBox1.SelectedIndex == 0) //0 DrawBezier
            {
                g.DrawBezier(pen, p[0],p[1],p[2],p[3]);
            }
        }
    }
}
