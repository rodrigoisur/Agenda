using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda
{
    class Persona
    {
        #region atributos

        private string _Nombre;
        private string _Apellidos;
        private int  _Telefono;
        private string _Direccion;
        private DateTime _FechaNacimiento;


        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellidos
        {
            get { return _Apellidos ; }
            set { _Apellidos = value; }
        }

        public int Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public string  Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public DateTime  FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }
        #endregion
        #region constructor

        public Persona ( string nomb, string ape, string dire, DateTime fechana, int telef)
        
        {

            _Nombre  = nomb;
            _Apellidos = ape;
            _Direccion = dire;
            _FechaNacimiento = fechana;
            _Telefono = telef;

        }
            
        #endregion


    }
}
