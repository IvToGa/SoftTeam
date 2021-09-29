using System;

namespace Veterinaria.App.Dominio
{
    public class EntidadHistoriaClinica {
       public int Id {get; set;}
       public String Diagnostico {get; set;}
       public  String Tratamiento {get; set;}
       public DateTime FechaRevision {get; set;} 
    }    
}