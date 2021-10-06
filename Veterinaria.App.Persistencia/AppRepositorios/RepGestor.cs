using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepGestor : IRepoGestor{

        private readonly AppContext appContext;  

        public RepGestor(AppContext appContextParam){
            this.appContext = appContextParam;
        }
        // CRUD

        EntidadGestor IRepoGestor.AgregarGestor(EntidadGestor gestor) {
            var gestorAgregado = this.appContext.Gestor.Add(gestor);
            this.appContext.SaveChanges();
            return gestorAgregado.Entity;
        }
        
        EntidadGestor IRepoGestor.EditarGestor(EntidadGestor gestorNuevo) {

            var gestorEncontrado = this.appContext.Gestor.FirstOrDefault( p => p.IdGestor == gestorNuevo.IdGestor); 
            if(gestorEncontrado != null){
                gestorEncontrado.Cargo = gestorNuevo.Cargo;
                gestorEncontrado.Salario = gestorNuevo.Salario;
                this.appContext.SaveChanges();  
                return gestorEncontrado;              
            } else {
                return null;
            }          
        }

         EntidadGestor IRepoGestor.GetGestor(int idGestor) {
            return this.appContext.Gestor.FirstOrDefault( p => p.IdGestor == idGestor);           
        }

        void IRepoGestor.EliminarGestor(int idGestor) {
           var gestorEncontrado = this.appContext.Gestor.FirstOrDefault( p => p.IdGestor == idGestor); 

            if(gestorEncontrado != null) {
                this.appContext.Gestor.Remove(gestorEncontrado);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadGestor> IRepoGestor.GetGestores(){
            return null;
        }
    }
}