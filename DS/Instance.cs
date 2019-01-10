using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class Instance
    {
        static Interface1 instance = null;
        public static String mode = "lists";
        public  static Interface1 getInstance()
        {
            if (mode == "lists")
            {
                if (instance == null)
                    instance = new DS.LocalDS();
                return instance;
            }
            if (mode == "sql")
            {
                if (instance == null)
                               instance = new DS.SQLServerDS();
                    return instance;
            }
           
            return null;
        }
    }
}
