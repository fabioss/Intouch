namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Atividade-Empresa", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code")]
    public class InsumoAtividadeEmpresa
    {
        private RamoAtividade[] atividadeseconomicassecundariasField;
        private string numerocnaeField;
        private double percentualcompraField;
        private bool percentualcompraFieldSpecified;
        private double percentualvendasField;
        private bool percentualvendasFieldSpecified;
        private int quantidadeempregadosField;
        private bool quantidadeempregadosFieldSpecified;
        private int quantidadefiliaisField;
        private bool quantidadefiliaisFieldSpecified;
        private RamoAtividade ramoatividadeField;

        [XmlElement("atividades-economicas-secundarias", Form=XmlSchemaForm.Unqualified)]
        public RamoAtividade[] atividadeseconomicassecundarias
        {
            get
            {
                return this.atividadeseconomicassecundariasField;
            }
            set
            {
                this.atividadeseconomicassecundariasField = value;
            }
        }

        [XmlAttribute("numero-cnae")]
        public string numerocnae
        {
            get
            {
                return this.numerocnaeField;
            }
            set
            {
                this.numerocnaeField = value;
            }
        }

        [XmlAttribute("percentual-compra")]
        public double percentualcompra
        {
            get
            {
                return this.percentualcompraField;
            }
            set
            {
                this.percentualcompraField = value;
            }
        }

        [XmlIgnore]
        public bool percentualcompraSpecified
        {
            get
            {
                return this.percentualcompraFieldSpecified;
            }
            set
            {
                this.percentualcompraFieldSpecified = value;
            }
        }

        [XmlAttribute("percentual-vendas")]
        public double percentualvendas
        {
            get
            {
                return this.percentualvendasField;
            }
            set
            {
                this.percentualvendasField = value;
            }
        }

        [XmlIgnore]
        public bool percentualvendasSpecified
        {
            get
            {
                return this.percentualvendasFieldSpecified;
            }
            set
            {
                this.percentualvendasFieldSpecified = value;
            }
        }

        [XmlAttribute("quantidade-empregados")]
        public int quantidadeempregados
        {
            get
            {
                return this.quantidadeempregadosField;
            }
            set
            {
                this.quantidadeempregadosField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadeempregadosSpecified
        {
            get
            {
                return this.quantidadeempregadosFieldSpecified;
            }
            set
            {
                this.quantidadeempregadosFieldSpecified = value;
            }
        }

        [XmlAttribute("quantidade-filiais")]
        public int quantidadefiliais
        {
            get
            {
                return this.quantidadefiliaisField;
            }
            set
            {
                this.quantidadefiliaisField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadefiliaisSpecified
        {
            get
            {
                return this.quantidadefiliaisFieldSpecified;
            }
            set
            {
                this.quantidadefiliaisFieldSpecified = value;
            }
        }

        [XmlElement("ramo-atividade", Form=XmlSchemaForm.Unqualified)]
        public RamoAtividade ramoatividade
        {
            get
            {
                return this.ramoatividadeField;
            }
            set
            {
                this.ramoatividadeField = value;
            }
        }
    }
}

