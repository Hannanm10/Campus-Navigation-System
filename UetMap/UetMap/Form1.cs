using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UetMap
{
    public partial class Form1 : Form
    {
        // Variable to hold the current road color
        private Color currentRoadColor;
        private List<Panel> currentColored;
        private Graph Map;

        public Form1()
        {
            InitializeComponent(); 
            Map = new Graph();
            comboBox1.DataSource = Enum.GetValues(typeof(Locations));
            comboBox1.SelectedIndex = -1;
            comboBox2.DataSource = Enum.GetValues(typeof(Locations));
            comboBox2.SelectedIndex = -1;
            currentColored = new List<Panel>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            LoadNodes();
        }

        private void LoadNodes()
        {
            // Create and add all GraphNodes to the Map object
            GraphNode Gate3 = new GraphNode("Gate3", "Entry/Exit");
            GraphNode ElectricalDepartment = new GraphNode("ElectricalDepartment", "Department");
            GraphNode Library = new GraphNode("Library", "Library");
            GraphNode ComputerScience = new GraphNode("ComputerScience", "Department");
            GraphNode CivilDepartment = new GraphNode("CivilDepartment", "Department");
            GraphNode TransportationDepartment = new GraphNode("TransportationDepartment", "Department");
            GraphNode GSSC = new GraphNode("GSSC", "Cafe");
            GraphNode ComputerEngineering = new GraphNode("ComputerEngineering", "Department");
            GraphNode MathematicsDepartment = new GraphNode("MathematicsDepartment", "Department");
            GraphNode KICS = new GraphNode("KICS", "Institute");
            GraphNode MechanicalDepartment = new GraphNode("MechanicalDepartment", "Department");
            GraphNode MechatronicsDepartment = new GraphNode("MechatronicsDepartment", "Department");
            GraphNode Auditorium = new GraphNode("Auditorium", "Department");
            GraphNode PhysicsDepartment = new GraphNode("PhysicsDepartment", "Department");
            GraphNode Gate5 = new GraphNode("Gate5", "Gate");
            GraphNode KhadijaHall = new GraphNode("KhadijaHall", "Hostel");
            GraphNode PowerHouse = new GraphNode("PowerHouse", "Power generation");
            GraphNode FacultyHostel = new GraphNode("FacultyHostel", "Hostel");
            GraphNode GirlsGround = new GraphNode("GirlsGround", "Sports");
            GraphNode NewGirlsHostel = new GraphNode("NewGirlsHostel", "Hostel");
            GraphNode MiningDepartment = new GraphNode("MiningDepartment", "Department");
            GraphNode Postoffice = new GraphNode("PostOffice", "Office");
            GraphNode StaffColony = new GraphNode("StaffColony", "Colony");
            GraphNode ChemicalDepartment = new GraphNode("ChemicalDepartment", "Department");
            GraphNode GeologicalDepartment = new GraphNode("GeologicalDepartment", "Department");
            GraphNode MetallurgicalDepartment = new GraphNode("MetallurgicalDepartment", "Department");
            GraphNode InstituteofDataScience = new GraphNode("InstituteofDataScience", "Department");
            GraphNode JJCricketGround = new GraphNode("JJCricketGround", "Sports");
            GraphNode FootballGround = new GraphNode("FootballGround", "Sports");
            GraphNode BholaCafe = new GraphNode("BholaCafe", "Cafe");
            GraphNode SecurityOffice = new GraphNode("SecurityOffice", "Office");
            GraphNode SportsComplex = new GraphNode("SportsComplex", "Sports");
            GraphNode BColony = new GraphNode("BColony", "Colony");
            GraphNode MumtazHall = new GraphNode("MumtazHall", "Hostel");
            GraphNode QuaideAzamHall = new GraphNode("QuaideAzamHall", "Hostel");
            GraphNode LiaquatHall = new GraphNode("LiaquatHall", "Hostel");
            GraphNode QCanteen = new GraphNode("QCanteen", "Cafe");
            GraphNode IqbalHall = new GraphNode("IqbalHall", "Hostel");
            GraphNode SirSyedHall = new GraphNode("SirSyedHall", "Hostel");
            GraphNode ShoppingCentre = new GraphNode("ShoppingCentre", "Shopping");
            GraphNode ZubairHall = new GraphNode("ZubairHall", "Hostel");
            GraphNode MBQHall = new GraphNode("MBQHall", "Hostel");
            GraphNode EdhiHall = new GraphNode("EdhiHall", "Hostel");
            GraphNode SSC = new GraphNode("SSC", "Cafe");
            GraphNode TariqHall = new GraphNode("TariqHall", "Hostel");
            GraphNode KhalidHall = new GraphNode("KhalidHall", "Hostel");
            GraphNode AnnexeGround = new GraphNode("AnnexeGround", "Ground");
            GraphNode AutomotiveDepartment = new GraphNode("AutomotiveDepartment", "Department");
            GraphNode Workshop = new GraphNode("Workshop", "Workshop");
            GraphNode Annexe = new GraphNode("Annexe", "Cafe");
            GraphNode ChemistryDepartment = new GraphNode("ChemistryDepartment", "Department");
            GraphNode IBM = new GraphNode("IBM", "Department");
            GraphNode JamiaMosque = new GraphNode("JamiaMosque", "Mosque");
            GraphNode TransportOffice = new GraphNode("TransportOffice", "Office");
            GraphNode ArchitectureEngineering = new GraphNode("ArchitectureEngineering", "Department");
            GraphNode IslamicStudies = new GraphNode("IslamicStudies", "Department");
            GraphNode AdminOffice = new GraphNode("AdminOffice", "Office");
            GraphNode HBL = new GraphNode("HBL", "Bank");
            GraphNode VCOffice = new GraphNode("VCOffice", "Office");
            GraphNode Lalazar = new GraphNode("Lalazar", "Park");
            GraphNode CRP = new GraphNode("CRP", "Department");
            GraphNode ArchitectureAndDesign = new GraphNode("ArchitectureAndDesign", "Department");
            GraphNode PolymerDepartment = new GraphNode("PolymerDepartment", "Department");
            GraphNode ColonyGate2 = new GraphNode("Colony Gate 2", "Gate");

            // Add nodes to the Map
            Map.AddNode(Gate3);
            Map.AddNode(ElectricalDepartment);
            Map.AddNode(Library);
            Map.AddNode(ComputerScience);
            Map.AddNode(CivilDepartment);
            Map.AddNode(TransportationDepartment);
            Map.AddNode(GSSC);
            Map.AddNode(ComputerEngineering);
            Map.AddNode(MathematicsDepartment);
            Map.AddNode(KICS);
            Map.AddNode(MechanicalDepartment);
            Map.AddNode(MechatronicsDepartment);
            Map.AddNode(Auditorium);
            Map.AddNode(PhysicsDepartment);
            Map.AddNode(Gate5);
            Map.AddNode(KhadijaHall);
            Map.AddNode(PowerHouse);
            Map.AddNode(FacultyHostel);
            Map.AddNode(GirlsGround);
            Map.AddNode(NewGirlsHostel);
            Map.AddNode(MiningDepartment);
            Map.AddNode(Postoffice);
            Map.AddNode(StaffColony);
            Map.AddNode(ChemicalDepartment);
            Map.AddNode(GeologicalDepartment);
            Map.AddNode(MetallurgicalDepartment);
            Map.AddNode(InstituteofDataScience);
            Map.AddNode(JJCricketGround);
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
            Map.AddNode(AutomotiveDepartment);
            Map.AddNode(Workshop);
            Map.AddNode(Annexe);
            Map.AddNode(ChemistryDepartment);
            Map.AddNode(IBM);
            Map.AddNode(JamiaMosque);
            Map.AddNode(TransportOffice);
            Map.AddNode(ArchitectureEngineering);
            Map.AddNode(IslamicStudies);
            Map.AddNode(AdminOffice);
            Map.AddNode(HBL);
            Map.AddNode(VCOffice);
            Map.AddNode(Lalazar);
            Map.AddNode(CRP);
            Map.AddNode(ArchitectureAndDesign);
            Map.AddNode(PolymerDepartment);
            Map.AddNode(ColonyGate2);


            Edge IqbalToBColony = new Edge(IqbalHall, BColony, panel83);
            Edge SirSyedToBColony = new Edge(SirSyedHall, BColony, panel83);
            Edge BColonyToSportsComplex = new Edge(BColony, SportsComplex, panel88);
            Edge SportsComplexToQuaid = new Edge(SportsComplex, QuaideAzamHall, panel82);
            Edge SportsComplexToQCanteen = new Edge(SportsComplex, QCanteen, panel82);
            Edge SportsComplexToLiaquatHall = new Edge(SportsComplex, LiaquatHall, panel82);
            Edge SportsComplexToMumtaz = new Edge(SportsComplex, MumtazHall, panel81);
            Edge SportsComplexToSecurity = new Edge(SportsComplex, SecurityOffice, panel58);
            Edge SecurityOfficeToJJ = new Edge(SecurityOffice, JJCricketGround, panel95);
            Edge SecurityOfficeToBhola = new Edge(SecurityOffice, BholaCafe, panel95);
            Edge SecurityOfficeToFtGround = new Edge(SecurityOffice, FootballGround, panel95);
            Edge JJToDataScience = new Edge(JJCricketGround, InstituteofDataScience, panel60);
            Edge BholaToDataScience = new Edge(BholaCafe, InstituteofDataScience, panel60);
            Edge FootballGToDataScience = new Edge(FootballGround, InstituteofDataScience, panel60);
            Edge DataScienceToGate2 = new Edge(InstituteofDataScience, ColonyGate2, panel62);
            Edge ColonyGate2ToColonyGate1 = new Edge(ColonyGate2, StaffColony, panel64);
            Edge ColonyGate2ToChem = new Edge(ColonyGate2, ChemicalDepartment, panel75);
            Edge ColonyGate2ToGeology = new Edge(ColonyGate2, GeologicalDepartment, panel75);
            Edge DataScienceToMetallurgy = new Edge(InstituteofDataScience, MetallurgicalDepartment, panel59);
            Edge MetallurgyToCRP = new Edge(MetallurgicalDepartment, CRP, panel85);
            Edge MetallurgyToPolymer = new Edge(MetallurgicalDepartment, PolymerDepartment, panel84);
            Edge StaffColonyToMining = new Edge(StaffColony, MiningDepartment, panel66);
            Edge StaffColonyToPostOffice = new Edge(StaffColony, Postoffice, panel66);
            Edge PolymerToMining = new Edge(PolymerDepartment, MiningDepartment, panel104);
            Edge PolymerToPostOffice = new Edge(PolymerDepartment, Postoffice, panel104);
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
            Edge KhalidToChemistry = new Edge(KhalidHall, ChemistryDepartment, panel92);
            Edge KhalidToWorkshop = new Edge(KhalidHall, Workshop, panel92);
            Edge AnnexeToAutomotive = new Edge(Annexe, AutomotiveDepartment, panel91);
            Edge ChemistryToAutomotive = new Edge(ChemistryDepartment, AutomotiveDepartment, panel91);
            Edge WorkShopToAutomotive = new Edge(Workshop, AutomotiveDepartment, panel90);
            Edge AutomotiveToAnnexeGround = new Edge(AutomotiveDepartment, AnnexeGround, panel90);
            Edge TransportOfficeToArchEngg = new Edge(TransportOffice, ArchitectureEngineering, panel79);
            Edge ArchEnggToAdminOffice = new Edge(ArchitectureEngineering, AdminOffice, panel54);
            Edge ArchEnggToHBL = new Edge(ArchitectureEngineering, HBL, panel54);
            Edge ArchEnggToIsl = new Edge(ArchitectureEngineering, IslamicStudies, panel76);
            //Edge ArchEnggToLalazar = new Edge(ArchEngg, Lalazar, panel76);
            Edge IslToCRP = new Edge(IslamicStudies, CRP, panel77);
            //Edge LalazarToCRP = new Edge(Lalazar, CRP, panel77);
            Edge IslToVCOffice = new Edge(IslamicStudies, VCOffice, panel53);
            //Edge LalazarToVCOffice = new Edge(Lalazar, VCOffice, panel53);
            Edge PostOfficeToGSSC = new Edge(Postoffice, GSSC, panel86);
            Edge MiningToGSSC = new Edge(MiningDepartment, GSSC, panel86);
            Edge CRPToArchitecture = new Edge(CRP, ArchitectureAndDesign, panel105);
            Edge ArchitectureToLibrary = new Edge(ArchitectureAndDesign, Library, panel106);
            Edge LibraryToLalazar = new Edge(Library, Lalazar, panel100);
            Edge LalazarToElectrical = new Edge(Lalazar, ElectricalDepartment, panel102);
            Edge ElectricalToGate3 = new Edge(ElectricalDepartment, Gate3, panel103);
            Edge PolymerToLibrary = new Edge(PolymerDepartment, Library, panel80);
            Edge LibraryToCivil = new Edge(Library, CivilDepartment, panel87);
            Edge LibraryToCS = new Edge(Library, ComputerScience, panel87);
            Edge LibraryToTransportation = new Edge(Library, TransportationDepartment, panel87);
            Edge CivilToGSSC = new Edge(CivilDepartment, GSSC, panel52);
            Edge CSToGSSC = new Edge(ComputerScience, GSSC, panel52);
            Edge TransportationToGSSC = new Edge(TransportationDepartment, GSSC, panel52);
            Edge GSSCToKICS = new Edge(GSSC, KICS, panel74);
            Edge GSSCToMath = new Edge(GSSC, MathematicsDepartment, panel74);
            Edge GSSCToCE = new Edge(GSSC, ComputerEngineering, panel74);
            Edge MathToMechatronics = new Edge(MathematicsDepartment, MechatronicsDepartment, panel107);
            Edge KICSToMechatronics = new Edge(KICS, MechatronicsDepartment, panel107);
            Edge CEToMechatronics = new Edge(ComputerEngineering, MechatronicsDepartment, panel107);
            Edge MathToMechanical = new Edge(MathematicsDepartment, MechanicalDepartment, panel107);
            Edge KICSToMechanical = new Edge(KICS, MechanicalDepartment, panel107);
            Edge CEToMechanical = new Edge(ComputerEngineering, MechanicalDepartment, panel107);
            Edge GSSCToAuditorium = new Edge(GSSC, Auditorium, panel73);
            Edge AudiToPhysics = new Edge(Auditorium, PhysicsDepartment, panel71);
            Edge PhysicsToGate5 = new Edge(PhysicsDepartment, Gate5, panel68);
            Edge AuditoriumToKhadijaHall = new Edge(Auditorium, KhadijaHall, panel101);
            Edge KhadijaHallToPowerHouse = new Edge(KhadijaHall, PowerHouse, panel72);
            Edge KhadijaHallToFacultyHostel = new Edge(KhadijaHall, FacultyHostel, panel70);
            Edge KhadijaHallToGirlsGround = new Edge(KhadijaHall, GirlsGround, panel70);
            Edge FacultyHostelToNewGirlsHall = new Edge(FacultyHostel, NewGirlsHostel, panel67);
            Edge GirlsGroundToNewGirlsHAll = new Edge(GirlsGround, NewGirlsHostel, panel67);

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
            //Map.AddEdge(ArchEnggToLalazar, 120);
            Map.AddEdge(IslToCRP, 130);
            //Map.AddEdge(LalazarToCRP, 130);
            Map.AddEdge(IslToVCOffice, 98);
            //Map.AddEdge(LalazarToVCOffice, 98);
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


        private void ProcessPathEdges(UetMap.List<GraphNode> path)
        {
            currentColored.Clear(); 
            float distance=0;
            // Check if the path is valid
            if (path == null || path.Count() < 2)
            {
                //Console.WriteLine("The path is invalid or too short to process.");
                return;
            }

            // Use enumerator to iterate through the list
            using (var enumerator = path.GetEnumerator())
            {
                if (!enumerator.MoveNext()) return; // Move to the first node
                var node1 = enumerator.Current;

                while (enumerator.MoveNext())
                {
                    var node2 = enumerator.Current;

                    // Find the edge between these two nodes
                    var edge = Map.FindEdge(node1, node2);

                    if (edge != null)
                    {
                        //Console.WriteLine($"Edge found between {node1.Name} and {node2.Name}, Distance: {edge.Distance}");
                        edge.RoadPanel.BackColor = Color.LightGreen;
                        distance += edge.Distance;
                        currentColored.Add(edge.RoadPanel);
                    }
                    else
                    {
                        //Console.WriteLine($"No edge found between {node1.Name} and {node2.Name}");
                    }

                    // Move to the next pair
                    node1 = node2;
                }
                textBox1.Text = distance.ToString();
            }
        }

        private void reset()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Fill Details First!!!");
                Reset();
            }
            else if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Choose Different Locations!!!");
                Reset();
            }
            else if (!comboBox1.Items.Contains(comboBox1.SelectedItem) || !comboBox2.Items.Contains(comboBox2.SelectedItem))
            {
                MessageBox.Show("Choose from locations Provided!!!");
                Reset();
            }
            else
            {
                List<GraphNode> path = Map.Dijkstra(Map.FindNode(comboBox1.Text), Map.FindNode(comboBox2.Text));
                ProcessPathEdges(path);
            }
        }

        private void Reset()
        {

            comboBox1.SelectedItem=null;
            comboBox2.SelectedItem=null;
            textBox1.Text = "";
            ChangePanelColors();
        }
        private void ChangePanelColors()
        {
            foreach (var panel in currentColored)
            {
                if (panel != null)
                {
                    panel.BackColor = Color.DeepSkyBlue;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
