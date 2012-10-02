namespace Intouch
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;

    public partial class Estrutura : MasterPage
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("ContentPlaceHolder")]
        private ContentPlaceHolder _ContentPlaceHolder;
        [AccessedThroughProperty("divTexto")]
        private HtmlGenericControl _divTexto;
        [AccessedThroughProperty("form1")]
        private HtmlForm _form1;
        [AccessedThroughProperty("head")]
        private ContentPlaceHolder _head;
        [AccessedThroughProperty("imgBtnFecharCaixaMensagem")]
        private Button _imgBtnFecharCaixaMensagem;
        [AccessedThroughProperty("lblMenu")]
        private Label _lblMenu;
        [AccessedThroughProperty("lblMsgGeral")]
        private Label _lblMsgGeral;
        [AccessedThroughProperty("lnkBtnMostrarCaixaMensagem")]
        private LinkButton _lnkBtnMostrarCaixaMensagem;

        [DebuggerNonUserCode]
        public Estrutura()
        {
            base.Load += new EventHandler(this.Page_Load);
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                __ENCList.Add(new WeakReference(this));
            }
        }

        protected void imgBtnFecharCaixaMensagem_Click(object sender, EventArgs e)
        {
            this.divTexto.Visible = false;
            this.imgBtnFecharCaixaMensagem.Visible = false;
        }

        protected void lnkBtnMostrarCaixaMensagem_Click(object sender, EventArgs e)
        {
            this.divTexto.Visible = true;
            this.imgBtnFecharCaixaMensagem.Visible = true;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
            }
        }

        protected virtual ContentPlaceHolder ContentPlaceHolder
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ContentPlaceHolder;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ContentPlaceHolder = value;
            }
        }

        protected virtual HtmlGenericControl divTexto
        {
            [DebuggerNonUserCode]
            get
            {
                return this._divTexto;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._divTexto = value;
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

        protected virtual ContentPlaceHolder head
        {
            [DebuggerNonUserCode]
            get
            {
                return this._head;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._head = value;
            }
        }

        protected virtual Button imgBtnFecharCaixaMensagem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._imgBtnFecharCaixaMensagem;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.imgBtnFecharCaixaMensagem_Click);
                if (this._imgBtnFecharCaixaMensagem != null)
                {
                    this._imgBtnFecharCaixaMensagem.Click -= handler;
                }
                this._imgBtnFecharCaixaMensagem = value;
                if (this._imgBtnFecharCaixaMensagem != null)
                {
                    this._imgBtnFecharCaixaMensagem.Click += handler;
                }
            }
        }

        protected virtual Label lblMenu
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblMenu;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblMenu = value;
            }
        }

        protected virtual Label lblMsgGeral
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblMsgGeral;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblMsgGeral = value;
            }
        }

        protected virtual LinkButton lnkBtnMostrarCaixaMensagem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lnkBtnMostrarCaixaMensagem;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lnkBtnMostrarCaixaMensagem_Click);
                if (this._lnkBtnMostrarCaixaMensagem != null)
                {
                    this._lnkBtnMostrarCaixaMensagem.Click -= handler;
                }
                this._lnkBtnMostrarCaixaMensagem = value;
                if (this._lnkBtnMostrarCaixaMensagem != null)
                {
                    this._lnkBtnMostrarCaixaMensagem.Click += handler;
                }
            }
        }
    }
}

