using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace CS_Map
{
    public partial class Map : Form
    {
        int zoom = 15;
        public GMapOverlay MarkerOverlay = new GMapOverlay("markers");
        PointLatLng p = new PointLatLng(36.82365, 127.1111);


        

        // 날씨
        const string WeatherURL = "http://www.kma.go.kr/XML/weather/sfc_web_map.xml";
        Dictionary<string, string> DicWeather = new Dictionary<string, string>();

        Thread WeatherChkThread = null;
        delegate void OnXmlDelegate(string k, string v);
        OnXmlDelegate OXD = null;


        public Map()
        {
            InitializeComponent();

            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.Position = p;
            gMapControl.Zoom = 15;
            
            // 마커 표시
            GMarkerGoogle gMarker = new GMarkerGoogle(p, GMarkerGoogleType.red_dot);
            this.gMapControl.Overlays.Add(MarkerOverlay);
            MarkerOverlay.Markers.Add(gMarker);
            gMarker.ToolTipText = "J-Innotech";
            gMarker.ToolTipMode = MarkerTooltipMode.Always;
            gMarker.ToolTip.TextPadding = new Size(10, 10);
            gMarker.ToolTip.Foreground = new SolidBrush(Color.Red);
            gMarker.ToolTip.Offset = new Point(-35, 15);
            gMarker.ToolTip.Fill = new SolidBrush(Color.Transparent);
            gMarker.ToolTip.Stroke = new Pen(Color.Transparent, .0f);
            txt_search.Visible = false;
        }

        // 로고이미지 - 원래위치로 (+사이트연결)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gMapControl.Position = p;
            gMapControl.Zoom = 15;
            //System.Diagnostics.Process.Start("http://j-innotech.com/");
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Visible == false)
                txt_search.Visible = true;

            //gMapControl.SetPositionByKeywords(txt_search.Text);
            //gMapControl.SetPositionByKeywords("서울특별시 강남구 영동대로 513");
            gMapControl.SetPositionByKeywords("제이이노텍");
            Console.WriteLine(gMapControl.Position);
        }


        private void GetWeather()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(WeatherURL);
            XmlNode xmlNode = xmlDocument.DocumentElement;

            foreach (XmlNode xn in xmlNode.FirstChild.ChildNodes)
            {
                string strDataKey = String.Format("{0} / {1} / {2}", xn.InnerText, xn.Attributes["desc"].Value, xn.Attributes["ta"].Value);
                string strDataValue = "http://www.weather.go.kr/weather/forecast/mid-term_01.jsp";
                DicWeather.Add(strDataKey, strDataValue);
            }
        }

        private void OnXmlRun(string key, string value)
        {
            this.toolStripStatusLabel2.Text = DateTime.Now.ToString(string.Format("yy.MM.dd(ddd) HH:mm:ss    |  "));
            
            this.toolStripStatusLabel4.Text = key;
            this.toolStripStatusLabel4.ToolTipText = value;
        }


        private void Map_Load(object sender, EventArgs e)
        {
            OXD = new OnXmlDelegate(OnXmlRun);
            GetWeather();
            WeatherChkThread = new Thread(DisplayWeather);
            WeatherChkThread.Start();
        }

        private void DisplayWeather()
        {
            while (true)
            {
                foreach (KeyValuePair<string, string> news in DicWeather)
                {
                    Invoke(OXD, news.Key, news.Value);
                    Thread.Sleep(1000);
                }
            }
        }

        private void Map_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WeatherChkThread != null)
                WeatherChkThread.Abort();
        }
    }
}
