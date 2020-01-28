using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Clasificacion clasi1 = new Clasificacion("Facil");
            Clasificacion clasi2 = new Clasificacion("Complicado");
            Clasificacion clasi3 = new Clasificacion("Muy Complicado");


            Tarea tare1= new Tarea("Codificar..",5f,clasi2);
            Tarea tare2= new Tarea("Investigar..",10f,clasi3);
            Tarea tare3= new Tarea("Diseñar..",8f,clasi2);
            Tarea tare4= new Tarea("Crear Test..",12f,clasi3);
            Tarea tare5= new Tarea("Modificar Vistas",4f,clasi2);
            Tarea tare6= new Tarea("Actualizar..",7f,clasi3);
            Tarea tare7= new Tarea("Ampliar Diseño..",10f,clasi2);
            Tarea tare8= new Tarea("Mod Base de Datos",6f,clasi3);

            

            Sprint sprint1 = new Sprint();
            Sprint sprint2 = new Sprint();
            sprint1.agregarTarea(tare1);
            sprint1.agregarTarea(tare2);
            sprint1.agregarTarea(tare3);
            sprint1.agregarTarea(tare4);

            sprint2.agregarTarea(tare5);
            sprint2.agregarTarea(tare6);
            sprint2.agregarTarea(tare7);
            sprint2.agregarTarea(tare8);


            List <Sprint> Proyecto = new List<Sprint>();
            Proyecto.Add(sprint1);
            Proyecto.Add(sprint2);
            
            float tiempo=0f;
            int i=1;
            foreach(Sprint s in Proyecto){
                Console.WriteLine("El tiempo del Sprint "+i);
                Console.WriteLine(s.dameTiempoTotal());
                tiempo=tiempo+s.dameTiempoTotal();
                i++;
            
            }
            Console.WriteLine("El tiempo del proyecto");
            Console.WriteLine(tiempo);


        }
    }
}
