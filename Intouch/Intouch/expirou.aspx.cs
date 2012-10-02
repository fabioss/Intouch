namespace Intouch
{
    using AjaxControlToolkit;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;

    public partial class expirou : Page
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("form1")]
        private HtmlForm _form1;
        [AccessedThroughProperty("lblMsgExpirou")]
        private Label _lblMsgExpirou;
        [AccessedThroughProperty("lblTitulo")]
        private Label _lblTitulo;
        [AccessedThroughProperty("smBuscaClean")]
        private ToolkitScriptManager _smBuscaClean;
        [AccessedThroughProperty("tmrExpirou")]
        private Timer _tmrExpirou;
        [AccessedThroughProperty("upExpirouBC")]
        private UpdatePanel _upExpirouBC;

        [DebuggerNonUserCode]
        public expirou()
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
            if (!this.IsPostBack)
            {
                this.tmrExpirou.Interval = 0x3e8;
                this.tmrExpirou.Enabled = true;
                this.Session["SECONDS"] = 3;
                this.lblMsgExpirou.Text = "Aguarde, redirecionando em... <br><br>" + this.Session["SECONDS"].ToString();
            }
        }

        protected void tmrExpirou_Tick(object sender, EventArgs e)
        {
            this.Session["SECONDS"] = Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.Session["SECONDS"])) - 1;
            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.Session["SECONDS"])) == 0)
            {
                this.Response.Redirect("Default.aspx", true);
                this.tmrExpirou.Enabled = false;
            }
            else
            {
                this.lblMsgExpirou.Text = "Aguarde, redirecionando em... <br><br>" + this.Session["SECONDS"].ToString();
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

        protected virtual Label lblMsgExpirou
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblMsgExpirou;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblMsgExpirou = value;
            }
        }

        protected virtual Label lblTitulo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblTitulo;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblTitulo = value;
            }
        }

        protected virtual ToolkitScriptManager smBuscaClean
        {
            [DebuggerNonUserCode]
            get
            {
                return this._smBuscaClean;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._smBuscaClean = value;
            }
        }

        protected virtual Timer tmrExpirou
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tmrExpirou;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler<EventArgs> handler = new EventHandler<EventArgs>(this.tmrExpirou_Tick);
                if (this._tmrExpirou != null)
                {
                    this._tmrExpirou.Tick -= handler;
                }
                this._tmrExpirou = value;
                if (this._tmrExpirou != null)
                {
                    this._tmrExpirou.Tick += handler;
                }
            }
        }

        protected virtual UpdatePanel upExpirouBC
        {
            [DebuggerNonUserCode]
            get
            {
                return this._upExpirouBC;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._upExpirouBC = value;
            }
        }
    }
}

