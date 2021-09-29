using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepoGestor{

        EntidadGestor AgregarGestor(EntidadGestor gestor);
        EntidadGestor EditarGestor(EntidadGestor gestor);
        EntidadGestor GetGestor(int idgestor);
        void EliminarGestor(int idgestor);
        IEnumerable <EntidadGestor> GetGestores();
    }
}