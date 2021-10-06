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

            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault( p => p.IdVeterinario == veterinarioNuevo.IdVeterinario); 
            if(veterinarioEncontrado != null){
                veterinarioEncontrado.Especializacion = veterinarioNuevo.Especializacion;
                veterinarioEncontrado.TarjetaProfesional = veterinarioNuevo.TarjetaProfesional;
                veterinarioEncontrado.Salario = veterinarioNuevo.Salario;
                this.appContext.SaveChanges();  
                return veterinarioEncontrado;              
            } else {
                return null;
            }          
        }

         EntidadVeterinario IRepoVeterinario.GetVeterinario(int idVeterinario) {
            return this.appContext.Veterinarios.FirstOrDefault( p => p.IdVeterinario == idVeterinario);           
        }

        void IRepoVeterinario.EliminarVeterinario(int idVeterinario) {
           var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault( p => p.IdVeterinario == idVeterinario); 

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