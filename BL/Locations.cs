using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public class Locations
    {
        public async Task<string> GetAsyncCordinate(string address)
        {

         // number street , city , state , country , postal code
            string uri = "https://nominatim.openstreetmap.org/search?q="+address+"&format=json";
            var httpClient = new HttpClient();
            var content = await httpClient.GetStringAsync(uri);
     
            return await Task.Run(() => content.ToString() );
        }
    }
}
