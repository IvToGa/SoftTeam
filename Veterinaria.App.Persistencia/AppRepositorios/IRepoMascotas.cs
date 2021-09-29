using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepoMascotas{

        EntidadMascota AgregarMascota(EntidadMascota mascota);
        EntidadMascota EditarMascota(EntidadMascota mascota);
        EntidadMascota GetMascota(int idmascota);
        void EliminarMascota(int ismascota);
        IEnumerable <EntidadMascota> GetMascotas();
    }
}