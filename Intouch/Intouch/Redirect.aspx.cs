namespace Intouch
{
    using BIUnit4;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;

    public partial class Redirect : Page
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("form1")]
        private HtmlForm _form1;

        [DebuggerNonUserCode]
        public Redirect()
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
            sb.AppendLine("alert('" + ((AbstractError)this.Session["BUSINESS_ERROR"]).Erro + "');");
            sb.AppendLine("window.location = 'acesso1.aspx';");
            sb.AppendLine("</script>");
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "Open", sb.ToString(), false);
            this.Session.Clear();
            this.Session.RemoveAll();
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

