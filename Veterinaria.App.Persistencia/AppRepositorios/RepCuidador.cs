using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepCuidador : IRepoCuidadores{

        private readonly AppContext appContext;  

        public RepCuidador(AppContext appContextParam){
            this.appContext = appContextParam;
        }
        // CRUD

        EntidadCuidador IRepoCuidadores.AgregarCuidador(EntidadCuidador Cuidador) {
            var CuidadorAgregado = this.appContext.Cuidadores.Add(Cuidador);
            this.appContext.SaveChanges();
            return CuidadorAgregado.Entity;
        }
        
        EntidadCuidador IRepoCuidadores.EditarCuidador(EntidadCuidador CuidadorNuevo) {

            var CuidadorEncontrado = this.appContext.Cuidadores.FirstOrDefault( p => p.IdCuidador == CuidadorNuevo.IdCuidador); 
            if(CuidadorEncontrado != null){
                CuidadorEncontrado.CantidadMascotas = CuidadorNuevo.CantidadMascotas;
                this.appContext.SaveChanges();  
                return CuidadorEncontrado;              
            } else {
                return null;
            }          
        }

         EntidadCuidador IRepoCuidadores.GetCuidador(int idCuidador) {
            return this.appContext.Cuidadores.FirstOrDefault( p => p.IdCuidador == idCuidador);           
        }

        void IRepoCuidadores.EliminarCuidador(int idCuidador) {
           var CuidadorEncontrado = this.appContext.Cuidadores.FirstOrDefault( p => p.IdCuidador == idCuidador); 

            if(CuidadorEncontrado != null) {
                this.appContext.Cuidadores.Remove(CuidadorEncontrado);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadCuidador> IRepoCuidadores.GetCuidadores(){
            return null;
        }
    }
}