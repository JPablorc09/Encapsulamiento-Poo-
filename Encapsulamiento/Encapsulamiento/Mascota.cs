using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Mascota
    {
        private string nombre;
        private string raza;
        private string color;
        private double altura;

        public Mascota()
        {
            Console.WriteLine(" Constructor vacio");
        }
        //constructor con parametros
        public Mascota(string nombre, string raza, string color, double altura)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.color = color;
            this.altura = altura;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
         public string getRaza()
        {
            return raza;
        }
        public void setRaza(string raza)
        {
            this.raza = raza;
        }
        public string getColor()
        {
            return color;
        }
       public  void setColor(string color)
        {
            this.color = color;
        }
        public double getAltura()
        {
            return altura;
        }
        public void  setAltura(double altura)
        {
            this.altura = altura;
        }
    }
        
}
