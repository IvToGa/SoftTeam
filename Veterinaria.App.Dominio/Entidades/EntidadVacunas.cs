using System;

namespace Veterinaria.App.Dominio
{
    public class EntidadVacunas {
       public int Id {get; set;}
       public int IdMascota {get; set;}
       public int IdVacuna {get; set;}
       public  String Tipo  {get; set;}
       public String Marca  {get; set;}
       public DateTime FechaVencimiento  {get; set;} 
    }    
}