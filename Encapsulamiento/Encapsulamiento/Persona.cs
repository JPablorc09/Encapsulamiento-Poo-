using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
     class Persona
    {
        //atribtos de la clase
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string identificacion;
        private byte edad;

        //metodos set y get. Permite tener acceso a los atributos para
        //modificar(set) o ver,acceder(get) el dato que tiene

        //get para obtener el dato del atributo nombre
        //se debe definir public,se debe indicar el tipo de dato
        //luego se agregfa el get nombreAtributo

        public string getNombre()
        {
            return nombre;
        }
        //metodo set para modificar el contenido del atributo
        public void  setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        //otras formas implementar el get y el set
        public string PrimerApellido
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }
        //utilizando una expresion lambda para crear el metodo get y set
        public string apellidoDos
        {
            get => apellido2; set => apellido2 = value;
        }
        public string getIdentificacion()
        {
            return identificacion;
        }
        public void setIdentificacion(string identificacion)
        {
            this.identificacion = identificacion;
        }
        public  byte getEdad()
        {
          return edad;
        }
        public void setEdad(byte edad)
        {
            this.edad = edad;
        }
    }
}
