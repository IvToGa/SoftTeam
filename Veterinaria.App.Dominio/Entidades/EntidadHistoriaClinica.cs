using System;

namespace Veterinaria.App.Dominio
{
    public class EntidadHistoriaClinica {
       public int Id {get; set;}
       public int IdMascota {get; set;}
       public int IdHC {get; set;}
       public String Diagnostico {get; set;}
       public  String Tratamiento {get; set;}
       public DateTime FechaRevision {get; set;} 
    }    
}