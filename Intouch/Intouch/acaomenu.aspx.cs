namespace Intouch
{
    using DllPainelDeControle;
    using DLLUnitShop;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;

    public partial class acaomenu : Page
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("form1")]
        private HtmlForm _form1;

        [DebuggerNonUserCode]
        public acaomenu()
        {
            base.Load += new EventHandler(this.Page_Load);
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                __ENCList.Add(new WeakReference(this));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack && (this.Request.QueryString["acao"] == "cc"))
            {
                DLLUnitShop.Cliente cliente = new DLLUnitShop.Cliente();
                string queryString = string.Empty;
                queryString = cliente.Gerar_QueryString((long)((Acesso)this.Session["DADOS_ACESSO"]).Cliente, (long)((Acesso)this.Session["DADOS_ACESSO"]).Login, true, 0L, (long)Convert.ToInt32(1), ((Acesso)this.Session["DADOS_ACESSO"]).Usuario.DsLogin, ((Acesso)this.Session["DADOS_ACESSO"]).Usuario.DsSenha, ((Acesso)this.Session["DADOS_ACESSO"]).NomeCliente);
                cliente.Dispose();
                this.Response.Redirect(ConfigurationManager.AppSettings["ENDERECO_UNITSHOP"] + "?" + queryString);
            }
        }

        protected virtual HtmlForm form1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._form1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._form1 = value;
            }
        }
    }
}

