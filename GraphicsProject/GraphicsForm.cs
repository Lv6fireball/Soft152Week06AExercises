using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Diagnostics;


namespace GraphicsProject
{
    public partial class GraphicsForm : Form
    {
        private int numberToDraw;

        public GraphicsForm()
        {
            InitializeComponent();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawLines();

        } // end Paint()


        private void DrawLines()
        {
            int distanceBetweenLines = 20;
            Point lineStartPoint = new Point(0, 0);
            Point lineEndPoint = new Point(0, 0);
            if (verRadioBut.Checked)
            {
                lineStartPoint = new Point(10, 20);

                lineEndPoint = new Point(10, 100);
            }

            using (Graphics panelGraphics = DrawingPanel.CreateGraphics())
            using (Pen linePen = new Pen(Color.Red))
            {
                for (int i = 0; i < numberToDraw; i++)
                {
                    panelGraphics.DrawLine(linePen, lineStartPoint, lineEndPoint);

                    lineStartPoint.X = lineStartPoint.X + distanceBetweenLines;
                    lineEndPoint.X = lineEndPoint.X + distanceBetweenLines;
                }
            } // end using

            if (horRadioBut.Checked)
            {
                lineStartPoint = new Point(10, 20);

                lineEndPoint = new Point(100, 20);
            }
            using (Graphics panelGraphics = DrawingPanel.CreateGraphics())
            using (Pen linePen = new Pen(Color.Red))
            {
                for (int i = 0; i < numberToDraw; i++)
                {
                    panelGraphics.DrawLine(linePen, lineStartPoint, lineEndPoint);

                    lineStartPoint.Y = lineStartPoint.Y + distanceBetweenLines;
                    lineEndPoint.Y = lineEndPoint.Y + distanceBetweenLines;
                }
            } // end using

        }

        private void drawLinesButton_Click(object sender, EventArgs e)
        {
            numberToDraw = Convert.ToInt32(numberLinesTextBox.Text);

            DrawLines();
        }

    }

}
