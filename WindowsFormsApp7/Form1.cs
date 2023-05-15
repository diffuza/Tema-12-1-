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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Silver);
           
            g.DrawLine(Pens.Black, 20, 30, 200, 30);


            
            Brush blueBrush = new SolidBrush(Color.Blue);


            Color cl = Color.FromArgb(255, 255, 255); g.Clear(cl);
            Pen Pen2= new Pen(Color.Black, 4);
            g.DrawLine(Pen2, 20, 20, 200, 20);
            Pen Pen4 = new Pen(Color.Black, 4);
            Pen4.DashStyle = DashStyle.DashDot; // стиль точка-тире
            g.DrawLine(Pen4, 20, 30, 200, 30);
            Pen Pen1 = new Pen(Color.Blue, 4);
            // линия с ромбом на конце
            Pen1.Width = 7;
            Pen1.EndCap = LineCap.DiamondAnchor; g.DrawLine(Pen1, 20, 40, 200, 40);
                       

        }
        Graphics g;

        
    }

}
