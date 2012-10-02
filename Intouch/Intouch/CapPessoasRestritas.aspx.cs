namespace Intouch
{
    using AjaxControlToolkit;
    using BIUnit4;
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;

    public partial class CapPessoasRestritas : GlobalPage
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("btnhldMsgValidCadPessRestritas")]
        private HiddenField _btnhldMsgValidCadPessRestritas;
        [AccessedThroughProperty("btnInserirPessoaRestrita")]
        private ImageButton _btnInserirPessoaRestrita;
        [AccessedThroughProperty("formCapPessoasRestritas")]
        private HtmlForm _formCapPessoasRestritas;
        [AccessedThroughProperty("Head1")]
        private HtmlHead _Head1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label21")]
        private Label _Label21;
        [AccessedThroughProperty("Label23")]
        private Label _Label23;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("lblUF")]
        private Label _lblUF;
        [AccessedThroughProperty("lblMsgValidacao")]
        private Label _lblMsgValidacao;
        [AccessedThroughProperty("mpeMsgValidCadPessRestritas")]
        private ModalPopupExtender _mpeMsgValidCadPessRestritas;
        [AccessedThroughProperty("pnlCadPessRestritas")]
        private Panel _pnlCadPessRestritas;
        [AccessedThroughProperty("smCapPessoasRestritas")]
        private ToolkitScriptManager _smCapPessoasRestritas;
        [AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        [AccessedThroughProperty("txtCidade")]
        private TextBox _txtCidade;
        [AccessedThroughProperty("txtCpf")]
        private TextBox _txtCpf;
        [AccessedThroughProperty("txtDataNascimento")]
        private TextBox _txtDataNascimento;
        [AccessedThroughProperty("txtEstado")]
        private TextBox _txtEstado;
        [AccessedThroughProperty("txtIdade")]
        private TextBox _txtIdade;
        [AccessedThroughProperty("txtNome")]
        private TextBox _txtNome;
        [AccessedThroughProperty("txtNomeArtistico")]
        private TextBox _txtNomeArtistico;
        [AccessedThroughProperty("upCapPessoasRestritas")]
        private UpdatePanel _upCapPessoasRestritas;
        [AccessedThroughProperty("uptProgressCadPessRestritas")]
        private UpdateProgress _uptProgressCadPessRestritas;

        [DebuggerNonUserCode]
        public CapPessoasRestritas()
        {
            base.Load += new EventHandler(this.Page_Load);
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                __ENCList.Add(new WeakReference(this));
            }
        }

        protected void AbrirDialog(string msgCabecalho, string msgCorpo)
        {
            this._Timer1.Enabled = true;
            this._Timer1.Interval = int.Parse(ConfigurationManager.AppSettings["SEGUNDOS_DISPLAY_DIALOG"]);
            this._lblMsgValidacao.Text = msgCorpo;
            this._pnlCadPessRestritas.Style["display"] = "block";
            this._mpeMsgValidCadPessRestritas.Show();
        }

        private void AddJavaScriptControles()
        {
            this._txtCpf.Attributes.Add("onkeyup", "formataCPF(this,event)");
            this._txtIdade.Attributes.Add("onkeyup", "formataInteiro(this,event)");
        }

        protected void btnInserirPessoaRestrita_Click(object sender, ImageClickEventArgs e)
        {
            if (this.ValidarCamposFormulario())
            {
                this.InserirPessoaRestrita();
                this.LimparCampos();
                this.AbrirDialog("Opera\x00e7\x00e3o realizada com sucesso", "Os dados foram cadastrados com <b>Sucesso!</b>");
            }
        }

        private void InserirPessoaRestrita()
        {
            string dtNasc = string.Empty;
            if (this._txtDataNascimento.Text.Trim() != string.Empty)
            {
                dtNasc = this._txtDataNascimento.Text.Replace("/", "-");
                dtNasc = dtNasc.Substring(6, 4) + "-" + dtNasc.Substring(3, 2) + "-" + dtNasc.Substring(0, 2);
            }
            IPessoaRestrita pessoaRestrita = new PessoaRestrita(this._txtNomeArtistico.Text, this._txtNome.Text, this._txtCpf.Text, dtNasc, this._txtIdade.Text, this._txtEstado.Text, this._txtCidade.Text);
        }

        private void LimparCampos()
        {
            this._txtNomeArtistico.Text = string.Empty;
            this._txtNome.Text = string.Empty;
            this._txtCpf.Text = string.Empty;
            this._txtDataNascimento.Text = string.Empty;
            this._txtIdade.Text = string.Empty;
            this._txtEstado.Text = string.Empty;
            this._txtCidade.Text = string.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.AddJavaScriptControles();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            this._Timer1.Enabled = false;
            this._pnlCadPessRestritas.Style["display"] = "none";
            this._mpeMsgValidCadPessRestritas.Hide();
        }

        protected bool ValidarCamposFormulario()
        {
            if (this._txtCpf.Text.Trim() == string.Empty)
            {
                this.AbrirDialog("Campo obrigat\x00f3rio", "O campo <b>CPF</b> \x00e9 obrigat\x00f3rio!");
                return false;
            }
            if (this._txtCpf.Text.Trim().Length < 14)
            {
                this.AbrirDialog("Dados incorretos", "<center><marquee direction='up' scrolldelay='200'>O campo <b>CPF</b> est\x00e1 incompleto!</marquee></center>");
                return false;
            }
            return true;
        }

        protected virtual HiddenField btnhldMsgValidCadPessRestritas
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnhldMsgValidCadPessRestritas;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._btnhldMsgValidCadPessRestritas = value;
            }
        }

        protected virtual ImageButton btnInserirPessoaRestrita
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnInserirPessoaRestrita;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                ImageClickEventHandler handler = new ImageClickEventHandler(this.btnInserirPessoaRestrita_Click);
                if (this._btnInserirPessoaRestrita != null)
                {
                    this._btnInserirPessoaRestrita.Click -= handler;
                }
                this._btnInserirPessoaRestrita = value;
                if (this._btnInserirPessoaRestrita != null)
                {
                    this._btnInserirPessoaRestrita.Click += handler;
                }
            }
        }

        protected virtual HtmlForm formCapPessoasRestritas
        {
            [DebuggerNonUserCode]
            get
            {
                return this._formCapPessoasRestritas;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._formCapPessoasRestritas = value;
            }
        }

        protected virtual HtmlHead Head1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Head1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Head1 = value;
            }
        }

        protected virtual Label Label2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label2 = value;
            }
        }

        protected virtual Label Label21
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label21;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label21 = value;
            }
        }

        protected virtual Label Label23
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label23;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label23 = value;
            }
        }

        protected virtual Label Label3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label3 = value;
            }
        }

        protected virtual Label Label4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label4 = value;
            }
        }

        protected virtual Label Label7
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label7;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label7 = value;
            }
        }

        protected virtual Label lblUF
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblUF;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblUF = value;
            }
        }

        protected virtual Label lblMsgValidacao
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblMsgValidacao;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblMsgValidacao = value;
            }
        }

        protected virtual ModalPopupExtender mpeMsgValidCadPessRestritas
        {
            [DebuggerNonUserCode]
            get
            {
                return this._mpeMsgValidCadPessRestritas;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._mpeMsgValidCadPessRestritas = value;
            }
        }

        protected virtual Panel pnlCadPessRestritas
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pnlCadPessRestritas;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._pnlCadPessRestritas = value;
            }
        }

        protected virtual ToolkitScriptManager smCapPessoasRestritas
        {
            [DebuggerNonUserCode]
            get
            {
                return this._smCapPessoasRestritas;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._smCapPessoasRestritas = value;
            }
        }

        protected virtual Timer Timer1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Timer1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Timer1 = value;
            }
        }

        protected virtual TextBox txtCidade
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtCidade;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtCidade = value;
            }
        }

        protected virtual TextBox txtCpf
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtCpf;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtCpf = value;
            }
        }

        protected virtual TextBox txtDataNascimento
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtDataNascimento;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtDataNascimento = value;
            }
        }

        protected virtual TextBox txtEstado
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtEstado;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtEstado = value;
            }
        }

        protected virtual TextBox txtIdade
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtIdade;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtIdade = value;
            }
        }

        protected virtual TextBox txtNome
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtNome;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtNome = value;
            }
        }

        protected virtual TextBox txtNomeArtistico
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtNomeArtistico;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtNomeArtistico = value;
            }
        }

        protected virtual UpdatePanel upCapPessoasRestritas
        {
            [DebuggerNonUserCode]
            get
            {
                return this._upCapPessoasRestritas;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._upCapPessoasRestritas = value;
            }
        }

        protected virtual UpdateProgress uptProgressCadPessRestritas
        {
            [DebuggerNonUserCode]
            get
            {
                return this._uptProgressCadPessRestritas;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._uptProgressCadPessRestritas = value;
            }
        }
    }
}

