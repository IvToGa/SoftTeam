using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Consola
    {
        
        private static IRepoVeterinario repVeterinario = new RepVeterinario(new Persistencia.AppContext());
        private static IRepoVacunas repVacuna = new RepVacuna(new Persistencia.AppContext());
        private static IRepoPersonas repPersona = new RepPersona(new Persistencia.AppContext());
        private static IRepoMascotas repMascota = new RepMascota(new Persistencia.AppContext());
        private static IRepoGestor repGestor = new RepGestor(new Persistencia.AppContext());
        private static IRepoHistoriaClinica repHistoriaClinica = new RepHistoriaClinica(new Persistencia.AppContext());
        private static IRepoCuidadores repCuidador = new RepCuidador(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutado...");

            // AgregarHistoriaClinica();
            // EditarHistoriaClinica(1);
            // EliminarHistoriaClinica(1);
            // BuscarHistoriaClinica(1);

            // AgregarMascota();
            // EditarMascota(1);
            // EliminarMascota(7);
            // BuscarMascota(1);

            // AgregarVeterinario();
            // EditarVeterinario(2);
            // EliminarVeterinario(1);
            // BuscarVeterinario(1);

            // AgregarVacuna();
            // EditarVacuna(2);
            // EliminarVacunas(1);
            // BuscarVacuna(1);

            // AgregarCuidador();
            // EditarPersona(2);
            // EliminarPersona(4);
            // BuscarPersona(2);

            // AgregarGestor();
            // EditarGestor(8);
            // EliminarGestor(8);
            // BuscarGestor(8);
        }

        //CUIDADOR

        private static void AgregarCuidador(){

            EntidadCuidador Cuidador = new EntidadCuidador {
                CantidadMascotas = 3,
            };

            repCuidador.AgregarCuidador(Cuidador);
        }

        private static void EditarCuidador(int idCuidador){

            EntidadCuidador Cuidador = new EntidadCuidador {
                IdCuidador = idCuidador,
                CantidadMascotas = 2,
            };

            repCuidador.EditarCuidador(Cuidador);

        }

        private static void BuscarCuidador(int idCuidador) {

           var CuidadorEncontrado = repCuidador.GetCuidador(idCuidador);
           Console.WriteLine("El nombre del Cuidador es: " + CuidadorEncontrado.IdCuidador);
        }

        private static void EliminarCuidador(int idCuidador) {
            repCuidador.EliminarCuidador(idCuidador);
        }

        //HISTORIA CLINICA

        private static void AgregarHistoriaClinica(){

            EntidadHistoriaClinica HistoriaClinica = new EntidadHistoriaClinica {
                Diagnostico = "Fiebre",
                Tratamiento = "Pastitas para la fiebre",
                FechaRevision = new DateTime(2021, 09, 21),
            };

            repHistoriaClinica.AgregarHistoriaClinica(HistoriaClinica);
        }

        private static void EditarHistoriaClinica(int idHistoriaClinica){

            EntidadHistoriaClinica HistoriaClinica = new EntidadHistoriaClinica {
                IdHC = idHistoriaClinica,
                Diagnostico = "En buen estado",
                Tratamiento = "No necesario",
                FechaRevision = new DateTime(2021, 09, 25),
            };

            repHistoriaClinica.EditarHistoriaClinica(HistoriaClinica);

        }

        private static void BuscarHistoriaClinica(int idHistoriaClinica) {

           var HistoriaClinicaEncontrado = repHistoriaClinica.GetHistoriaClinica(idHistoriaClinica);
           Console.WriteLine("El nombre del HistoriaClinica es: " + HistoriaClinicaEncontrado.IdHC);
        }

        private static void EliminarHistoriaClinica(int idHistoriaClinica) {
            repHistoriaClinica.EliminarHistoriaClinica(idHistoriaClinica);
        }

        //CRUD GESTOR

        private static void AgregarGestor(){

            EntidadGestor Gestor = new EntidadGestor {
                Cargo = "Gestor",
                Salario = "10.000.000",
            };

            repGestor.AgregarGestor(Gestor);
        }

        private static void EditarGestor(int idGestor){

            EntidadGestor Gestor = new EntidadGestor {
                IdGestor = idGestor,
                Cargo = "Gestor",
                Salario = "5.000.000",
            };

            repGestor.EditarGestor(Gestor);

        }

        private static void BuscarGestor(int idGestor) {

           var GestorEncontrado = repGestor.GetGestor(idGestor);
           Console.WriteLine("El nombre del Gestor es: " + GestorEncontrado.IdGestor);
        }

        private static void EliminarGestor(int idGestor) {
            repGestor.EliminarGestor(idGestor);
        }

        //CRUD MASCOTAS

        private static void AgregarMascota(){

            EntidadMascota Mascota = new EntidadMascota {
                IdCuidador = 1,           
                NombreMascota = "Pelusa",
                Raza = "Gato",
                EdadMascota = 5,
                FechaNacimiento = new DateTime(2021, 09, 22),
            };

            repMascota.AgregarMascota(Mascota);
        }

        private static void EditarMascota(int idMascota){

            EntidadMascota Mascota = new EntidadMascota {
                IdMascota = idMascota,
                NombreMascota = "Pelusa",
                Raza = "Gato",
                EdadMascota = 6,
                FechaNacimiento = new DateTime(2021, 09, 25),
            };

            repMascota.EditarMascota(Mascota);

        }

        private static void BuscarMascota(int idMascota) {

           var MascotaEncontrado = repMascota.GetMascota(idMascota);
           Console.WriteLine("El nombre del Mascota es: " + MascotaEncontrado.NombreMascota);
        }

        private static void EliminarMascota(int idMascota) {
            repMascota.EliminarMascota(idMascota);
        }

        //CRUD VACUNAS

        private static void AgregarVacuna(){

            EntidadVacunas Vacuna = new EntidadVacunas {
                Tipo = "12356789",
                Marca = "virus",
                FechaVencimiento = new DateTime(2021, 09, 20),
            };

            repVacuna.AgregarVacuna(Vacuna);
        }

        private static void EditarVacuna(int idVacuna){

            EntidadVacunas Vacuna = new EntidadVacunas {
                Tipo = "12356789",
                Marca = "Antivirus",
                FechaVencimiento = new DateTime(2021, 09, 21),
            };

            repVacuna.EditarVacuna(Vacuna);

        }

        private static void BuscarVacuna(int idVacuna) {

           var VacunaEncontrado = repVacuna.GetVacuna(idVacuna);
           Console.WriteLine("El nombre de la Vacuna es: " + VacunaEncontrado.Tipo);
        }

        private static void EliminarVacunas(int idVacuna) {
            repVacuna.EliminarVacunas(idVacuna);
        }

        //CRUD VETERINARIOS

        private static void AgregarVeterinario(){

            EntidadVeterinario veterinario = new EntidadVeterinario {
                Especializacion = "Veterinario",
                TarjetaProfesional = "ing123"
            };

            repVeterinario.AgregarVeterinario(veterinario);
        }

        private static void EditarVeterinario(int idVeterinario){

            EntidadVeterinario veterinario = new EntidadVeterinario {
                IdVeterinario = idVeterinario,
                Especializacion = "Veterinario Cirujano",
                TarjetaProfesional = "ing123"
            };

            repVeterinario.EditarVeterinario(veterinario);

        }

        private static void BuscarVeterinario(int idVeterinario) {

           var veterinarioEncontrado = repVeterinario.GetVeterinario(idVeterinario);
           Console.WriteLine("El nombre del veterinario es: " + veterinarioEncontrado.IdVeterinario);
        }

        private static void EliminarVeterinario(int idVeterinario) {
            repVeterinario.EliminarVeterinario(idVeterinario);
        }        
    }
}
