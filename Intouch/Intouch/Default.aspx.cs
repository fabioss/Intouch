namespace Intouch
{
    using AjaxControlToolkit;
    using BIUnit4;
    using DllPainelDeControle;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Web;
    using System.Web.UI.WebControls;

    public partial class _Default : GlobalPage
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("btnLogins")]
        private Button _btnLogins;
        [AccessedThroughProperty("lblMsgs")]
        private Label _lblMsgs;
        [AccessedThroughProperty("ToolkitScriptManagerDefault")]
        private ToolkitScriptManager _ToolkitScriptManagerDefault;
        [AccessedThroughProperty("txtClientes")]
        private TextBox _txtClientes;
        [AccessedThroughProperty("txtSenhas")]
        private TextBox _txtSenhas;
        [AccessedThroughProperty("txtUsuarios")]
        private TextBox _txtUsuarios;
        private DllPainelDeControle.Util util;

        public _Default()
        {
            base.Load += new EventHandler(this.Page_Load);
            List<WeakReference> firstXPTO = __ENCList;
            lock (firstXPTO)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.util = new DllPainelDeControle.Util();
        }

        protected void AddUsuario()
        {
            string IPUsuario = this.Context.Request.UserHostAddress;
            if (this.Application["CONTADOR"] == null)
            {
                this.Application["CONTADOR"] = 1;
            }
            else
            {
                HttpApplicationState firstXPTO = this.Application;
                string strXPTO = "CONTADOR";
                firstXPTO[strXPTO] = Operators.AddObject(firstXPTO[strXPTO], 1);
            }
            this.Application.Add("LOGADO_" + this.Application["CONTADOR"].ToString(), new Logado(this._txtUsuarios.Text.ToUpper(), this._txtClientes.Text.ToUpper(), IPUsuario));
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Logar(this._txtUsuarios.Text, this._txtSenhas.Text, this._txtClientes.Text, "");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(this._txtClientes.Text, this._txtUsuarios.Text, "intouch", "acesso1.aspx", "btnLogin_Click", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        public void Logar(string login, string senha, string cliente, string cpfCampanha)
        {
            try
            {
                int idLogin = 0;
                string IPUsuario = this.Context.Request.UserHostAddress;
                string senhaUsuario = this.util.CriptografarSenha(senha);
                Acesso acesso = null;
                //if (!((IBIIntouch)this.Session["USUARIO"]).Consulta.AutorizadoParaConsultar(this._txtUsuario.Text.ToString(), this.Context.Request.UserHostAddress.ToString(), senhaUsuario.ToString(), cliente.ToString(), EnumProduto.Intouch, ref idLogin))
                //{
                //    this.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "alerta", "<script>alert('" + ((AbstractError) this.Session["BUSINESS_ERROR"]).Erro + "');</script>");
                //}
                //else
                //{
                    acesso = new Acesso(1, idLogin) {
                        Ip = IPUsuario
                    };
                    this.Session["ID_HISTORICO_LOGIN"] = ((IBIIntouch) this.Session["BUSINESS"]).HistoricoLogin.InserirHistoricoLogin(acesso.Usuario.Cliente.IdCliente, acesso.Login, IPUsuario);
                    this.Session["DADOS_ACESSO"] = acesso;
                    this.Session["USUARIO"] = acesso.Usuario;
                    this.Session["MENU"] = acesso.GetMenuAplicacao("Default.aspx", true, true, DllPainelDeControle.EnumProduto.Intouch);
                    this.Session["CPF_PARTICIPANTE_CAMPANHA"] = null;
                    this.Session["LINK_CAMPANHA"] = "http://65.182.106.164/AtualizeSuaSorte/CadastroDeUsuario.aspx?usuario=" + ((Acesso) this.Session["DADOS_ACESSO"]).Usuario.DsLogin + "&senha=" + ((Acesso) this.Session["DADOS_ACESSO"]).Usuario.DsSenha + "&cliente=" + ((Acesso) this.Session["DADOS_ACESSO"]).Usuario.Cliente.Nome + "";
                    this.Response.Redirect("Home.aspx", false);
                //}
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(cliente, login, "intouch", "acesso1.aspx", "Logar", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.txtUsuarios.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this.btnLogin.ClientID + "').click();return false;}} else {return true}; ");
                this.txtSenhas.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this.btnLogin.ClientID + "').click();return false;}} else {return true}; ");
                this.txtClientes.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this.btnLogin.ClientID + "').click();return false;}} else {return true}; ");
                ((Label) this.Master.FindControl("lblMsgGeral")).Text = new Produto().GetProduto(1).MsgGeral;
                IBIIntouch business = new BIIntouch();
                this.Session["BUSINESS"] = business;
                this.Session["BUSINESS_ERROR"] = (AbstractError) business.Consulta;
                if (this.Request.QueryString.Count == 3)
                {
                    this.txtUsuarios.Text = this.Request.QueryString["usuario"].ToString();
                    this.txtSenhas.Text = this.util.DecriptografarSenha(this.Request.QueryString["senha"].ToString().Replace(" ", "+"));
                    this.txtClientes.Text = this.Request.QueryString["cliente"].ToString();
                    this.Logar(this._txtUsuarios.Text, this._txtSenhas.Text, this._txtClientes.Text, "");
                }
                else if (this.Request.QueryString.Count == 4)
                {
                    this.txtUsuarios.Text = this.Request.QueryString["usuario"].ToString();
                    this.txtSenhas.Text = this.util.DecriptografarSenha(this.Request.QueryString["senha"].ToString().Replace(" ", "+"));
                    this.txtClientes.Text = this.Request.QueryString["cliente"].ToString();
                    this.Logar(this._txtUsuarios.Text, this._txtSenhas.Text, this._txtClientes.Text, this.Request.QueryString["cpfCampanha"]);
                }
            }
        }

        protected bool UsuarioLogado()
        {
            string IPUsuario = this.Context.Request.UserHostAddress;
            string[] arrayXPTO = this.Application.AllKeys;
            for (int i = 0; i < arrayXPTO.Length; i++)
            {
                object msg = arrayXPTO[i];
                if (Operators.ConditionalCompareObjectNotEqual(msg, "CONTADOR", false) && ((((Logado) NewLateBinding.LateGet(this.Application, null, "Item", new object[] { RuntimeHelpers.GetObjectValue(msg) }, null, null, null)).Usuario == this.txtUsuario.Text.ToUpper()) & (((Logado) NewLateBinding.LateGet(this.Application, null, "Item", new object[] { RuntimeHelpers.GetObjectValue(msg) }, null, null, null)).Cliente == this.txtCliente.Text.ToUpper())))
                {
                    this.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "alerta", "<script>alert('O Usu\x00e1rio com o IP " + ((Logado) NewLateBinding.LateGet(this.Application, null, "Item", new object[] { RuntimeHelpers.GetObjectValue(msg) }, null, null, null)).Ip + " est\x00e1 logado com esse Usu\x00e1rio/Senha. Entre em Contato com a equipe UNITFOUR!');</script>");
                    return true;
                }
            }
            this.AddUsuario();
            return false;
        }

        protected virtual Button btnLogin
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnLogins;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btnLogin_Click);
                if (this._btnLogins != null)
                {
                    this._btnLogins.Click -= handler;
                }
                this._btnLogins = value;
                if (this._btnLogins != null)
                {
                    this._btnLogins.Click += handler;
                }
            }
        }

        protected virtual Label lblMsg
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblMsgs;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblMsgs = value;
            }
        }

        protected virtual ToolkitScriptManager ToolkitScriptManager1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ToolkitScriptManagerDefault;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ToolkitScriptManagerDefault = value;
            }
        }

        protected virtual TextBox txtCliente
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtClientes;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtClientes = value;
            }
        }

        protected virtual TextBox txtSenha
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtSenhas;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtSenhas = value;
            }
        }

        protected virtual TextBox txtUsuario
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtUsuarios;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtUsuarios = value;
            }
        }
    }
}

