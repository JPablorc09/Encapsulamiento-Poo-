using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.setNombre("Juan");//solo se utiliza parentesis
            persona1.PrimerApellido="Rojas";//solo se le asigna el dato
            persona1.apellidoDos = "Contreras";
            persona1.setIdentificacion("1134535");
            persona1.setEdad(23);
            //imprimir los datos de la instancia persona1
            Console.WriteLine("El nombre de la persona es:{0}",persona1.getNombre());
            Console.WriteLine("El primeraApellido de la persona es:{0}",persona1.PrimerApellido);
            Console.WriteLine("El segundoApellido de la persona es:{0}",persona1.apellidoDos);
            Console.WriteLine("La identificacion de la persona es:{0}",persona1.getIdentificacion());
            Console.WriteLine("La edad de la persona es:{0}",persona1.getEdad());
            
            Mascota mascota = new Mascota("perro","bulldog","cafe",12.5);
            Mascota mascota1 = new Mascota();
            Mascota mascota2= new Mascota();
            Console.Clear();
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------------------");
            mascota1.setNombre("Gato");
            mascota1.setRaza(" Persa");
            mascota1.setColor("cafe");
            mascota1.setAltura(12.4);
            mascota2.setNombre("Perro");
            mascota2.setRaza("beagle");

            Console.WriteLine("El nombre de la mascota:{0} ",mascota1.getNombre());
            Console.WriteLine("La raza  de la mascota:{0} ",mascota1.getRaza());
            Console.WriteLine("El color  de la mascota:{0} ",mascota1.getColor());
            Console.WriteLine("La altura de la mascota:{0}cm",mascota1.getAltura());
            Console.WriteLine("El nombre de la mascota:{0} ",mascota2.getNombre());
            Console.WriteLine("La raza  de la mascota:{0} ",mascota2.getRaza());

            //crear una lista mascota
            List<Mascota> lista = new List<Mascota>();
            lista.Add(mascota1);
            lista.Add(mascota2);
            mascota1= new Mascota("cuqui","jony","gris",1.7);
            lista.Add(mascota1);
            mascota1 = new Mascota("coco", "jony", "cafe", 1.8);
            lista.Add(mascota1);
            mascota1 = new Mascota("laica", "perro", "negro", 1.9);

            foreach (Mascota mascotas in lista)
            {
                Console.WriteLine("El nombre de la mascota:{0} ", mascotas.getNombre());
                Console.WriteLine("La raza  de la mascota:{0} ", mascotas.getRaza());
                Console.WriteLine("El color  de la mascota:{0} ", mascotas.getColor());
                Console.WriteLine("La altura de la mascota:{0}cm", mascotas.getAltura());
                Console.WriteLine("El nombre de la mascota:{0} ", mascotas.getNombre());
                Console.WriteLine("La raza  de la mascota:{0} ", mascotas.getRaza());
            }
            Console.ReadKey();
        }  
    }
}
