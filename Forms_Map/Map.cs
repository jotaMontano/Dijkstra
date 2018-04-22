using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Project_Dijkstra;

namespace Forms_Map
{
    public partial class Map : Form
    {
        private const MarkerTooltipMode always = MarkerTooltipMode.Always;
        public GMarkerGoogle _tempMarker;
        public GMapOverlay markerOverlay;
        public GMapRoute PuntosRuta;
        public GMapOverlay Ruta = new GMapOverlay("Ruta");
        public PointLatLng _locationCoordinates;
        bool trazarRuta = false;
        int contadorIndicadoresRuta = 0;
        double LatInitial = 9.916915;
        double LngInitial = -84.096066;

        //prueba
        public PointLatLng inicio;
        public PointLatLng Final;
        // nodo y grafo mover a gestor
        public Graph graph = new Graph();
        public List<Node> nodes = new List<Node>();
        public Map()
        {
            InitializeComponent();

        }
        private void Map_Load(object sender, EventArgs e)
        {
            gMap.DragButton = MouseButtons.Left;
            gMap.CanDragMap = true;
            gMap.MapProvider = GMapProviders.GoogleMap;
            gMap.Position = new PointLatLng(LatInitial, LngInitial);

            gMap.MinZoom = 0;
            gMap.MaxZoom = 45;
            gMap.Zoom = 14;
            gMap.AutoScroll = true;

            //nodos de gestor, 
            Node nodeA = new Node("Mi casa", 9.939562, -84.023247);
            Node nodeB = new Node("San Jose", 9.916915, -84.096066);
            Node nodeC = new Node("Mall San Pedro", 9.933496, -84.056588);
            Node nodeD = new Node("Cenfotec", 9.932410, -84.031022);
            nodes.Add(nodeA);
            nodes.Add(nodeB);
            nodes.Add(nodeC);
            nodes.Add(nodeD);

            nodeA.addDestination(nodeB, 20);
            nodeA.addDestination(nodeD, 3);
            nodeA.addDestination(nodeC, 7);

            nodeB.addDestination(nodeA, 20);
            nodeB.addDestination(nodeC, 13);
            nodeB.addDestination(nodeD, 12);

            nodeC.addDestination(nodeA, 18);
            nodeC.addDestination(nodeB, 13);
            nodeC.addDestination(nodeD, 7);

            nodeD.addDestination(nodeA, 3);
            nodeD.addDestination(nodeB, 12);
            nodeD.addDestination(nodeC, 7);




            graph.addNode(nodeA);
            graph.addNode(nodeB);
            graph.addNode(nodeC);
            graph.addNode(nodeD);
            //marcador mapa

            foreach (var item in graph.getNodes())
            {
                gMapShowLocations(item);
            }
           

            HideComponents();
            CbOrigin_Charge(nodes);
            CbDestiny_Charge(nodes);

        }
        public void gMapShowLocations(Node node)
        {
            markerOverlay = new GMapOverlay("Marcador");
            _locationCoordinates = new PointLatLng(node.getLatInitial(), node.getLngInitial());
            _tempMarker = new GMarkerGoogle(_locationCoordinates, GMarkerGoogleType.red);
            _tempMarker.ToolTipMode = MarkerTooltipMode.Always;
            _tempMarker.ToolTipText = string.Format("Ubicacion:{0} \n Latitud: {1} \n Longitud: {2}", node.getName(), node.getLatInitial(), node.getLngInitial());
          
            markerOverlay.Markers.Add(_tempMarker);
            gMap.Position = _tempMarker.Position;
            gMap.Overlays.Add(markerOverlay);
        }

        private void CbOrigin_Charge(object sender)
        {
            foreach (Node ubication in nodes)
            {
                CbOrigin.Items.Add(ubication.getName());
            }
        }

        private void CbDestiny_Charge(object sender)
        {
            foreach (Node ubication in nodes)
            {
                CbDestiny.Items.Add(ubication.getName());
            }
        }
        public void HideComponents()
        {
            CbDestiny.Hide();
            LblDestiny.Hide();
            BtnGo.Hide();
            BtnBack.Hide();
            CbOrigin_Enable();
            CbDestiny_Enable();


        }
        private void CbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbDestiny.Show();
            LblDestiny.Show();
            CbOrigin_Disable();
            CbDestiny_Value_Hide();
            btnBackShow();

        }
        public void CbOrigin_Enable()
        {
            CbOrigin.Enabled = true;
        }
        public void CbOrigin_Disable()
        {
            CbOrigin.Enabled = false;
        }
        public void CbDestiny_Value_Hide()
        {
            CbDestiny.Items.Remove(CbOrigin.Text);
            CbDestiny.Refresh();

        }
        public void btnBackShow()
        {
            BtnBack.Show();
        }

        private void CbDestiny_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnGo.Show();
            CbDestiny_disable();
        }
        public void CbDestiny_Enable()
        {
            CbDestiny.Enabled = true;
        }
        public void CbDestiny_disable()
        {
            CbDestiny.Enabled = false;
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            HideComponents();
            CbDestiny_clear();
            CbDestiny_Charge(nodes);
            trazarRuta = false;
            Ruta.Clear();

        }
        public void CbDestiny_clear()
        {
            CbDestiny.Items.Clear();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            BtnGo.Hide();
            trazarRuta = true;
            List<PointLatLng> Puntos = new List<PointLatLng>();
            var index = CbOrigin.SelectedIndex;
            Node Nodesource = null;
            foreach (var item in nodes)
            {
                if(item.getName() == CbDestiny.Text)
                {
                    Nodesource = item;
                }
            }
            var mts = 0;
            graph = Dijkstra.calculateShortestPathFromSource(graph, Nodesource);
            var last = false;
            foreach (Node node in graph.getNodes())
            {
          
               foreach (Node destino in node.getShortestPath())
               {
                    mts = mts + node.getDistance();
                    Puntos.Add(new PointLatLng(node.getLatInitial(), node.getLngInitial()));

                }
             
            }
            PuntosRuta = new GMapRoute(Puntos, "Ruta");
            Ruta.Routes.Add(PuntosRuta);

            gMap.Overlays.Add(Ruta);
            gMap.Zoom = gMap.Zoom + 1;
            gMap.Zoom = gMap.Zoom - 1;
        }
        
    }
}
