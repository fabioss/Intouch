namespace Intouch
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;

    public partial class PesqCpfCnpjReceita : Page
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("form1")]
        private HtmlForm _form1;
        [AccessedThroughProperty("ltResultado")]
        private Literal _ltResultado;
        [AccessedThroughProperty("meuIframe")]
        private HtmlGenericControl _meuIframe;

        [DebuggerNonUserCode]
        public PesqCpfCnpjReceita()
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

        protected virtual Literal ltResultado
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ltResultado;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ltResultado = value;
            }
        }

        protected virtual HtmlGenericControl meuIframe
        {
            [DebuggerNonUserCode]
            get
            {
                return this._meuIframe;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._meuIframe = value;
            }
        }
    }
}

