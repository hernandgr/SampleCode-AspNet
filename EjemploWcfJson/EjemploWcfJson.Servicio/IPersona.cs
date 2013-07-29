using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades = EjemploWcfJSon.Entidades;

namespace EjemploWcfJson.Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPersona" in both code and config file together.
    [ServiceContract]
    public interface IPersona
    {
        [OperationContract]
        [WebGet(UriTemplate = "ConsultarPersonas", 
                RequestFormat = WebMessageFormat.Json, 
                ResponseFormat = WebMessageFormat.Json)]
        List<Entidades.Persona> ConsultarPersonas();
    }
}
