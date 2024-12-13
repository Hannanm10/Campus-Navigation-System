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
            GraphNode Gate3 = new GraphNode("Main Gate","Entry/Exit");
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
            GraphNode FacultyHostel = new GraphNode("Bachelor Faculty Hostel", "Hostel");
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

            Edge IqbalToBColony = new Edge(IqbalHall, BColony, panel83);
            Edge SirSyedToBColony = new Edge(SirSyedHall, BColony, panel83);
            Edge BColonyToSportsComplex = new Edge(BColony, SportsComplex, panel88);
            Edge SportsComplexToQuaid = new Edge(SportsComplex, QuaideAzamHall, panel82);
            Edge SportsComplexToQCanteen = new Edge(SportsComplex, QCanteen, panel82);
            Edge SportsComplexToLiaquatHall = new Edge(SportsComplex, LiaquatHall, panel82);
            Edge SportsComplexToMumtaz = new Edge(SportsComplex, MumtazHall, panel81);
            Edge SportsComplexToSecurity = new Edge(SportsComplex, SecurityOffice, panel58);
            Edge SecurityOfficeToJJ = new Edge(SecurityOffice, JJ, panel95);
            Edge SecurityOfficeToBhola = new Edge(SecurityOffice, BholaCafe, panel95);
            Edge SecurityOfficeToFtGround = new Edge(SecurityOffice, FootballGround, panel95);
            Edge JJToDataScience = new Edge(JJ, DataScience, panel60);
            Edge BholaToDataScience = new Edge(BholaCafe, DataScience, panel60);
            Edge FootballGToDataScience = new Edge(FootballGround, DataScience, panel60);
            Edge DataScienceToGate2 = new Edge(DataScience, ColonyGate2, panel62);
            Edge ColonyGate2ToColonyGate1 = new Edge(ColonyGate2, StaffColony, panel64);
            Edge ColonyGate2ToChem = new Edge(ColonyGate2, Chemical, panel75);
            Edge ColonyGate2ToGeology = new Edge(ColonyGate2, Geological, panel75);
            Edge DataScienceToMetallurgy = new Edge(DataScience, Metallurgical, panel59);
            Edge MetallurgyToCRP = new Edge(Metallurgical, CRP, panel85);
            Edge MetallurgyToPolymer = new Edge(Metallurgical, Polymer, panel84);
            Edge StaffColonyToMining = new Edge(StaffColony, Mining, panel66);
            Edge StaffColonyToPostOffice = new Edge(StaffColony, Postoffice, panel66);
            Edge PolymerToMining = new Edge(Polymer, Mining, panel104);
            Edge CRPToMasjid = new Edge(CRP, JamiaMosque, panel69);
            Edge MasjidToTransportOffice = new Edge(JamiaMosque, TransportOffice, panel55);
            Edge TransportOfficeToIBM = new Edge(TransportOffice, IBM, panel99);
            Edge TransportOfficeToSSC = new Edge(TransportOffice, SSC, panel99);
            Edge SecurityOfficeToShopping = new Edge(SecurityOffice, ShoppingCentre, panel57);
            Edge ShoppingToEdhiHall = new Edge(ShoppingCentre, EdhiHall, panel78);
            Edge ShoppingToZubairHall = new Edge(ShoppingCentre, ZubairHall, panel78);
            Edge ShoppingToMBQHall = new Edge(ShoppingCentre, MBQHall, panel78);
            Edge ShoppingToSSC = new Edge(ShoppingCentre, SSC, panel98);
            Edge SSCToAnnexeGround = new Edge(SSC, AnnexeGround, panel56);
            Edge IBMToAnnexeGround = new Edge(IBM, AnnexeGround, panel56);
            Edge SSCToTariqHall = new Edge(SSC, TariqHall, panel56);
            Edge IBMToTariqHall = new Edge(IBM, TariqHall, panel56);
            Edge TariqToKhalid = new Edge(TariqHall, KhalidHall, panel93);
            Edge AnnexeGroundToKhalid = new Edge(AnnexeGround, KhalidHall, panel93);
            Edge KhalidToAnnexe = new Edge(KhalidHall, Annexe, panel92);
            Edge KhalidToChemistry = new Edge(KhalidHall, Chemistry, panel92);
            Edge KhalidToWorkshop = new Edge(KhalidHall, Workshop, panel92);
            Edge AnnexeToAutomotive = new Edge(Annexe, Automotive, panel91);
            Edge ChemistryToAutomotive = new Edge(Chemistry, Automotive, panel91);
            Edge WorkShopToAutomotive = new Edge(Workshop, Automotive, panel90);
            Edge AutomotiveToAnnexeGround = new Edge(Automotive, AnnexeGround, panel90);
            Edge TransportOfficeToArchEngg = new Edge(TransportOffice, ArchEngg, panel79);
            Edge ArchEnggToAdminOffice = new Edge(ArchEngg, AdminOffice, panel54);
            Edge ArchEnggToHBL = new Edge(ArchEngg, HBL, panel54);
            Edge ArchEnggToIsl = new Edge(ArchEngg, IslamicStudies, panel76);
            Edge ArchEnggToLalazar = new Edge(ArchEngg, Lalazar, panel76);
            Edge IslToCRP = new Edge(IslamicStudies, CRP, panel77);
            Edge LalazarToCRP = new Edge(Lalazar, CRP, panel77);
            Edge IslToVCOffice = new Edge(IslamicStudies, VCOffice, panel53);
            Edge LalazarToVCOffice = new Edge(Lalazar, VCOffice, panel53);
            Edge PostOfficeToGSSC =  new Edge(Postoffice, GSSC, panel86);
            Edge MiningToGSSC = new Edge(Mining, GSSC, panel86);
            Edge CRPToArchitecture = new Edge(CRP, Architecture, panel105);
            Edge ArchitectureToLibrary = new Edge(Architecture, Library, panel106);
            Edge LibraryToLalazar = new Edge(Library, Lalazar, panel100);
            Edge LalazarToElectrical = new Edge(Lalazar, Electrical, panel102);
            Edge ElectricalToGate3 = new Edge(Electrical, Gate3, panel103);
            Edge PolymerToLibrary = new Edge(Polymer, Library, panel80);
            Edge LibraryToCivil = new Edge(Library, Civil, panel87);
            Edge LibraryToCS = new Edge(Library, CS, panel87);
            Edge LibraryToTransportation = new Edge(Library, Transportation, panel87);
            Edge CivilToGSSC = new Edge(Civil, GSSC, panel52);
            Edge CSToGSSC = new Edge(CS, GSSC, panel52);
            Edge TransportationToGSSC = new Edge(Transportation, GSSC, panel52);
            Edge GSSCToKICS = new Edge(GSSC, KICS, panel74);
            Edge GSSCToMath = new Edge(GSSC, Math, panel74);
            Edge GSSCToCE = new Edge(GSSC, ComputerEngg, panel74);
            Edge MathToMechatronics = new Edge(Math, Mechatronics, panel107);
            Edge KICSToMechatronics = new Edge(KICS, Mechatronics, panel107);
            Edge CEToMechatronics = new Edge(ComputerEngg, Mechatronics, panel107);
            Edge MathToMechanical = new Edge(Math, Mechanical, panel107);
            Edge KICSToMechanical = new Edge(KICS, Mechanical, panel107);
            Edge CEToMechanical = new Edge(ComputerEngg, Mechanical, panel107);
            Edge GSSCToAuditorium = new Edge(GSSC, Auditorium, panel73);
            Edge AudiToPhysics = new Edge(Auditorium, Physics, panel71);
            Edge PhysicsToGate5 = new Edge(Physics, Gate5, panel68);
            Edge AuditoriumToKhadijaHall = new Edge(Auditorium, Khadija, panel101);
            Edge KhadijaHallToPowerHouse = new Edge(Khadija, PowerHouse, panel72);
            Edge KhadijaHallToFacultyHostel = new Edge(Khadija, FacultyHostel, panel70);
            Edge KhadijaHallToGirlsGround = new Edge(Khadija, GirlsGround, panel70);
            Edge FacultyHostelToNewGirlsHall = new Edge(FacultyHostel, NewGirls, panel67);
            Edge GirlsGroundToNewGirlsHAll = new Edge(GirlsGround, NewGirls, panel67);


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
