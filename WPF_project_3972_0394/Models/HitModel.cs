using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_project_3972_0394.Models
{
   public class HitModel
    {
        public static int ID = 1;
       public List<Hit> Hits { get; set; }

        public HitModel()
        {
            Hits = new List<Hit>();
        }
public void AddHit(string Name ,string Address , int HitNum, DateTime time )
        {
            Hits.Add(new Hit { id = ID++, address = Address, hitNum = HitNum, name = Name, Time = time });
            string s = "";

        }
    }
}
