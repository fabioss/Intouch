namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Carta-Anuencia", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927")]
    public enum CartaAnuencia
    {
        CREDOR,
        CREDOR_ELETRONICA,
        DEVEDOR
    }
}

