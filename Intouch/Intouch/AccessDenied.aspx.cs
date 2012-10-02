namespace Intouch
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;

    public partial class AccessDenied : Page
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("form1")]
        private HtmlForm _form1;

        [DebuggerNonUserCode]
        public AccessDenied()
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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<script language='javascript'>");
            sb.AppendLine("alert('Acesso Negado!');");
            sb.AppendLine("window.location = 'Default.aspx';");
            sb.AppendLine("</script>");
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "Open", sb.ToString(), false);
            this.Session.Clear();
            this.Session.RemoveAll();
        }

        protected virtual HtmlForm formAccessDenied
        {
            [DebuggerNonUserCode]
            get
            {
                return this._formAccessDenied;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._formAccessDenied = value;
            }
        }
    }
}

