using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habemusPapa
{
    class conclave
    {
        private int _cantMaxCardenales;
        private List<cardenal> _cardenales;
        private bool _habemusPapa;
        private string _lugarEleccion;
        private cardenal _papa;
        public int cantidadVotaciones;
        public DateTime fechaVotacion;

        public conclave()
        {
            this._cantMaxCardenales = 1;
            this._lugarEleccion = "capilla sixtina";
        }

        private static conclave()
        {
            
        }

        public conclave(int cantidadCardenales)
        {
            this._cantMaxCardenales = cantidadCardenales;
        }

        public conclave(int cantidadCardenales, string lugarEleccion):this(cantidadCardenales)
        {
            this._lugarEleccion = lugarEleccion;
        }

        public bool HayLugar()
        {
            if (this._cantMaxCardenales < this._cardenales.Count)
            {
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            throw new System.NotImplementedException();
        }

        public string mostrarCardenales()
        {
            throw new System.NotImplementedException();
        }

        public void VotarPapa()
        {
            throw new System.NotImplementedException();
        }

        private void contarVotos(conclave conclave)
        {

        }

        /*public bool operator implicit(int cantidadDeCardenales)
        {
            
        }*/
       
    }
}
