using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAhorcado
{
    class Palabra
    {
        public string MyPalabra { get; set; }
        public string Categoria { get; set; }
        public string Pista { get; set; }

        public Palabra(string MyPalabra, string Categoria, string Pista)
        {
            this.MyPalabra = MyPalabra;
            this.Categoria = Categoria;
            this.Pista = Pista;
        }
    }
}
