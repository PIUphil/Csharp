using System;
using System.Xml;

namespace CS_Weather
{
    class Program
    {
        const string WeatherURL = "http://www.kma.go.kr/XML/weather/sfc_web_map.xml";

        static void Main(string[] args)
        {
            
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(WeatherURL);
            XmlNode xmlNode = xmlDocument.DocumentElement;

            foreach (XmlNode xn in xmlNode.FirstChild.ChildNodes)
                if (xn.InnerText == "천안")
                    Console.WriteLine(string.Format("{0} / {1} / {2}℃",xn.InnerText, xn.Attributes["desc"].Value, xn.Attributes["ta"].Value));
        }
    }
}
