using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habemusPapa
{
    public class cardenal
    {
        private int _cantVotosRecicbidos;
        private ENacionalidades _nacionalidad;
        private string _nombre;
        private string _nombrePapal;

        public cardenal()
        {
            this._cantVotosRecicbidos = 0;
        }

        public cardenal(string nombre, string nombrePapal)
        {
            this._nombre = nombre;
            this._nombrePapal = nombrePapal;
        }

        public cardenal(string nombre, string nombrePapal, ENacionalidades nacionalidad):this(nombre,nombrePapal)
        {
            this._nacionalidad = nacionalidad;
        }
        

        public int getCantidadVotosRecibidos()
        {
            return _cantVotosRecicbidos;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("nombre: " + this._nombre);
            sb.AppendLine("nombre papal: " + this._nombrePapal);
            sb.AppendLine("nacionalidad: " + this._nacionalidad);
           
            return sb.ToString();
        }

        public void Mostrar(cardenal c)
        {
            
        }

        public string ObtenerNombreYnombrePapal()
        {
            string papa;
            papa = ("El cardenal: " + _nombre + "se llamara: " + _nombrePapal + ".");
            return papa;
        }

        public bool operator ==(cardenal c1, cardenal c2)
        {
            if(c1._nombre == c2._nombre && c1._nacionalidad == c2._nacionalidad && c1._nombrePapal == c2._nombrePapal)
              return true;
            return false;
        }
        public static cardenal operator ++(cardenal c)
        {
            c._cantVotosRecicbidos += 1;

            return c;
        }
    
    }
}
