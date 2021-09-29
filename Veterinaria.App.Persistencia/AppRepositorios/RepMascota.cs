using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepMascota : IRepoMascotas{

        private readonly AppContext appContext;  

        public RepMascota(AppContext appContextParam){
            this.appContext = appContextParam;
        }
        // CRUD

        EntidadMascota IRepoMascotas.AgregarMascota(EntidadMascota mascota) {
            var mascotaAgregado = this.appContext.Mascotas.Add(mascota);
            this.appContext.SaveChanges();
            return mascotaAgregado.Entity;
        }
        
        EntidadMascota IRepoMascotas.EditarMascota(EntidadMascota mascotaNuevo) {

            var mascotaEncontrado = this.appContext.Mascotas.FirstOrDefault( p => p.IdMascota == mascotaNuevo.IdMascota); 
            if(mascotaEncontrado != null){
                mascotaEncontrado.Nombre = mascotaNuevo.NombreMascota;
                mascotaEncontrado.Raza = mascotaNuevo.Raza;
                mascotaEncontrado.Edad = mascotaNuevo.EdadMascota;
                mascotaEncontrado.FechaNacimiento = mascotaNuevo.FechaNacimiento;
                this.appContext.SaveChanges();  
                return mascotaEncontrado;              
            } else {
                return null;
            }          
        }

         EntidadMascota IRepoMascotas.GetMascota(int idMascota) {
            return this.appContext.Mascotas.FirstOrDefault( p => p.IdMascota == idMascota);           
        }

        void IRepoMascotas.EliminarMascota(int idMascota) {
           var mascotaEncontrado = this.appContext.Mascotas.FirstOrDefault( p => p.IdMascota == idMascota); 

            if(mascotaEncontrado != null) {
                this.appContext.Mascotas.Remove(mascotaEncontrado);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadMascota> IRepoMascotas.GetMascotas(){
            return null;
        }
    }
}