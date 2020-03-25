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
            Espotifai spotify = new Espotifai();
            Console.WriteLine(spotify.AgregarCancion(new Cancion("","","","")));
            Console.WriteLine(spotify.AgregarCancion(new Cancion("","","","")));
            Console.WriteLine(spotify.AgregarCancion(new Cancion("SAD!", "?", "XXXTENTACION", "Emo Rap")));
            spotify.VerCanciones();
        }
    }
}
