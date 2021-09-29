using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepoHistoriaClinica{

        EntidadHistoriaClinica AgregarHistoriaClinica(EntidadHistoriaClinica historiaClinica);
        EntidadHistoriaClinica EditarHistoriaClinica(EntidadHistoriaClinica historiaClinica);
        EntidadHistoriaClinica GetHistoriaClinica(int idhistoriaClinica);
        void EliminarHistoriaClinica(int idhistoriaClinica);
        IEnumerable <EntidadHistoriaClinica> GetHistoriasClinicas();
    }
}