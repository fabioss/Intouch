namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Resultado-Consumidor", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough]
    public class ResultadoConsumidor
    {
        private PessoaFisica consumidorpessoafisicaField;
        private PessoaJuridica consumidorpessoajuridicaField;

        [XmlElement("consumidor-pessoa-fisica", Form=XmlSchemaForm.Unqualified)]
        public PessoaFisica consumidorpessoafisica
        {
            get
            {
                return this.consumidorpessoafisicaField;
            }
            set
            {
                this.consumidorpessoafisicaField = value;
            }
        }

        [XmlElement("consumidor-pessoa-juridica", Form=XmlSchemaForm.Unqualified)]
        public PessoaJuridica consumidorpessoajuridica
        {
            get
            {
                return this.consumidorpessoajuridicaField;
            }
            set
            {
                this.consumidorpessoajuridicaField = value;
            }
        }
    }
}

