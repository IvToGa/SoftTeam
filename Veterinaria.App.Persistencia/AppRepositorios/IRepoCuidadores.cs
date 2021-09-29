using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepoCuidadores{

        EntidadCuidador AgregarCuidador(EntidadCuidador Cuidador);
        EntidadCuidador EditarCuidador(EntidadCuidador Cuidador);
        EntidadCuidador GetCuidador(int idCuidador);
        void EliminarCuidador(int idCuidador);
        IEnumerable <EntidadCuidador> GetCuidadores();
    }
}