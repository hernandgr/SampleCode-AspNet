using System.Runtime.Serialization;

namespace EjemploWcfJSon.Entidades
{
    [DataContract]
    public class Persona
    {
        [DataMember]
        public int IdPersona { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Direccion { get; set; }

        [DataMember]
        public string Edad { get; set; }
    }
}
