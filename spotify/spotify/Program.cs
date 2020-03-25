using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion c1 = new Cancion("SAD!", "?", "XXXTENTACION", "Emo Rap");
            Console.WriteLine(c1.Informacion());
        }
    }
}
