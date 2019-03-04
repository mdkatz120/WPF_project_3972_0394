using Microsoft.Maps.MapControl.WPF;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Locations
    {
        public int id { get; set; }
        public Location loc { get; set; }

        public Locations fromJSON(string json)
        {
            return JsonConvert.DeserializeObject<Locations>(json);
        }
        public string stringfy()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
