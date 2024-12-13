using System;
using System.Drawing;
using System.Windows.Forms;

namespace UetMap
{
    public partial class Form1 : Form
    {
        // Variable to hold the current road color
        private Color currentRoadColor;

        private Graph Map;

        public Form1()
        {
            InitializeComponent(); 
            Map = new Graph();
            comboBox1.DataSource = Enum.GetValues(typeof(Locations));
            comboBox1.SelectedIndex = -1;
            comboBox2.DataSource = Enum.GetValues(typeof(Locations));
            comboBox2.SelectedIndex = -1;

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
            Pen roadPen = new Pen(currentRoadColor, 3);
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
            // Create and add all GraphNodes to the Map object
            GraphNode Gate3 = new GraphNode("Main Gate", "Entry/Exit");
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
            GraphNode Auditorium = new GraphNode("UET Auditorium", "Department");
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

            // Add nodes to the Map
            Map.AddNode(Gate3);
            Map.AddNode(Electrical);
            Map.AddNode(Library);
            Map.AddNode(CS);
            Map.AddNode(Civil);
            Map.AddNode(Transportation);
            Map.AddNode(GSSC);
            Map.AddNode(ComputerEngg);
            Map.AddNode(Math);
            Map.AddNode(KICS);
            Map.AddNode(Mechanical);
            Map.AddNode(Mechatronics);
            Map.AddNode(Auditorium);
            Map.AddNode(Physics);
            Map.AddNode(Gate5);
            Map.AddNode(Khadija);
            Map.AddNode(PowerHouse);
            Map.AddNode(FacultyHostel);
            Map.AddNode(GirlsGround);
            Map.AddNode(NewGirls);
            Map.AddNode(Mining);
            Map.AddNode(Postoffice);
            Map.AddNode(StaffColony);
            Map.AddNode(Chemical);
            Map.AddNode(Geological);
            Map.AddNode(Metallurgical);
            Map.AddNode(DataScience);
            Map.AddNode(JJ);
            Map.AddNode(FootballGround);
            Map.AddNode(BholaCafe);
            Map.AddNode(SecurityOffice);
            Map.AddNode(SportsComplex);
            Map.AddNode(BColony);
            Map.AddNode(MumtazHall);
            Map.AddNode(QuaideAzamHall);
            Map.AddNode(LiaquatHall);
            Map.AddNode(QCanteen);
            Map.AddNode(IqbalHall);
            Map.AddNode(SirSyedHall);
            Map.AddNode(ShoppingCentre);
            Map.AddNode(ZubairHall);
            Map.AddNode(MBQHall);
            Map.AddNode(EdhiHall);
            Map.AddNode(SSC);
            Map.AddNode(TariqHall);
            Map.AddNode(KhalidHall);
            Map.AddNode(AnnexeGround);
            Map.AddNode(Automotive);
            Map.AddNode(Workshop);
            Map.AddNode(Annexe);
            Map.AddNode(Chemistry);
            Map.AddNode(IBM);
            Map.AddNode(JamiaMosque);
            Map.AddNode(TransportOffice);
            Map.AddNode(ArchEngg);
            Map.AddNode(IslamicStudies);
            Map.AddNode(AdminOffice);
            Map.AddNode(HBL);
            Map.AddNode(VCOffice);
            Map.AddNode(Lalazar);
            Map.AddNode(CRP);
            Map.AddNode(Architecture);
            Map.AddNode(Polymer);
            Map.AddNode(ColonyGate2);


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
            Edge PolymerToPostOffice = new Edge(Polymer, Postoffice, panel104);
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
            Edge PostOfficeToGSSC = new Edge(Postoffice, GSSC, panel86);
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

            Map.AddEdge(IqbalToBColony, 64);
            Map.AddEdge(SirSyedToBColony, 170);
            Map.AddEdge(BColonyToSportsComplex, 200);
            Map.AddEdge(SportsComplexToQuaid, 250);
            Map.AddEdge(SportsComplexToQCanteen, 250);
            Map.AddEdge(SportsComplexToLiaquatHall, 140);
            Map.AddEdge(SportsComplexToMumtaz, 210);
            Map.AddEdge(SportsComplexToSecurity, 190);
            Map.AddEdge(SecurityOfficeToJJ, 160);
            Map.AddEdge(SecurityOfficeToBhola, 83);
            Map.AddEdge(SecurityOfficeToFtGround, 54);
            Map.AddEdge(JJToDataScience, 61);
            Map.AddEdge(BholaToDataScience, 120);
            Map.AddEdge(FootballGToDataScience, 150);
            Map.AddEdge(DataScienceToGate2, 120);
            Map.AddEdge(ColonyGate2ToColonyGate1, 84);
            Map.AddEdge(ColonyGate2ToChem, 57);
            Map.AddEdge(ColonyGate2ToGeology, 57);
            Map.AddEdge(DataScienceToMetallurgy, 130);
            Map.AddEdge(MetallurgyToCRP, 110);
            Map.AddEdge(MetallurgyToPolymer, 76);
            Map.AddEdge(StaffColonyToMining, 100);
            Map.AddEdge(StaffColonyToPostOffice, 110);
            Map.AddEdge(PolymerToMining, 130);
            Map.AddEdge(PolymerToPostOffice, 130);
            Map.AddEdge(CRPToMasjid, 72);
            Map.AddEdge(MasjidToTransportOffice, 61);
            Map.AddEdge(TransportOfficeToIBM, 44);
            Map.AddEdge(TransportOfficeToSSC, 44);
            Map.AddEdge(SecurityOfficeToShopping, 100);
            Map.AddEdge(ShoppingToEdhiHall, 180);
            Map.AddEdge(ShoppingToZubairHall, 130);
            Map.AddEdge(ShoppingToMBQHall, 140);
            Map.AddEdge(ShoppingToSSC, 120);
            Map.AddEdge(SSCToAnnexeGround, 31);
            Map.AddEdge(IBMToAnnexeGround, 31);
            Map.AddEdge(SSCToTariqHall, 31);
            Map.AddEdge(IBMToTariqHall, 31);
            Map.AddEdge(TariqToKhalid, 140);
            Map.AddEdge(AnnexeGroundToKhalid, 140);
            Map.AddEdge(KhalidToAnnexe, 120);
            Map.AddEdge(KhalidToChemistry, 120);
            Map.AddEdge(KhalidToWorkshop, 140);
            Map.AddEdge(AnnexeToAutomotive, 160);
            Map.AddEdge(ChemistryToAutomotive, 160);
            Map.AddEdge(WorkShopToAutomotive, 160);
            Map.AddEdge(AutomotiveToAnnexeGround, 140);
            Map.AddEdge(TransportOfficeToArchEngg, 97);
            Map.AddEdge(ArchEnggToAdminOffice, 210);
            Map.AddEdge(ArchEnggToHBL, 210);
            Map.AddEdge(ArchEnggToIsl, 120);
            Map.AddEdge(ArchEnggToLalazar, 120);
            Map.AddEdge(IslToCRP, 130);
            Map.AddEdge(LalazarToCRP, 130);
            Map.AddEdge(IslToVCOffice, 98);
            Map.AddEdge(LalazarToVCOffice, 98);
            Map.AddEdge(PostOfficeToGSSC, 140);
            Map.AddEdge(MiningToGSSC, 140);
            Map.AddEdge(CRPToArchitecture, 53);
            Map.AddEdge(ArchitectureToLibrary, 45);
            Map.AddEdge(LibraryToLalazar, 30);
            Map.AddEdge(LalazarToElectrical, 50);
            Map.AddEdge(ElectricalToGate3, 30);
            Map.AddEdge(PolymerToLibrary, 110);
            Map.AddEdge(LibraryToCivil, 150);
            Map.AddEdge(LibraryToCS, 150);
            Map.AddEdge(LibraryToTransportation, 150);
            Map.AddEdge(CivilToGSSC, 68);
            Map.AddEdge(CSToGSSC, 68);
            Map.AddEdge(TransportationToGSSC, 68);
            Map.AddEdge(GSSCToKICS, 96);
            Map.AddEdge(GSSCToMath, 96);
            Map.AddEdge(GSSCToCE, 96);
            Map.AddEdge(MathToMechatronics, 40);
            Map.AddEdge(KICSToMechatronics, 40);
            Map.AddEdge(CEToMechatronics, 40);
            Map.AddEdge(MathToMechanical, 40);
            Map.AddEdge(KICSToMechanical, 40);
            Map.AddEdge(CEToMechanical, 40);
            Map.AddEdge(GSSCToAuditorium, 150);
            Map.AddEdge(AudiToPhysics, 250);
            Map.AddEdge(PhysicsToGate5, 84);
            Map.AddEdge(AuditoriumToKhadijaHall, 71);
            Map.AddEdge(KhadijaHallToPowerHouse, 92);
            Map.AddEdge(KhadijaHallToFacultyHostel, 74);
            Map.AddEdge(KhadijaHallToGirlsGround, 74);
            Map.AddEdge(FacultyHostelToNewGirlsHall, 69);
            Map.AddEdge(GirlsGroundToNewGirlsHAll, 69);

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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
