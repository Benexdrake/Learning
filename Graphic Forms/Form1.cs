using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ts = new ThreadStart(delegate { Test(); });
            th = new Thread(ts);
            th.IsBackground = true;
            th.Start();
        }
        //------------------
        Thread th;
        ThreadStart ts;
        Graphics g;
        Graphics fG;
        Bitmap btm;
        Pen pen;
        PointF img;

        Rectangle r;
        Pointer pt;
        Pointer[] pts;

        int[] randomArray;

        int height = 0;
        int maxNumber;

        //------------------

        void Test()
        {
            
        }

        void Graphicss()
        {
            pt = new Pointer(10, 10, 10, 100);
            r = new Rectangle(0,0,50,50);
            pen = new Pen(Color.RebeccaPurple, 5.0f);
            img = new PointF(10, 10);
            btm = new Bitmap(1400, 600);
            g = Graphics.FromImage(btm);
            fG = CreateGraphics();
            maxNumber = randomArray.Length;
            height = maxNumber + 200;
        }

        public void Draw()
        {
            g.Clear(Color.Black);
            for (int i = 0; i < pts.Length; i++)
            {
                g.DrawLine(pen, pts[i].X1, pts[i].Y1, pts[i].X2, pts[i].Y2);
            }
            fG.DrawImage(btm, img);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            randomArray = Numbers.RandomNumbers(20);
            pts = new Pointer[randomArray.Length];
            pt = new Pointer(10, 10, 10, 120);
            comboBox1.Items.Clear();
            for (int i = 1; i <= pts.Length; i++)
            {
                pts[i - 1] = new Pointer(i * 10, height, i * 10, height - (randomArray[i - 1] *5));
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
            Graphicss();
            Draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (g != null)
            {
                pts[comboBox1.SelectedIndex].X1 += 10;
                pts[comboBox1.SelectedIndex].X2 += 10;
                //pt.X1 += 10;
                //pt.X2 += 10;
                Draw();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(g != null)
            {
                pts[comboBox1.SelectedIndex].X1 -= 10;
                pts[comboBox1.SelectedIndex].X2 -= 10;
                //pt.X1 -= 10;
                //pt.X2 -= 10;
                fG.DrawImage(btm, img);
                Draw();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = pts[comboBox1.SelectedIndex].X1;
            while (true)
            {
                pts[comboBox1.SelectedIndex].X1 += 10;
                pts[comboBox1.SelectedIndex].X2 += 10;
                fG.DrawImage(btm, img);
                Draw();
                if (pts[comboBox1.SelectedIndex].X1 >= x+100)
                {
                    break;
                }
            }
        }
    }
}