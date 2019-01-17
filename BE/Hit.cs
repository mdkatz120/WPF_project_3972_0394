using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BE
{
    public class Hit
    {
        public int id { get; set;}
        private DateTime time ;
        public string name { get; set; }
        public string address { get; set; }
        public int hitNum { get; set; }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }  
         public Hit fromJSON(string json)
        {
           return  JsonConvert.DeserializeObject<Hit>(json);
        }   
        public string stringfy()
        {
           return JsonConvert.SerializeObject(this);
        }
    }
}
