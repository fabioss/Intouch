namespace Intouch
{
    using DllPainelDeControle;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;

    public partial class imprimir : Page
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("form1")]
        private HtmlForm _form1;

        [DebuggerNonUserCode]
        public imprimir()
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
                string strHtml;
                if (this.Request.QueryString["janelapopup"] == "s")
                {
                    Panel pnl = new Panel();
                    pnl.Controls.Add((Control)this.Session["lbl"]);
                    if (this.Session["ctrl"] != null)
                    {
                        pnl.Controls.Add((Control)this.Session["ctrl"]);
                    }
                    else
                    {
                        pnl.Controls.Add((Control)this.Session["dg"]);
                    }
                    strHtml = PrintWebControl.GetStringHtmlControls(pnl, string.Empty);
                }
                else
                {
                    strHtml = this.Session["HTML_PAGE"].ToString();
                }
                if (Operators.ConditionalCompareObjectNotEqual(this.Session["DOCUMENTO"], null, false))
                {
                    HtmlToPdf.Print(strHtml, Convert.ToBoolean(this.Request.QueryString["showdialog"] == "s" ? false : true), this.Session["DOCUMENTO"].ToString() + ".pdf");
                }
                else
                {
                    HtmlToPdf.Print(strHtml, Convert.ToBoolean(this.Request.QueryString["showdialog"] == "s" ? false : true), "Home.pdf");
                }
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

