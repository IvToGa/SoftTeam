using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepoPersonas{

        EntidadPersona AgregarPersona(EntidadPersona persona);
        EntidadPersona EditarPersona(EntidadPersona persona);
        EntidadPersona GetPersona(int idPersona);
        void EliminarPersona(int idPersona);
        IEnumerable <EntidadPersona> GetPersonas();
    }
}