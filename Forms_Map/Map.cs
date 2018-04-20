using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Forms_Map
{
    public partial class Map : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        double LatInitial = 9.916915;
        double LngInitial = -84.096066;

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
            gMap.MaxZoom = 24;
            gMap.Zoom = 9;
            gMap.AutoScroll = true;
        }
    }
}
