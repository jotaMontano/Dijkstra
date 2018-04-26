using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dijkstra;
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
        public GMapOverlay capaRutas = new GMapOverlay("Capa de la ruta");


        public PointLatLng inicio;
        public PointLatLng Final;
        //public Graph graph;
        public List<Node> nodes;
        static Manager manager = Manager.Instance;
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

            nodes = manager.loadLocations();

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
            _tempMarker.ToolTipText = string.Format("{0}", node.getName());

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
            capaRutas.Clear();

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
                if (item.getName() == CbOrigin.Text)
                {
                    Nodesource = item;
                }
                if (item.getName() == CbDestiny.Text)
                {
                    NodeDestination = item;
                }
            }

            var showMst = true;

            var listShort = manager.shortest_path(NodeDestination, Nodesource);
            for (var i = 0; i < listShort.Count; i++)
            {
                GDirections direction;
                PointLatLng final;
             
                var inicial = new PointLatLng(listShort[i].getLatInitial(), listShort[i].getLngInitial());
                try
                {
                    final = new PointLatLng(listShort[i + 1].getLatInitial(), listShort[i + 1].getLngInitial());
                }
                catch (Exception ex)
                {
                    final = new PointLatLng(NodeDestination.getLatInitial(), NodeDestination.getLngInitial());

                }

                var rutasDireccion = GMapProviders.GoogleMap.GetDirections(out direction, inicial, final, false, false, false, false, false);
                GMapRoute rutaObtenida = new GMapRoute(direction.Route, "Ruta ubicacion");
                capaRutas.Routes.Add(rutaObtenida);
                gMap.Overlays.Add(capaRutas);
              

            }

            MessageBox.Show(string.Format("Distancia entre {0} => {1} es {2} KM", Nodesource.getName(), NodeDestination.getName(), getDistance(Nodesource, NodeDestination)));
            gMap.Zoom = gMap.Zoom + 1;
            gMap.Zoom = gMap.Zoom - 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackZoom.Value = Convert.ToInt32(gMap.Zoom);
        }

        public double rad(double x)
        {

            return x * Math.PI / 180;
        }
        public double getDistance(Node NodeSource, Node NodeDestination)
        {
            var R = 6378137; // Earth’s mean radius in meter
            var dLat = rad(NodeDestination.getLatInitial() - NodeSource.getLatInitial());
            var dLong = rad(NodeDestination.getLngInitial() - NodeSource.getLngInitial());
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
            Math.Cos(rad(NodeSource.getLatInitial())) * Math.Cos(rad(NodeSource.getLatInitial())) *
            Math.Sin(dLong / 2) * Math.Sin(dLong / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c;
            return Math.Round(d) / 1000;
        }
    }
}
