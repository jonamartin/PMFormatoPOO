using System;

namespace ConsoleApplication
{
    public class Clasificacion 
    {
        // Caracteristicas importante dentro del modelo
        private string dificultad;        

       
       
        public Clasificacion(string dificul){
            this.dificultad=dificul;

        }

        
        // Devuelve el nombre del tipo de dificultad
        public string dameDificultad(){
            
            return this.dificultad;
        }

    }
}
