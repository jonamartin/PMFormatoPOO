using System;
using System.Collections.Generic;
using System.Text;



namespace ConsoleApplication
{
    public class Sprint
    {
        // Caracteristicas importante dentro del modelo
               
        private List<Tarea> lista = new List<Tarea> ();
       
       
        public Sprint(){
              
        }

        
        // Devuelve el tiempo total del Sprint Backlogs
        public float dameTiempoTotal(){

            float tiempoTotal =  0.0f;

            foreach (Tarea tare in lista){
                tiempoTotal= tiempoTotal + tare.dameTiempo();
            } 

            return tiempoTotal;
           
        }


        public void agregarTarea(Tarea tare){
            lista.Add(tare);
        }

    }
}
