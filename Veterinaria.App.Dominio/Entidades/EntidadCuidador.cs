using System;

namespace Veterinaria.App.Dominio
{
    public class EntidadCuidador {
       public int Id {get; set;}
       public int IdPersona {get; set;}
       public int IdCuidador {get; set;}
       public int CantidadMascotas {get; set;}
    }    
}