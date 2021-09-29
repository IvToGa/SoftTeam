using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepVeterinario : IRepoVeterinario{

        private readonly AppContext appContext;  

        public RepVeterinario(AppContext appContextParam){
            this.appContext = appContextParam;
        }
        // CRUD

        EntidadVeterinario IRepoVeterinario.AgregarVeterinario(EntidadVeterinario veterinario) {
            var veterinarioAgregado = this.appContext.Veterinarios.Add(veterinario);
            this.appContext.SaveChanges();
            return veterinarioAgregado.Entity;
        }
        
        EntidadVeterinario IRepoVeterinario.EditarVeterinario(EntidadVeterinario veterinarioNuevo) {

            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault( p => p.Id == veterinarioNuevo.Id); 
            if(veterinarioEncontrado != null){
                veterinarioEncontrado.Nombre = veterinarioNuevo.Nombre;
                veterinarioEncontrado.Telefono = veterinarioNuevo.Telefono;
                veterinarioEncontrado.Edad = veterinarioNuevo.Edad;
                this.appContext.SaveChanges();  
                return veterinarioEncontrado;              
            } else {
                return null;
            }          
        }

         EntidadVeterinario IRepoVeterinario.GetVeterinario(int idVeterinario) {
            return this.appContext.Veterinarios.FirstOrDefault( p => p.Id == idVeterinario);           
        }

        void IRepoVeterinario.EliminarVeterinario(int idVeterinario) {
           var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault( p => p.Id == idVeterinario); 

            if(veterinarioEncontrado != null) {
                this.appContext.Veterinarios.Remove(veterinarioEncontrado);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadVeterinario> IRepoVeterinario.GetVeterinarios(){
            return null;
        }
    }
}