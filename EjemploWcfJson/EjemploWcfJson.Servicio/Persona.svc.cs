using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades = EjemploWcfJSon.Entidades;

namespace EjemploWcfJson.Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Persona" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Persona.svc or Persona.svc.cs at the Solution Explorer and start debugging.
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class Persona : IPersona
    {
        public List<Entidades.Persona> ConsultarPersonas()
        {
            List<Entidades.Persona> personas = new List<Entidades.Persona>();

            personas.Add(new Entidades.Persona() { IdPersona = 1, Nombre = "Hernan", Direccion = "Carrera 50", Edad = "26" });
            personas.Add(new Entidades.Persona() { IdPersona = 1, Nombre = "Jose", Direccion = "Calle 70", Edad = "54" });
            personas.Add(new Entidades.Persona() { IdPersona = 1, Nombre = "Jaime", Direccion = "Carrera 7", Edad = "13" });
            personas.Add(new Entidades.Persona() { IdPersona = 1, Nombre = "Alejandro", Direccion = "Calle 30", Edad = "29" });
            personas.Add(new Entidades.Persona() { IdPersona = 1, Nombre = "Cesar", Direccion = "Carrera 10", Edad = "35" });

            return personas;
        }        
    }
}
