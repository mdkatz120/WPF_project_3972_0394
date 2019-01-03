using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    public class Hit
    {
        private DateTime hour ;
        public string name { get; set; }
        public string address { get; set; }
        public int hitNum { get; set; }

        public DateTime Hour
        {
            get { return hour; }
            set { hour = value; }
        }  
            
    }
}
