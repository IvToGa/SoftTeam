using System;

namespace Veterinaria.App.Dominio
{
    public class EntidadGestor: EntidadPersona {
       public int Id {get; set;}
       public  String Cargo  {get; set;}
       public String Salario  {get; set;}
    }    
}