using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class AlbumFotos
    {
        private int _numPaginas;
        public int numPagina
        {
            get { return _numPaginas; }
        }

        public AlbumFotos()
        {
            _numPaginas = 16;
        }
        public AlbumFotos(int cant)
        {
            _numPaginas = cant;
        }

    }
}
