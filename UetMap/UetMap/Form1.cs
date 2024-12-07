using System;
using System.Drawing;
using System.Windows.Forms;

namespace UetMap
{
    public partial class Form1 : Form
    {
        // Variable to hold the current road color
        private Color currentRoadColor;

        public Form1()
        {
            InitializeComponent();

            // Set default road color
            //currentRoadColor = Color.Blue;

            // Register the Paint event
            //panel1.Paint += Form1_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            // Add a button to change the road color
            Button changeColorButton = new Button
            {
                Text = "Change Road Color",
                Location = new Point(10, 10),
                AutoSize = true
            };

            changeColorButton.Click += ChangeColorButton_Click;
            // this.Controls.Add(changeColorButton);
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            // Change the road color at runtime
            if (currentRoadColor == Color.Gray)
                currentRoadColor = Color.Blue; // Change to Blue
            else
                currentRoadColor = Color.Gray; // Change back to Gray

            // Trigger a repaint
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Pen for road with the current color
            Pen roadPen = new Pen(currentRoadColor, 3
                );
            roadPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            roadPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Straight road
            g.DrawLine(roadPen, 410, 425, 410, 300);

            // Curved road
            Point[] curvePoints = { new Point(510, 400), new Point(502, 388) };
            g.DrawCurve(roadPen, curvePoints);

            roadPen.Dispose();
          

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
