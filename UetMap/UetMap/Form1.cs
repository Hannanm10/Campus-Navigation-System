using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UetMap
{
    public partial class Form1 : Form
    {
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

        private void ProcessAllPaths(UetMap.List<UetMap.List<GraphNode>> paths)
        {
            // Declare variables to track the top three paths and their distances
            float firstShortestDistance = float.MaxValue;
            float secondShortestDistance = float.MaxValue;
            float thirdShortestDistance = float.MaxValue;

            UetMap.List<GraphNode> firstShortestPath = null;
            UetMap.List<GraphNode> secondShortestPath = null;
            UetMap.List<GraphNode> thirdShortestPath = null;

            foreach (var path in paths)
            {
                float dis = 0;

                // Calculate the total distance of the current path
                using (var enumerator = path.GetEnumerator())
                {
                    if (!enumerator.MoveNext()) continue; // Skip empty paths

                    var node1 = enumerator.Current;

                    while (enumerator.MoveNext())
                    {
                        var node2 = enumerator.Current;

                        // Find the edge between these two nodes
                        var edge = Map.FindEdge(node1, node2);

                        if (edge != null)
                        {
                            // Sum up the distances of the edges
                            dis += edge.Distance;

                            // Optionally process edge visual appearance
                            //edge.RoadPanel.BackColor = Color.LightGreen;
                        }

                        node1 = node2; // Move to the next node
                    }
                }

                // Track the top three shortest paths
                if (dis < firstShortestDistance)
                {
                    // Replace the first shortest path
                    thirdShortestDistance = secondShortestDistance;
                    thirdShortestPath = secondShortestPath;

                    secondShortestDistance = firstShortestDistance;
                    secondShortestPath = firstShortestPath;

                    firstShortestDistance = dis;
                    firstShortestPath = path;
                }
                else if (dis < secondShortestDistance)
                {
                    // Replace the second shortest path
                    thirdShortestDistance = secondShortestDistance;
                    thirdShortestPath = secondShortestPath;

                    secondShortestDistance = dis;
                    secondShortestPath = path;
                }
                else if (dis < thirdShortestDistance)
                {
                    // Replace the third shortest path
                    thirdShortestDistance = dis;
                    thirdShortestPath = path;
                }
            }

            // Change the color of the edges in the top three paths
            //ChangeEdgeColors(firstShortestPath, Color.Blue);
            //ChangeEdgeColors(secondShortestPath, Color.Blue);
            ChangeEdgeColors(thirdShortestPath, Color.Red);
            textBox1.Text = thirdShortestDistance.ToString();
        }

        // Helper method to change the edge colors for a given path
        private void ChangeEdgeColors(UetMap.List<GraphNode> path, Color color)
        {
            if (path == null) return; // If path is null, do nothing

            using (var enumerator = path.GetEnumerator())
            {
                if (!enumerator.MoveNext()) return; // Skip empty paths

                var node1 = enumerator.Current;

                while (enumerator.MoveNext())
                {
                    var node2 = enumerator.Current;

                    // Find the edge between these two nodes
                    var edge = Map.FindEdge(node1, node2);

                    if (edge != null)
                    {
                        // Set the color of the edge's RoadPanel
                        edge.RoadPanel.BackColor = color;
                        currentColored.Add(edge.RoadPanel);
                    }

                    node1 = node2; // Move to the next node
                }
            }
        }

        private UetMap.List<UetMap.List<GraphNode>> GetTopThreeShortestPaths(UetMap.List<UetMap.List<GraphNode>> allPaths)
        {
            // Create a list to store paths along with their total distances (using the built-in List<T>)
            var pathDistances = new List<(UetMap.List<GraphNode> path, float distance)>();

            // Iterate through all paths and calculate the distance
            foreach (var path in allPaths)
            {
                float totalDistance = 0;

                // Calculate the total distance of this path
                using (var enumerator = path.GetEnumerator())
                {
                    if (!enumerator.MoveNext()) continue; // Skip empty paths

                    var node1 = enumerator.Current;

                    while (enumerator.MoveNext())
                    {
                        var node2 = enumerator.Current;
                        var edge = Map.FindEdge(node1, node2);

                        if (edge != null)
                        {
                            totalDistance += edge.Distance; // Sum up the distances of the edges
                        }

                        node1 = node2; // Move to the next node
                    }
                }

                // Add the path and its total distance to the list
                pathDistances.Add((path, totalDistance));
            }

            // Sort the paths based on their total distance
            pathDistances.Sort((x, y) => x.distance.CompareTo(y.distance));

            // Create a new list to hold the top 3 shortest paths
            var topThreePaths = new UetMap.List<UetMap.List<GraphNode>>();

            // Iterate over the first 3 elements and add them to topThreePaths
            int count = 0;
            foreach (var pathDistance in pathDistances)
            {
                if (count >= 3)
                    break;  // Stop once we've added 3 paths

                topThreePaths.Add(pathDistance.path);  // Add the path to the result list
                count++;
            }

            return topThreePaths;
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
                GraphNode start = Map.FindNode(comboBox1.SelectedItem.ToString());
                GraphNode end = Map.FindNode(comboBox2.SelectedItem.ToString());
                List<GraphNode> path = Map.Dijkstra(start, end);
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
                    panel.BackColor = Color.Black;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button3_Click(object sender, EventArgs e)
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
                GraphNode start = Map.FindNode(comboBox1.SelectedItem.ToString());
                GraphNode end = Map.FindNode(comboBox2.SelectedItem.ToString());
                List<List<GraphNode>> nodes = Map.FindAllPaths(start, end);
                ProcessAllPaths(nodes);
            }
        }

        private void label54_Click(object sender, EventArgs e)
        {
            label54.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Colony");
            label54.BorderStyle = BorderStyle.None;
        }

        private void label65_Click(object sender, EventArgs e)
        {
            label65.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Colony");
            label65.BorderStyle = BorderStyle.None;
        }

        private void label67_Click(object sender, EventArgs e)
        {
            label67.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Boys Hostel");
            label67.BorderStyle = BorderStyle.None;
        }

        private void label66_Click(object sender, EventArgs e)
        {
            label66.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Boys Hostel");
            label66.BorderStyle = BorderStyle.None;
        }

        private void label64_Click(object sender, EventArgs e)
        {
            label64.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Boys Hostel");
            label64.BorderStyle = BorderStyle.None;
        }

        private void label63_Click(object sender, EventArgs e)
        {
            label63.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Boys Hostel");
            label63.BorderStyle = BorderStyle.None;
        }

        private void label59_Click(object sender, EventArgs e)
        {
            label59.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Boys Hostel");
            label59.BorderStyle = BorderStyle.None;
        }

        private void label61_Click(object sender, EventArgs e)
        {
            label61.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Boys Hostel");
            label61.BorderStyle = BorderStyle.None;
        }

        private void label42_Click(object sender, EventArgs e)
        {
            label42.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Boys Hostel");
            label42.BorderStyle = BorderStyle.None;
        }

        private void label43_Click(object sender, EventArgs e)
        {
            label43.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Boys Hostel");
            label43.BorderStyle = BorderStyle.None;
        }

        private void label41_Click(object sender, EventArgs e)
        {
            label41.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Boys Hostel");
            label41.BorderStyle = BorderStyle.None;
        }

        private void label40_Click(object sender, EventArgs e)
        {
            label40.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Boys Hostel");
            label40.BorderStyle = BorderStyle.None;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Girls Hostel");
            label9.BorderStyle = BorderStyle.None;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Faculty/Bachelor Hostel");
            label9.BorderStyle = BorderStyle.None;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Girls Hostel");
            label6.BorderStyle = BorderStyle.None;
        }

        private void label62_Click(object sender, EventArgs e)
        {
            label62.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Cafe");
            label62.BorderStyle = BorderStyle.None;
        }

        private void label39_Click(object sender, EventArgs e)
        {
            label39.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Cafe");
            label39.BorderStyle = BorderStyle.None;
        }

        private void label36_Click(object sender, EventArgs e)
        {
            label36.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Cafe");
            label36.BorderStyle = BorderStyle.None;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label14.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Cafe");
            label14.BorderStyle = BorderStyle.None;
        }

        private void label57_Click(object sender, EventArgs e)
        {
            label57.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Cafe");
            label57.BorderStyle = BorderStyle.None;
        }

        private void label32_Click(object sender, EventArgs e)
        {
            label32.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Sports Ground");
            label32.BorderStyle = BorderStyle.None;
        }

        private void label38_Click(object sender, EventArgs e)
        {
            label38.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Sports Ground");
            label38.BorderStyle = BorderStyle.None;
        }

        private void label37_Click(object sender, EventArgs e)
        {
            label37.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Sports Ground");
            label37.BorderStyle = BorderStyle.None;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Sports Ground");
            label7.BorderStyle = BorderStyle.None;
        }

        private void label60_Click(object sender, EventArgs e)
        {
            label60.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Shopping");
            label60.BorderStyle = BorderStyle.None;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label12.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("UET Auditorium");
            label12.BorderStyle = BorderStyle.None;
        }

        private void label22_Click(object sender, EventArgs e)
        {
            label22.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Library");
            label22.BorderStyle = BorderStyle.None;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            label21.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Park");
            label21.BorderStyle = BorderStyle.None;
        }

        private void label68_Click(object sender, EventArgs e)
        {
            label68.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("UET Main Gate");
            label68.BorderStyle = BorderStyle.None;
        }

        private void label69_Click(object sender, EventArgs e)
        {
            label69.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("UET Gate No.5");
            label69.BorderStyle = BorderStyle.None;
        }

        private void label53_Click(object sender, EventArgs e)
        {
            label53.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Staff Colony Gate 2");
            label53.BorderStyle = BorderStyle.None;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("UET PowerHouse");
            label5.BorderStyle = BorderStyle.None;
        }

        private void label31_Click(object sender, EventArgs e)
        {
            label31.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("HBL Bank");
            label31.BorderStyle = BorderStyle.None;
        }

        private void label29_Click(object sender, EventArgs e)
        {
            label29.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Office");
            label29.BorderStyle = BorderStyle.None;
        }

        private void label30_Click(object sender, EventArgs e)
        {
            label30.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Office");
            label30.BorderStyle = BorderStyle.None;
        }

        private void label55_Click(object sender, EventArgs e)
        {
            label55.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Office");
            label55.BorderStyle = BorderStyle.None;
        }

        private void label56_Click(object sender, EventArgs e)
        {
            label56.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Office");
            label56.BorderStyle = BorderStyle.None;
        }

        private void label44_Click(object sender, EventArgs e)
        {
            label44.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Office");
            label44.BorderStyle = BorderStyle.None;
        }

        private void label70_Click(object sender, EventArgs e)
        {
            label70.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("UET Main Parking");
            label70.BorderStyle = BorderStyle.None;
        }

        private void label35_Click(object sender, EventArgs e)
        {
            label35.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department/Mechanical Workshop");
            label35.BorderStyle = BorderStyle.None;
        }

        private void label34_Click(object sender, EventArgs e)
        {
            label34.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label34.BorderStyle = BorderStyle.None;
        }

        private void label33_Click(object sender, EventArgs e)
        {
            label33.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label33.BorderStyle = BorderStyle.None;
        }

        private void label27_Click(object sender, EventArgs e)
        {
            label27.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label27.BorderStyle = BorderStyle.None;
        }

        private void label28_Click(object sender, EventArgs e)
        {
            label28.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label28.BorderStyle = BorderStyle.None;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            label23.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label23.BorderStyle = BorderStyle.None;
        }

        private void label45_Click(object sender, EventArgs e)
        {
            label45.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label45.BorderStyle = BorderStyle.None;
        }

        private void label46_Click(object sender, EventArgs e)
        {
            label46.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label46.BorderStyle = BorderStyle.None;
        }

        private void label52_Click(object sender, EventArgs e)
        {
            label52.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label52.BorderStyle = BorderStyle.None;
        }

        private void label49_Click(object sender, EventArgs e)
        {
            label49.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label49.BorderStyle = BorderStyle.None;
        }

        private void label48_Click(object sender, EventArgs e)
        {
            label48.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label48.BorderStyle = BorderStyle.None;
        }

        private void label51_Click(object sender, EventArgs e)
        {
            label51.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label51.BorderStyle = BorderStyle.None;
        }

        private void label50_Click(object sender, EventArgs e)
        {
            label50.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label50.BorderStyle = BorderStyle.None;
        }

        private void label47_Click(object sender, EventArgs e)
        {
            label47.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label47.BorderStyle = BorderStyle.None;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            label25.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label25.BorderStyle = BorderStyle.None;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label10.BorderStyle = BorderStyle.None;
        }

        private void label24_Click(object sender, EventArgs e)
        {
            label24.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label24.BorderStyle = BorderStyle.None;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label13.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label13.BorderStyle = BorderStyle.None;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            label20.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label20.BorderStyle = BorderStyle.None;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            label19.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label19.BorderStyle = BorderStyle.None;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            label18.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label18.BorderStyle = BorderStyle.None;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label15.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label15.BorderStyle = BorderStyle.None;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label16.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label16.BorderStyle = BorderStyle.None;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label17.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label17.BorderStyle = BorderStyle.None;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Department");
            label11.BorderStyle = BorderStyle.None;
        }

        private void label58_Click(object sender, EventArgs e)
        {
            label58.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Sports Complex");
            label58.BorderStyle = BorderStyle.None;
        }
    }
}
