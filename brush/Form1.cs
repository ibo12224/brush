using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace brush {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Click(object sender, System.EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black);
            Point startPoint = new Point(45, 45);
            Point endPoint = new Point(180, 150);
            g.DrawLine(p, startPoint, endPoint);
            g.DrawLine(p, new Point(190, 60), new Point(65, 170));
            p.Dispose();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
