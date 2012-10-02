namespace Intouch.SPC
{
    using Intouch.My;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Web.Services;
    using System.Web.Services.Description;
    using System.Web.Services.Protocols;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [WebServiceBinding(Name="consultaWebServicePortBinding", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.4927")]
    public class consultaWebService : SoapHttpClientProtocol
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private SendOrPostCallback consultarOperationCompleted;
        private SendOrPostCallback detalharProdutoOperationCompleted;
        private SendOrPostCallback listarProdutosOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event consultarCompletedEventHandler consultarCompleted;

        public event detalharProdutoCompletedEventHandler detalharProdutoCompleted;

        public event listarProdutosCompletedEventHandler listarProdutosCompleted;

        public consultaWebService()
        {
            List<WeakReference> firstXPTO = __ENCList;
            lock (firstXPTO)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.Url = MySettings.Default.Intouch_SPC_consultaWebService;
            if (this.IsLocalFileSystemWebService(this.Url))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        public void CancelAsync(object userState)
        {
            base.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlElement("resultado", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/", IsNullable=true)]
        [SoapDocumentMethod("", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Bare)]
        public ResultadoConsulta consultar([XmlElement(Namespace="http://webservice.consulta.spcjava.spcbrasil.org/", IsNullable=true)] FiltroConsulta filtro)
        {
            return (ResultadoConsulta) this.Invoke("consultar", new object[] { filtro })[0];
        }

        public void consultarAsync(FiltroConsulta filtro)
        {
            this.consultarAsync(filtro, null);
        }

        public void consultarAsync(FiltroConsulta filtro, object userState)
        {
            if (this.consultarOperationCompleted == null)
            {
                this.consultarOperationCompleted = new SendOrPostCallback(this.OnconsultarOperationCompleted);
            }
            this.InvokeAsync("consultar", new object[] { filtro }, this.consultarOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        [return: XmlElement("produto", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/", IsNullable=true)]
        [SoapDocumentMethod("", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Bare)]
        public Produto detalharProduto([XmlElement("codigo-produto", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/", IsNullable=true)] string codigoproduto)
        {
            return (Produto) this.Invoke("detalharProduto", new object[] { codigoproduto })[0];
        }

        public void detalharProdutoAsync(string codigoproduto)
        {
            this.detalharProdutoAsync(codigoproduto, null);
        }

        public void detalharProdutoAsync(string codigoproduto, object userState)
        {
            if (this.detalharProdutoOperationCompleted == null)
            {
                //this.detalharProdutoOperationCompleted = new SendOrPostCallback(this.OndetalharProdutoOperationCompleted);
            }
            this.InvokeAsync("detalharProduto", new object[] { codigoproduto }, this.detalharProdutoOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if ((url == null) || (url == string.Empty))
            {
                return false;
            }
            Uri wsUri = new Uri(url);
            return ((wsUri.Port >= 0x400) && (string.Compare(wsUri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0));
        }

        [return: XmlArrayItem("produto", Form=XmlSchemaForm.Unqualified, IsNullable=false), XmlArray("produtos", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/", IsNullable=true)]
        [SoapDocumentMethod("", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Bare)]
        public Produto[] listarProdutos()
        {
            return (Produto[]) this.Invoke("listarProdutos", new object[0])[0];
        }

        public void listarProdutosAsync()
        {
            this.listarProdutosAsync(null);
        }

        public void listarProdutosAsync(object userState)
        {
            if (this.listarProdutosOperationCompleted == null)
            {
                this.listarProdutosOperationCompleted = new SendOrPostCallback(this.OnlistarProdutosOperationCompleted);
            }
            this.InvokeAsync("listarProdutos", new object[0], this.listarProdutosOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
        }

        private void OnconsultarOperationCompleted(object arg)
        {
            //if (this.consultarCompletedEvent != null)
            //{
            //    InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)arg;
            //    consultarCompletedEventHandler consultarXPTO = this.consultarCompletedEvent;
            //    if (consultarXPTO != null)
            //    {
            //        consultarXPTO(this, new consultarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
            //    }
            //}
        }

        private void OndetalharProdutoOperationCompleted(object arg)
        {
            //if (this.detalharProdutoCompletedEvent != null)
            //{
            //    InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)arg;
            //    detalharProdutoCompletedEventHandler detalharXPTO = this.detalharProdutoCompletedEvent;
            //    if (detalharXPTO != null)
            //    {
            //        detalharXPTO(this, new detalharProdutoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
            //    }
            //}
        }

        private void OnlistarProdutosOperationCompleted(object arg)
        {
            //if (this.listarProdutosCompletedEvent != null)
            //{
            //    InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)arg;
            //    listarProdutosCompletedEventHandler listarXPTO = this.listarProdutosCompletedEvent;
            //    if (listarXPTO != null)
            //    {
            //        listarXPTO(this, new listarProdutosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, RuntimeHelpers.GetObjectValue(invokeArgs.UserState)));
            //    }
            //}
        }

        public string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly) && !this.IsLocalFileSystemWebService(value))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
    }
}

