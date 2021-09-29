using System;

namespace Veterinaria.App.Dominio
{
    public class EntidadPersona {
       public int IdPersona {get; set;}
       public String Cedula {get; set;}
       public String Nombre  {get; set;}
       public String Telefono  {get; set;}
       public int Edad  {get; set;}     
       public String Correo {get; set;}
       public String Clave {get; set;}
       public DateTime FechaRegistro  {get; set;} 
    }    
}