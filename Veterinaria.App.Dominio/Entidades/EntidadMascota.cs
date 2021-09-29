using System;

namespace Veterinaria.App.Dominio
{
    public class EntidadMascota: EntidadCuidador {
       public int IdMascota {get; set;}
       public int IdCuidador {get; set;}
       public String NombreMascota  {get; set;}
       public String Raza  {get; set;}
       public int EdadMascota  {get; set;}     
       public DateTime FechaNacimiento  {get; set;} 
    }    
}