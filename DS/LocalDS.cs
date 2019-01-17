using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public class LocalDS : Interface1
    {
        public static HashSet<Hit> HitList = new HashSet<Hit> {new Hit() {name="Yair",Time=new DateTime(2018,1,17,00,32,12),hitNum=5,address="tveria, 25, jerusalem",id=1},
                                                               new Hit() {name="Moshe ",Time=new DateTime(2018,2,17,17,13,45),hitNum=3,address="yaffo, 13, jerusalem",id=2} };

        public bool delete()
        {
            throw new NotImplementedException();
        }

        public bool insert(Hit hit)
        {
            throw new NotImplementedException();
        }

        public Hit select(int HitNum)
        {
            throw new NotImplementedException();
        }

        public bool update()
        {
            throw new NotImplementedException();
        }
    }
}
