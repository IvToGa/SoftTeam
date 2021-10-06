using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepHistoriaClinica : IRepoHistoriaClinica{

        private readonly AppContext appContext;  

        public RepHistoriaClinica(AppContext appContextParam){
            this.appContext = appContextParam;
        }
        // CRUD

        EntidadHistoriaClinica IRepoHistoriaClinica.AgregarHistoriaClinica(EntidadHistoriaClinica historiaClinica) {
            var historiaClinicaAgregado = this.appContext.HistoriasClinicas.Add(historiaClinica);
            this.appContext.SaveChanges();
            return historiaClinicaAgregado.Entity;
        }
        
        EntidadHistoriaClinica IRepoHistoriaClinica.EditarHistoriaClinica(EntidadHistoriaClinica historiaClinicaNuevo) {

            var historiaClinicaEncontrado = this.appContext.HistoriasClinicas.FirstOrDefault( p => p.IdHC == historiaClinicaNuevo.IdHC); 
            if(historiaClinicaEncontrado != null){
                historiaClinicaEncontrado.Diagnostico = historiaClinicaNuevo.Diagnostico;
                historiaClinicaEncontrado.Tratamiento = historiaClinicaNuevo.Tratamiento;
                historiaClinicaEncontrado.FechaRevision = historiaClinicaNuevo.FechaRevision;
                this.appContext.SaveChanges();  
                return historiaClinicaEncontrado;              
            } else {
                return null;
            }          
        }

         EntidadHistoriaClinica IRepoHistoriaClinica.GetHistoriaClinica(int idHistoriaClinica) {
            return this.appContext.HistoriasClinicas.FirstOrDefault( p => p.IdHC == idHistoriaClinica);           
        }

        void IRepoHistoriaClinica.EliminarHistoriaClinica(int idHistoriaClinica) {
           var historiaClinicaEncontrado = this.appContext.HistoriasClinicas.FirstOrDefault( p => p.IdHC == idHistoriaClinica); 

            if(historiaClinicaEncontrado != null) {
                this.appContext.HistoriasClinicas.Remove(historiaClinicaEncontrado);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadHistoriaClinica> IRepoHistoriaClinica.GetHistoriasClinicas(){
            return null;
        }
    }
}