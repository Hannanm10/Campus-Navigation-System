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
            currentRoadColor = Color.Gray;

            // Register the Paint event
            this.Paint += Form1_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;

            // Add a button to change the road color
            Button changeColorButton = new Button
            {
                Text = "Change Road Color",
                Location = new Point(10, 10),
                AutoSize = true
            };

            changeColorButton.Click += ChangeColorButton_Click;
            this.Controls.Add(changeColorButton);
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
            Pen roadPen = new Pen(currentRoadColor, 10);
            roadPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            roadPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Straight road
            g.DrawLine(roadPen, 50, 50, 200, 50);

            // Curved road
            Point[] curvePoints = { new Point(200, 50), new Point(250, 100), new Point(300, 50) };
            g.DrawCurve(roadPen, curvePoints);

            roadPen.Dispose();
        }
    }
}
