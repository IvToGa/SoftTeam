using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepoVacunas{

        EntidadVacunas AgregarVacuna(EntidadVacunas vacuna);
        EntidadVacunas EditarVacuna(EntidadVacunas vacuna);
        EntidadVacunas GetVacuna(int idVacuna);
        void EliminarVacunas(int idVacuna);
        IEnumerable <EntidadVacunas> GetVacunas();
    }
}