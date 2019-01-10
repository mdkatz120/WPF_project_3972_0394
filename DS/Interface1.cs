using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public interface Interface1
    {
        bool insert();
        bool update();
        bool delete();
        Hit select(int HitNum);
    }
}
