using System;

namespace Veterinaria.App.Dominio
{

    public class EntidadVeterinario: EntidadPersona {
        public int Id {get; set;}
        public String Especializacion {get; set;}
        public String TarjetaProfesional {get; set;}
        public String Salario  {get; set;}
    }
    
}