using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CatalagoPelis.Models
{
    public class Pelicula
    {
        public string _nombre { get; set; }
        public string _genero { get; set; }
        public string _director { get; set; }

        public Pelicula(string nombre, string genero, string _director)
        {
            _nombre = nombre;
            _genero = genero;
            _director = _director;
        }

        public override string ToString()
        {
            return $"Titulo: {_nombre}, Genero: {_genero}, Dirigida por: {_director}";
        }
    }
}