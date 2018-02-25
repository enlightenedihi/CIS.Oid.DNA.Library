using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.Oid.DNA.Library
{
    
}

namespace NCL
{
    public interface IDNA               //  декларация интерфейса ДНК 
    {
        int DNA();
    }

    public class CL : IDNA
    {
        public int DNA()                //  реализация интерфейса ДНК 
        {
            return 123;
        }
    }
}