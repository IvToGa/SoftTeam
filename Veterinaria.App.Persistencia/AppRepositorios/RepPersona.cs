using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepPersona : IRepoPersonas{

        private readonly AppContext appContext;  

        public RepPersona(AppContext appContextParam){
            this.appContext = appContextParam;
        }
        // CRUD

        EntidadPersona IRepoPersonas.AgregarPersona(EntidadPersona persona) {
            var personaAgregado = this.appContext.Personas.Add(persona);
            this.appContext.SaveChanges();
            return personaAgregado.Entity;
        }
        
        EntidadPersona IRepoPersonas.EditarPersona(EntidadPersona personaNuevo) {

            var personaEncontrado = this.appContext.Personas.FirstOrDefault( p => p.IdPersona == personaNuevo.IdPersona); 
            if(personaEncontrado != null){
                personaEncontrado.Cedula = personaNuevo.Cedula;
                personaEncontrado.Nombre = personaNuevo.Nombre;
                personaEncontrado.Telefono = personaNuevo.Telefono;
                personaEncontrado.Edad = personaNuevo.Edad;
                personaEncontrado.Correo = personaNuevo.Correo;
                personaEncontrado.Clave = personaNuevo.Clave;
                personaEncontrado.FechaRegistro = personaNuevo.FechaRegistro;
                this.appContext.SaveChanges();  
                return personaEncontrado;              
            } else {
                return null;
            }          
        }

         EntidadPersona IRepoPersonas.GetPersona(int idPersona) {
            return this.appContext.Personas.FirstOrDefault( p => p.IdPersona == idPersona);           
        }

        void IRepoPersonas.EliminarPersona(int idPersona) {
           var personaEncontrado = this.appContext.Personas.FirstOrDefault( p => p.IdPersona == idPersona); 

            if(personaEncontrado != null) {
                this.appContext.Personas.Remove(personaEncontrado);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadPersona> IRepoPersonas.GetPersonas(){
            return null;
        }
    }
}