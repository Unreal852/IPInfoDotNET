using System.Drawing;
using System.IO;

namespace IPInfoDotNET
{
    public partial class IPInfo
    {
        private Image m_mapLocation;

        private IPInfo(JSParser parser)
        {
            IP = parser["ip"];
            HostName = parser["hostname"];
            City = parser["city"];
            Region = parser["region"];
            Country = parser["country"];
            Location = parser["loc"];
            Postal = parser["postal"];
            Organitation = parser["org"];
        }

        public string IP { get; }
        public string HostName { get; }
        public string City { get; }
        public string Region { get; }
        public string Country { get; }
        public string Location { get; }
        public string Postal { get; }
        public string Organitation { get; }

        public Image MapLocalisation
        {
            get
            {
                if (m_mapLocation != null)
                    return m_mapLocation;
                string[] loc = Location.Split(',');
                string latitude = loc[0];
                string longitude = loc[1];
                //string requestUrl = "http://maps.googleapis.com/maps/api/staticmap?center=" + latitude + "," + longitude + "&zoom=14&scale=2&size=600x300&maptype=roadmap&format=png&visual_refresh=true";
                string requestUrl = $"http://maps.googleapis.com/maps/api/staticmap?center={latitude},{longitude}&zoom=14&scale=2&size=600x300&maptype=roadmap&format=png&visual_refresh=true";
                System.Diagnostics.Process.Start(requestUrl);
                byte[] imageData = DownloadData(requestUrl);
                MemoryStream stream = new MemoryStream(imageData);
                Image img = Image.FromStream(stream);
                stream.Close();
                m_mapLocation = img;
                return img;
            }
        }
    }
}
