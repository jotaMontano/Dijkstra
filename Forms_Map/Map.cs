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
        double LatInitial = 9.916915;
        double LngInitial = -84.096066;

        //prueba
        public PointLatLng inicio;
        public PointLatLng Final;
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
            Node nodeB = new Node("Cenfotec", 9.932410, -84.031022);
            Node nodeC = new Node("Mall San Pedro", 9.933496, -84.056588);
            Node nodeD = new Node("San Jose", 9.916915, -84.096066);
            Node NodeE = new Node("Aeropuerto Internacional Juan Santamaría", 9.998766, -84.204073);
       
          
            nodes.Add(nodeA);
            nodes.Add(nodeB);
            nodes.Add(nodeC);
            nodes.Add(nodeD);
            nodes.Add(NodeE);


            graph.add_vertex(nodeA, new Dictionary<Node, int>() { { nodeB, 3 } });
            graph.add_vertex(nodeB, new Dictionary<Node, int>() { { nodeA, 3 }, { nodeC, 5 } });
            graph.add_vertex(nodeC, new Dictionary<Node, int>() { { nodeB, 5 }, { nodeD, 4 } });
            graph.add_vertex(nodeD, new Dictionary<Node, int>() { { nodeC, 4 }});
            graph.add_vertex(NodeE, new Dictionary<Node, int>() { { nodeA, 1}, { nodeD, 1 } });

            //marcador mapa

            foreach (var item in nodes)
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
            Ruta.Clear();

        }
        public void CbDestiny_clear()
        {
            CbDestiny.Items.Clear();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            BtnGo.Hide();
         
            List<PointLatLng> Puntos = new List<PointLatLng>();
            Node Nodesource = null;
            Node NodeDestination = null; 
            foreach (var item in nodes)
            {
                if(item.getName() == CbOrigin.Text)
                {
                    Nodesource = item;
                }
                if (item.getName() == CbDestiny.Text)
                {
                    NodeDestination = item;
                }
            }
            var mts = 0;

            foreach (var node in graph.shortest_path(Nodesource, NodeDestination))
            {
                Puntos.Add(new PointLatLng(node.getLatInitial(), node.getLngInitial()));
            }
            Puntos.Add(new PointLatLng(Nodesource.getLatInitial(), Nodesource.getLngInitial()));
            PuntosRuta = new GMapRoute(Puntos, "Ruta");
            Ruta.Routes.Add(PuntosRuta);

            gMap.Overlays.Add(Ruta);
            gMap.Zoom = gMap.Zoom + 1;
            gMap.Zoom = gMap.Zoom - 1;
        }
        
    }
}
