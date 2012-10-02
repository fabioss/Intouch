namespace Intouch
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;

    public partial class exportaExcel  : Page
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("DataGrid1")]
        private DataGrid _DataGrid1;
        [AccessedThroughProperty("formExportarExcel")]
        private HtmlForm _formExportarExcel;

        [DebuggerNonUserCode]
        public exportaExcel()
        {
            base.Load += new EventHandler(this.Page_Load);
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                __ENCList.Add(new WeakReference(this));
            }
        }

        public void ExportarExcel(DataGrid grid)
        {
            this.Response.Clear();
            this.Response.AddHeader("content-disposition", "attachment;filename=Arquivo.xls");
            this.Response.Charset = "";
            this.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            this.Response.ContentType = "application/vnd.xls";
            StringWriter sWr = new StringWriter();
            HtmlTextWriter hWr = new HtmlTextWriter(sWr);
            grid.RenderControl(hWr);
            this.Response.Write(sWr.ToString());
            this.Response.End();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)this.Session["dtDetalhes"];
            this.DataGrid1.DataSource = dt;
            this.DataGrid1.DataBind();
            this.ExportarExcel(this.DataGrid1);
            this.Session["dtDetalhes"] = null;
        }

        protected virtual DataGrid DataGrid1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DataGrid1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._DataGrid1 = value;
            }
        }

        protected virtual HtmlForm formExportarExcel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._formExportarExcel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._formExportarExcel = value;
            }
        }
    }
}

