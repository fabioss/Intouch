namespace Intouch
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;

    public partial class Erro : Page
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("form1")]
        private HtmlForm _form1;

        [DebuggerNonUserCode]
        public Erro()
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

