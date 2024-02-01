using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_personas
{
    class Persona
    {
        // campos y propiedades 
        //Privados para cumplir
        // El encapuslado

        String dpi;
        String nombre;
        String apellido;
        DateTime fechaNacimiento;

        //Encapsulado

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Dpi { get => dpi; set => dpi = value; }

        // Metodos: Acciones que realiza

        public Persona()
        {
            dpi = "";
            nombre = "";
            apellido = "";

            //Inicializar con la fecha de hoy

            fechaNacimiento = DateTime.Now;
        }


        public void PrimeraMayuscula()
        {
            if (nombre.Length > 0)
            {
                StringBuilder nombreMayuscula = new StringBuilder(nombre);
                nombreMayuscula[0] = char.ToUpper(nombreMayuscula[0]);
                // PUNTO TO TRIM PARA QUITAR UN ESPACIO  EN BLANCO
                nombre = nombreMayuscula.ToString().Trim(); ;
            }

            if (apellido.Length > 0)
            {
                StringBuilder apellidoMayuscula = new StringBuilder(apellido);
                apellidoMayuscula[0] = char.ToUpper(apellidoMayuscula[0]);
                apellido = apellidoMayuscula.ToString().Trim(); ;
            }
        }


        public int edad()
        {
            int anionac = fechaNacimiento.Year;
            int aniott = fechaNacimiento.Year;
            int mesnac = fechaNacimiento.Month;
         


            if (mesnac > 1)
            {
                aniott = anionac+ 1;

            }


            int edadt = 2024 - aniott;


            return edadt;

        }

        public void normalizarNombre()
        {

          //  char.IsWhiteSpace

        }
            

    }

    

    



}
