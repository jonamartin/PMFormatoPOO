using System;

namespace ConsoleApplication
{
    public class Tarea 
    {
        // Caracteristicas importante dentro del modelo

        private string descripcion;
        private float hora;
        private Clasificacion clasificacion;        

       
       
        public Tarea(string descrip, float h, Clasificacion clasi){
            this.descripcion=descrip;
            this.hora=h;
            this.clasificacion=clasi;

        }

        
        // Devuelve el tiempo que dura la Tarea segun su clasificacion de dificultad
        public float dameTiempo(){
            string dificultad= this.clasificacion.dameDificultad();
            float tiempo=0.0f;
            if(dificultad.Equals("facil")){
                tiempo=this.hora;
            }else{
                if(dificultad.Equals("Complicado")){
                    tiempo=this.hora+(this.hora*0.2f);
                }else{
                    tiempo=this.hora+(this.hora*0.5f);
                }
            }
            

            return tiempo;


        }

    }
}
