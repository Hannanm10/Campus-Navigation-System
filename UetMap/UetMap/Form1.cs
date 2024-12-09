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

        private void LoadNodes()
        {
            GraphNode Gate = new GraphNode("Main Gate","Entry/Exit");
            GraphNode Electrical = new GraphNode("Electrical Engg.", "Department");
            GraphNode Library = new GraphNode("Library", "Library");
            GraphNode CS = new GraphNode("Computer Science", "Department");
            GraphNode Civil = new GraphNode("Civil Engg.", "Department");
            GraphNode Transportation = new GraphNode("Transport Engg.", "Department");
            GraphNode GSSC = new GraphNode("GSSC", "Cafe");
            GraphNode ComputerEngg = new GraphNode("Computer Engg.", "Department");
            GraphNode Math = new GraphNode("Mathematics", "Department");
            GraphNode KICS = new GraphNode("KICS", "Institute");
            GraphNode Mechanical = new GraphNode("Mechanical Engg.", "Department");
            GraphNode Mechatronics = new GraphNode("Mechatronics Dept.", "Department");
            GraphNode Auditorium = new GraphNode("UET Auditorium","Department");
            GraphNode Physics = new GraphNode("Physics Dept.", "Department");
            GraphNode Gate5 = new GraphNode("Gate 5", "Gate");
            GraphNode Khadija = new GraphNode("Khadija Hall", "Hostel");
            GraphNode PowerHouse = new GraphNode("Power House", "Power generation");
            GraphNode Faculty = new GraphNode("Bachelor Faculty Hostel", "Hostel");
            GraphNode GirlsGround = new GraphNode("Girls Playground", "Sports");
            GraphNode NewGirls = new GraphNode("New Girls Hostel", "Hostel");
            GraphNode Mining = new GraphNode("Mining Engg.", "Department");
            GraphNode Postoffice = new GraphNode("Post Office", "Office");
            GraphNode StaffColony = new GraphNode("Staff Colony", "Colony");
            GraphNode Chemical = new GraphNode("Chemical Engg.", "Department");
            GraphNode Geological = new GraphNode("Geological Engg.", "Department");
            GraphNode Metallurgical = new GraphNode("Metallurgical Engg.", "Department");
            GraphNode DataScience = new GraphNode("Data Science Institute", "Department");
            GraphNode JJ = new GraphNode("JJ Stadium", "Sports");
            GraphNode FootballGround = new GraphNode("Football Ground", "Sports");
            GraphNode BholaCafe = new GraphNode("Bhola Cafe", "Cafe");
            GraphNode SecurityOffice = new GraphNode("Security Office", "Office");
            GraphNode SportsComplex = new GraphNode("Sports Complex", "Sports");
            GraphNode BColony = new GraphNode("B Colony", "Colony");
            GraphNode MumtazHall = new GraphNode("Mumtaz Hall", "Hostel");
            GraphNode QuaideAzamHall = new GraphNode("Quaid-e-Azam Hall", "Hostel");
            GraphNode LiaquatHall = new GraphNode("Liaquat Hall", "Hostel");
            GraphNode QCanteen = new GraphNode("Q Canteen", "Cafe");
            GraphNode IqbalHall = new GraphNode("Iqbal Hall", "Hostel");
            GraphNode SirSyedHall = new GraphNode("Sir Syed Hall", "Hostel");
            GraphNode ShoppingCentre = new GraphNode("Shopping Centre", "Shopping");
            GraphNode ZubairHall = new GraphNode("Zubair Hall", "Hostel");
            GraphNode MBQHall = new GraphNode("MBQ Hall", "Hostel");
            GraphNode EdhiHall = new GraphNode("Edhi Hall", "Hostel");
            GraphNode SSC = new GraphNode("SSC", "Cafe");
            GraphNode TariqHall = new GraphNode("Tariq Hall", "Hostel");
            GraphNode KhalidHall = new GraphNode("Khalid Hall", "Hostel");
            GraphNode AnnexeGround = new GraphNode("Annexe Ground", "Ground");
            GraphNode Automotive = new GraphNode("Automotive Engg.", "Department");
            GraphNode Workshop = new GraphNode("Mechanical Workshop", "Workshop");
            GraphNode Annexe = new GraphNode("Annexe", "Cafe");
            GraphNode Chemistry = new GraphNode("Chemistry", "Department");
            GraphNode IBM = new GraphNode("IBM", "Department");
            GraphNode JamiaMosque = new GraphNode("Jamia Mosque", "Mosque");
            GraphNode TransportOffice = new GraphNode("Transport Office", "Office");
            GraphNode ArchEngg = new GraphNode("Architecture Engg.", "Department");
            GraphNode IslamicStudies = new GraphNode("Islamic Studies", "Department");
            GraphNode AdminOffice = new GraphNode("Admin Office", "Office");
            GraphNode HBL = new GraphNode("HBL", "Bank");
            GraphNode VCOffice = new GraphNode("VC Office", "Office");
            GraphNode Lalazar = new GraphNode("Lalazar", "Park");
            GraphNode CRP = new GraphNode("CRP", "Department");
            GraphNode Architecture = new GraphNode("Architecture", "Department");
            GraphNode Polymer = new GraphNode("Polymer Engg.", "Department");
            GraphNode ColonyGate2 = new GraphNode("Colony Gate 2", "Gate");
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

        private void panel51_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
