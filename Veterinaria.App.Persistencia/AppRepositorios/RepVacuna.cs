using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepVacuna : IRepoVacunas{

        private readonly AppContext appContext;  

        public RepVacuna(AppContext appContextParam){
            this.appContext = appContextParam;
        }
        // CRUD

        EntidadVacunas IRepoVacunas.AgregarVacuna(EntidadVacunas vacuna) {
            var vacunaAgregada = this.appContext.Vacunas.Add(vacuna);
            this.appContext.SaveChanges();
            return vacunaAgregada.Entity;
        }
        
        EntidadVacunas IRepoVacunas.EditarVacuna(EntidadVacunas vacunaNuevo) {

            var vacunaEncontrada = this.appContext.Vacunas.FirstOrDefault( p => p.IdVacuna == vacunaNuevo.IdVacuna); 
            if(vacunaEncontrada != null){
                vacunaEncontrada.Tipo = vacunaNuevo.Tipo;
                vacunaEncontrada.Marca = vacunaNuevo.Marca;
                vacunaEncontrada.FechaVencimiento = vacunaNuevo.FechaVencimiento;
                this.appContext.SaveChanges();  
                return vacunaEncontrada;              
            } else {
                return null;
            }          
        }

         EntidadVacunas IRepoVacunas.GetVacuna(int idVacuna) {
            return this.appContext.Vacunas.FirstOrDefault( p => p.IdVacuna == idVacuna);           
        }

        void IRepoVacunas.EliminarVacunas(int idVacuna) {
           var vacunaEncontrada = this.appContext.Vacunas.FirstOrDefault( p => p.IdVacuna == idVacuna); 

            if(vacunaEncontrada != null) {
                this.appContext.Vacunas.Remove(vacunaEncontrada);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadVacunas> IRepoVacunas.GetVacunas(){
            return null;
        }
    }
}