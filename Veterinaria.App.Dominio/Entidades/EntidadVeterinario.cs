using System;

namespace Veterinaria.App.Dominio
{
    public class EntidadVeterinario {
        public int Id {get; set;}
        public int IdPersona {get; set;}
        public int IdVeterinario {get; set;}
        public String Especializacion {get; set;}
        public String TarjetaProfesional {get; set;}
        public String Salario  {get; set;}
    }
    
}