using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BE;
using Microsoft.Maps.MapControl.WPF;
using Newtonsoft.Json.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BL
{
    public class Locations
    {
        string SvApiKey = "AIzaSyDTh-8m3U8TX3H6d67YnY8lbclsxJbfpMM";
        public async Task<Location> GetAsyncCordinate(Location address)
        {

         // number street , city , state , country , postal code
            string uri = "https://nominatim.openstreetmap.org/search?q="+address+"&format=json";
            var httpClient = new HttpClient();
            dynamic content = JObject.Parse(await httpClient.GetStringAsync(uri));
            Location loc = new Location(double.Parse (content.lat),double.Parse(content.lon));
            return await Task.Run(() => loc );
        }

        public async Task<Image> GetStreetViewImage(Location address)
        {

            // number street , city , state , country , postal code
            Uri uri = new Uri("https://maps.googleapis.com/maps/api/streetview?location=" + address + "&size=456x456&key="+SvApiKey);
            var httpClient = new HttpClient();
           dynamic content=new Image()  ;
         //   content.Source = new BitmapImage(  httpClient.GetStringAsync(uri));
            return await Task.Run(() => content );
        }
    }
}
