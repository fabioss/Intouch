namespace Intouch
{
    using AjaxControlToolkit;
    using BIUnit4;
    using DllPainelDeControle;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;

    public partial class RelatorioClean : GlobalPage
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("AutoCompleteExtender1")]
        private AutoCompleteExtender _AutoCompleteExtender1;
        [AccessedThroughProperty("btnConsultar")]
        private ImageButton _btnConsultar;
        [AccessedThroughProperty("btnOk")]
        private Button _btnOk;
        [AccessedThroughProperty("CalendarExtender1")]
        private CalendarExtender _CalendarExtender1;
        [AccessedThroughProperty("CalendarExtender2")]
        private CalendarExtender _CalendarExtender2;
        [AccessedThroughProperty("chkBoxGerarExcel")]
        private CheckBox _chkBoxGerarExcel;
        [AccessedThroughProperty("ddlCliente")]
        private DropDownList _ddlCliente;
        [AccessedThroughProperty("ddlOpcoesUsuario")]
        private DropDownList _ddlOpcoesUsuario;
        [AccessedThroughProperty("ddlTipo")]
        private DropDownList _ddlTipo;
        [AccessedThroughProperty("dgRelatorio")]
        private DataGrid _dgRelatorio;
        [AccessedThroughProperty("dgRelatorioAgendado")]
        private DataGrid _dgRelatorioAgendado;
        [AccessedThroughProperty("dgTotalConsultaCliente")]
        private DataGrid _dgTotalConsultaCliente;
        [AccessedThroughProperty("form1")]
        private HtmlForm _form1;
        [AccessedThroughProperty("hdnFldIdLogin")]
        private HiddenField _hdnFldIdLogin;
        [AccessedThroughProperty("Head1")]
        private HtmlHead _Head1;
        [AccessedThroughProperty("ImageButton1")]
        private ImageButton _ImageButton1;
        [AccessedThroughProperty("ImageButton2")]
        private ImageButton _ImageButton2;
        [AccessedThroughProperty("imgBtnExportaExcel")]
        private ImageButton _imgBtnExportaExcel;
        [AccessedThroughProperty("itemUsuario")]
        private HtmlGenericControl _itemUsuario;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("lblMsg")]
        private Label _lblMsg;
        [AccessedThroughProperty("lblOrdenar")]
        private Label _lblOrdenar;
        [AccessedThroughProperty("lblQtdTotalConsultada")]
        private Label _lblQtdTotalConsultada;
        [AccessedThroughProperty("lblRelExcel")]
        private HtmlGenericControl _lblRelExcel;
        [AccessedThroughProperty("lblTipo")]
        private Label _lblTipo;
        [AccessedThroughProperty("lblTotal")]
        private Label _lblTotal;
        [AccessedThroughProperty("lblUsuario")]
        private Label _lblUsuario;
        [AccessedThroughProperty("lnkBtnTotalCliente")]
        private LinkButton _lnkBtnTotalCliente;
        [AccessedThroughProperty("mpeTotalCliente")]
        private ModalPopupExtender _mpeTotalCliente;
        [AccessedThroughProperty("pnlAgendados")]
        private Panel _pnlAgendados;
        [AccessedThroughProperty("pnlTotalCliente")]
        private Panel _pnlTotalCliente;
        [AccessedThroughProperty("smRelClean")]
        private ToolkitScriptManager _smRelClean;
        [AccessedThroughProperty("txtDataFim")]
        private TextBox _txtDataFim;
        [AccessedThroughProperty("txtDataInicio")]
        private TextBox _txtDataInicio;
        [AccessedThroughProperty("txtNomePesq")]
        private TextBox _txtNomePesq;
        [AccessedThroughProperty("ucMenuCabecalho")]
        private menu _ucMenuCabecalho;
        [AccessedThroughProperty("uptProgressRelClean")]
        private UpdateProgress _uptProgressRelClean;

        [DebuggerNonUserCode]
        public RelatorioClean()
        {
            base.Load += new EventHandler(this.Page_Load);
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                __ENCList.Add(new WeakReference(this));
            }
        }

        protected void AgendarRelatorio()
        {
            try
            {
                IAgendamentoRelatorio agendamento;
                agendamento = new AgendamentoRelatorio {
                    //idClienteSolicitante = ((Usuario)this.Session["USUARIO"]).Cliente.IdCliente,
                    //LoginSolicitante = ((Usuario)this.Session["USUARIO"]).DsLogin,
                    //DtInicio = this.txtDataInicio.Text,
                    //DtFim = this.txtDataFim.Text,
                    //NomeCliente = this.ddlCliente.SelectedItem.Text,
                    //NomeUsuario = this.txtNomePesq.Text,
                    //Tipo = this._ddlTipo.SelectedItem.Text,
                    //OpcoesUsuario = this.ddlOpcoesUsuario.SelectedItem.Text,
                    //Relatorio = "RELATORIO_" + Convert.ToString(DateTime.Now),
                    //Relatorio = agendamento.Relatorio.Replace("/", "_").Replace(" ", "_").Replace(":", "_"),
                    //Comando = agendamento.GetComandoRelatorio(DateTime.ParseExact(this.txtDataInicio.Text, "dd/MM/yyyy", null).ToString("yyyyMMdd"), DateTime.ParseExact(this.txtDataFim.Text, "dd/MM/yyyy", null).ToString("yyyyMMdd"), Convert.ToString(this.ddlCliente.SelectedValue == "0" ? "NULL" : this.ddlCliente.SelectedValue.ToString()), Convert.ToString(this.hdnFldIdLogin.Value == "0" ? "NULL" : this.hdnFldIdLogin.Value), Convert.ToString(this.ddlTipo.SelectedValue == "0" ? "NULL" : this._ddlTipo.SelectedValue.ToString()), Convert.ToInt32(this.ddlOpcoesUsuario.SelectedValue)) + "",
                    //Comando2 = agendamento.GetComandoRelatorioExcel(this.ddlCliente.SelectedValue.ToString(), Convert.ToString(this.hdnFldIdLogin.Value == "0" ? "NULL" : this.hdnFldIdLogin.Value), DateTime.ParseExact(this.txtDataInicio.Text, "dd/MM/yyyy", null).ToString("yyyyMMdd"), DateTime.ParseExact(this.txtDataFim.Text, "dd/MM/yyyy", null).ToString("yyyyMMdd")),
                    //FgRelatorioDetalhado = this.chkBoxGerarExcel.Checked,
                    //FgOk = false
                };
                agendamento.Inserir((AgendamentoRelatorio) agendamento);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "AgendarRelatorio", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void btnConsultar_Click1(object sender, ImageClickEventArgs e)
        {
            try
            {
                this.AgendarRelatorio();
                this.PopulaDgRelatorioAgendado();
                this.dgRelatorio.DataSource = null;
                this.dgRelatorio.DataBind();
                this.imgBtnExportaExcel.Visible = false;
                this.lblQtdTotalConsultada.Text = "";
                this.lnkBtnTotalCliente.Visible = false;
                this.hdnFldIdLogin.Value = "0";
                this.txtNomePesq.Text = "Todos";
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "btnConsultar_Click1", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void btnExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Response.Redirect("exportaExcel.aspx");
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "btnExportarExcel_Click", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void btnLimpar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                this.txtDataInicio.Text = string.Empty;
                this.txtDataFim.Text = string.Empty;
                this.ddlTipo.SelectedIndex = -1;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario) this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario) this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "btnLimpar_Click", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void CalcularTotalConsultas(DataTable dt)
        {
            try
            {
                IEnumerator firstXPTO;
                int contador = 0;
                try
                {
                    firstXPTO = dt.Rows.GetEnumerator();
                    while (firstXPTO.MoveNext())
                    {
                        DataRow dr = (DataRow) firstXPTO.Current;
                        contador = Convert.ToInt32(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(contador, dr["Qtd. Consulta"]));
                    }
                }
                finally
                {
                    //if (firstXPTO is IDisposable)
                    //{
                    //    (firstXPTO as IDisposable).Dispose();
                    //}
                }
                this.lblQtdTotalConsultada.Text = "Total de Consultas -------------- " + contador.ToString() + "";
                dt.Dispose();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario) this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario) this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "CalcularTotalConsultas", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void ddlCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.AutoCompleteExtender1.ContextKey = Convert.ToString(Convert.ToInt32(this.ddlCliente.SelectedValue.ToString()));
                this.hdnFldIdLogin.Value = "0";
                this.txtNomePesq.Text = "Todos";
                this.txtNomePesq.ReadOnly = Convert.ToBoolean(Convert.ToDouble(this.ddlCliente.SelectedValue) == 0.0 ? true : false);
                this.itemUsuario.Visible = Convert.ToBoolean(Convert.ToDouble(this.ddlCliente.SelectedValue) != 0.0 ? true : false);
                this.lblRelExcel.Visible = Convert.ToBoolean(Convert.ToDouble(this.ddlCliente.SelectedValue) == 0.0 ? false : true);
                this.chkBoxGerarExcel.Checked = Convert.ToBoolean(Convert.ToDouble(this.ddlCliente.SelectedValue) == 0.0 ? false : true);
                this.chkBoxGerarExcel.Visible = Convert.ToBoolean(Convert.ToDouble(this.ddlCliente.SelectedValue) == 0.0 ? false : true);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "ddlCliente_SelectedIndexChanged", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgRelatorio_SortCommand(object source, DataGridSortCommandEventArgs e)
        {
            try
            {
                DataView dv = new DataView((DataTable) this.Session["DT_RELATORIO_MONITORAMENTO"]) {
                    Sort = e.SortExpression
                };
                this.dgRelatorio.DataSource = dv;
                this.dgRelatorio.DataBind();
                dv.Dispose();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "dgRelatorio_SortCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgRelatorioAgendado_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper() == "VISUALIZARRELATORIO")
                {
                    IEnumerator firstXPTO;
                    try
                    {
                        firstXPTO = this.dgRelatorioAgendado.Items.GetEnumerator();
                        while (firstXPTO.MoveNext())
                        {
                            DataGridItem item = (DataGridItem) firstXPTO.Current;
                            item.BackColor = Color.Empty;
                        }
                    }
                    finally
                    {
                        //if (firstXPTO is IDisposable)
                        //{
                        //    (firstXPTO as IDisposable).Dispose();
                        //}
                    }
                    e.Item.BackColor = Color.DarkSeaGreen;
                    this.ExibirRelatorio(e.Item.Cells[9].Text);
                    if ((e.Item.Cells[3].Text.ToUpper() != "TODOS") & Convert.ToBoolean(e.Item.Cells[11].Text))
                    {
                        this.imgBtnExportaExcel.Visible = true;
                    }
                    else
                    {
                        this.imgBtnExportaExcel.Visible = false;
                    }
                    this.Session["TABELA_RELATORIO"] = e.Item.Cells[9].Text;
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "dgRelatorioAgendado_ItemCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgRelatorioAgendado_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            try
            {
                if ((e.Item.ItemType == ListItemType.Item) | (e.Item.ItemType == ListItemType.AlternatingItem))
                {
                    e.Item.Cells[3].Text = e.Item.Cells[3].Text;
                    e.Item.Cells[4].Text = e.Item.Cells[4].Text;
                    e.Item.Cells[5].Text = e.Item.Cells[5].Text;
                    e.Item.Cells[6].Text = e.Item.Cells[6].Text;
                    ((ImageButton) e.Item.FindControl("imgBtnRelatorio")).ImageUrl = Convert.ToString(e.Item.Cells[8].Text.ToUpper() == "TRUE" ? "img/ic_inserir_novo.png" : "img/ic_cancelar.png");
                    ((ImageButton) e.Item.FindControl("imgBtnRelatorio")).Enabled = Convert.ToBoolean(e.Item.Cells[8].Text);
                    ((ImageButton) e.Item.FindControl("imgBtnRelatorio")).ToolTip = Convert.ToString(e.Item.Cells[8].Text.ToUpper() == "TRUE" ? "Dispon\x00edvel" : "Indispon\x00edvel");
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "dgRelatorioAgendado_ItemDataBound", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgRelatorioAgendado_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            try
            {
                this.dgRelatorioAgendado.CurrentPageIndex = e.NewPageIndex;
                this.dgRelatorioAgendado.DataSource = RuntimeHelpers.GetObjectValue(this.Session["DT_AGENDAMENTO"]);
                this.Session["DT_AGENDAMENTO"] = RuntimeHelpers.GetObjectValue(this.Session["DT_AGENDAMENTO"]);
                this.dgRelatorioAgendado.DataBind();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "dgRelatorioAgendado_PageIndexChanged", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgTotalConsultaCliente_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            try
            {
                this.dgTotalConsultaCliente.CurrentPageIndex = e.NewPageIndex;
                this.dgTotalConsultaCliente.DataSource = (DataTable) this.Session["DT_TOTAL_CONSULTA_CLIENTE"];
                this.dgTotalConsultaCliente.DataBind();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "dgTotalConsultaCliente_PageIndexChanged", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgTotalConsultaCliente_SortCommand(object source, DataGridSortCommandEventArgs e)
        {
            try
            {
                DataView dv = new DataView((DataTable) this.Session["DT_TOTAL_CONSULTA_CLIENTE"]) {
                    Sort = e.SortExpression
                };
                this.mpeTotalCliente.Show();
                this.dgTotalConsultaCliente.DataSource = dv;
                this.dgTotalConsultaCliente.DataBind();
                dv.Dispose();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "dgTotalConsultaCliente_SortCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void ExibirRelatorio(string tabela)
        {
            try
            {
                this.Session["DT_RELATORIO_MONITORAMENTO"] = ((IBIIntouch) this.Session["BUSINESS"]).AgendamentoRelatorio.GetRelatorio(tabela);
                if (this.Session["DT_RELATORIO_MONITORAMENTO"] == null)
                {
                    this.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "alerta", "<script>alert('Nenhum registro encontrado.');</script>");
                }
                else if (((DataTable) this.Session["DT_RELATORIO_MONITORAMENTO"]).Rows.Count == 0)
                {
                    this.dgRelatorio.Visible = false;
                    this.lblMsg.Text = "Nenhum registro encontrado para a pesquisa.";
                    this.imgBtnExportaExcel.Visible = false;
                }
                else
                {
                    this.dgRelatorio.Visible = true;
                    this.lblMsg.Text = "";
                    this.imgBtnExportaExcel.Visible = true;
                    this.dgRelatorio.AllowSorting = true;
                    this.dgRelatorio.DataSource = (DataTable) this.Session["DT_RELATORIO_MONITORAMENTO"];
                    this.dgRelatorio.DataBind();
                    this.dgRelatorio.Columns[0].Visible = false;
                    this.dgRelatorio.Columns[1].Visible = Convert.ToBoolean(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper() == "UNITFOUR" ? true : false);
                    this.dgRelatorio.Columns[3].Visible = Convert.ToBoolean(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper() == "UNITFOUR" ? true : false);
                    this.dgRelatorio.Columns[7].Visible = Convert.ToBoolean(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper() == "UNITFOUR" ? true : false);
                    this.dgRelatorio.Columns[8].Visible = Convert.ToBoolean(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper() == "UNITFOUR" ? true : false);
                    this.dgRelatorio.Columns[9].Visible = Convert.ToBoolean(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper() == "UNITFOUR" ? true : false);
                    this.dgRelatorio.Columns[10].Visible = false;
                    this.lnkBtnTotalCliente.Visible = Convert.ToBoolean((((DataTable)this.Session["DT_RELATORIO_MONITORAMENTO"]).Rows.Count > 0) & (((Usuario)this.Session["USUARIO"]).Cliente.IdCliente == 1) ? true : false);
                    this.CalcularTotalConsultas((DataTable) this.Session["DT_RELATORIO_MONITORAMENTO"]);
                }
                this.dgRelatorioAgendado.CurrentPageIndex = 0;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "ExibirRelatorio", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void ExportarRelatorioExcel(DataTable dt)
        {
            try
            {
                this.Session["dtDetalhes"] = dt;
                this.Response.Redirect("exportaExcel.aspx");
                dt.Dispose();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "ExportarRelatorioExcel", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void imgBtnExportaExcel_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                this.Response.Redirect(Convert.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject("~/RELATORIO_DETALHADO/", this.Session["TABELA_RELATORIO"]), "_DETALHADO.xls")));
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "imgBtnExportaExcel_Click", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void lnkBtnTotalCliente_Click(object sender, EventArgs e)
        {
            try
            {
                this.mpeTotalCliente.Show();
                this.Session["DT_TOTAL_CONSULTA_CLIENTE"] = ((IBIIntouch) this.Session["BUSINESS"]).AgendamentoRelatorio.GetTotalConsultaClienteRelatorio(this.Session["TABELA_RELATORIO"].ToString());
                this.dgTotalConsultaCliente.DataSource = (DataTable) this.Session["DT_TOTAL_CONSULTA_CLIENTE"];
                this.dgTotalConsultaCliente.AllowSorting = true;
                this.dgTotalConsultaCliente.DataBind();
                this.dgTotalConsultaCliente.Columns[0].SortExpression = "Cliente";
                this.dgTotalConsultaCliente.Columns[1].SortExpression = "Qtd. Total de Consultas";
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "lnkBtnTotalCliente_Click", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                try
                {
                    if (!GlobalPage.PodeAcessarPagina((Acesso) this.Session["DADOS_ACESSO"], Path.GetFileName(HttpContext.Current.Request.FilePath)))
                    {
                        this.Response.Redirect("AccessDenied.aspx", false);
                    }
                    else
                    {
                        this.txtNomePesq.Attributes.Add("OnBlur", "GetIdUsuario(document.getElementById('" + this.txtNomePesq.ClientID + "').value);");
                        this.txtNomePesq.Text = "Todos";
                        this.hdnFldIdLogin.Value = "0";
                        this.imgBtnExportaExcel.Visible = false;
                        this.txtDataInicio.Text = DateTime.Now.ToShortDateString();
                        this.txtDataFim.Text = DateTime.Now.ToShortDateString();
                        this.PopulaComboTipo();
                        this.PopulaComboCliente();
                        this.ddlCliente.Attributes.Add("onchange", "desabilitarCampos();");
                        this.ddlCliente_SelectedIndexChanged(null, null);
                        this.AutoCompleteExtender1.ContextKey = this.ddlCliente.SelectedValue;
                        if (((Usuario)this.Session["USUARIO"]).AdmMaster & (((Usuario)this.Session["USUARIO"]).Cliente.IdCliente != 1))
                        {
                            this.Label5.Visible = false;
                            this.ddlCliente.Visible = false;
                            this.lblUsuario.Visible = true;
                            this.txtNomePesq.Visible = true;
                        }
                        else if (!((Usuario)this.Session["USUARIO"]).AdmMaster & (((Usuario)this.Session["USUARIO"]).Cliente.IdCliente == 1))
                        {
                            this.Label5.Visible = false;
                            this.ddlCliente.Visible = false;
                            this.lblUsuario.Visible = false;
                            this.txtNomePesq.Visible = false;
                            this.ddlTipo.Visible = false;
                            this.lblTipo.Visible = false;
                        }
                        else if (((Usuario)this.Session["USUARIO"]).AdmMaster & (((Usuario)this.Session["USUARIO"]).Cliente.IdCliente == 1))
                        {
                            this.Label5.Visible = true;
                            this.ddlCliente.Visible = true;
                            this.lblUsuario.Visible = true;
                            this.txtNomePesq.Visible = true;
                            this.ddlTipo.Visible = true;
                            this.lblTipo.Visible = true;
                        }
                        else
                        {
                            this.lblUsuario.Visible = false;
                            this.txtNomePesq.Visible = true;
                            this.Label5.Visible = false;
                            this.ddlCliente.Visible = false;
                        }
                        this.PopulaDgRelatorioAgendado();
                    }
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception ex = exception1;
                    throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "Page_Load", ex.Message, ex.StackTrace, this.Form.Controls));
                }
            }
        }

        public void PopulaComboCliente()
        {
            try
            {
                this.txtNomePesq.Text = string.Empty;
                this.ddlCliente.DataTextField = "Nome";
                this.ddlCliente.DataValueField = "idCliente";
                if (((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper() == "UNITFOUR")
                {
                    this.ddlCliente.DataSource = Cliente.GetColecaoCliente();
                    this.ddlCliente.DataBind();
                }
                else
                {
                    this.ddlCliente.Items.Add(new ListItem(((Acesso) this.Session["DADOS_ACESSO"]).NomeCliente, Convert.ToString(((Acesso) this.Session["DADOS_ACESSO"]).Cliente)));
                }
                this.ddlCliente.Items.Add(new ListItem("Todos", Convert.ToString(0)));
                this.ddlCliente.SelectedValue = Convert.ToString(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper() == "UNITFOUR" ? "0" : ((Acesso)this.Session["DADOS_ACESSO"]).Cliente.ToString());
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "PopulaComboCliente", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void PopulaComboTipo()
        {
            DropDownList dComboTipo = this._ddlTipo;
            dComboTipo.Items.Add(new ListItem("Todas (Consulta PF e PJ)", "0"));
            dComboTipo.Items.Add(new ListItem("Consulta PF", "1"));
            dComboTipo.Items.Add(new ListItem("Consulta PJ", "4"));
            dComboTipo = null;
        }

        public void PopulaComboUsuario(int idCliente)
        {
        }

        protected void PopulaDgRelatorioAgendado()
        {
            try
            {
                this.Session["DT_AGENDAMENTO"] = ((IBIIntouch)this.Session["BUSINESS"]).AgendamentoRelatorio.GetAgendamentoRelatorioByCliente(((Usuario)this.Session["USUARIO"]).Cliente.IdCliente);
                this.dgRelatorioAgendado.DataSource = RuntimeHelpers.GetObjectValue(this.Session["DT_AGENDAMENTO"]);
                this.dgRelatorioAgendado.DataBind();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "RelatorioClean.aspx", "PopulaDgRelatorioAgendado", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected virtual AutoCompleteExtender AutoCompleteExtender1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._AutoCompleteExtender1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._AutoCompleteExtender1 = value;
            }
        }

        protected virtual ImageButton btnConsultar
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnConsultar;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                ImageClickEventHandler handler = new ImageClickEventHandler(this.btnConsultar_Click1);
                if (this._btnConsultar != null)
                {
                    this._btnConsultar.Click -= handler;
                }
                this._btnConsultar = value;
                if (this._btnConsultar != null)
                {
                    this._btnConsultar.Click += handler;
                }
            }
        }

        protected virtual Button btnOk
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnOk;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._btnOk = value;
            }
        }

        protected virtual CalendarExtender CalendarExtender1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CalendarExtender1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._CalendarExtender1 = value;
            }
        }

        protected virtual CalendarExtender CalendarExtender2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CalendarExtender2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._CalendarExtender2 = value;
            }
        }

        protected virtual CheckBox chkBoxGerarExcel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chkBoxGerarExcel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._chkBoxGerarExcel = value;
            }
        }

        protected virtual DropDownList ddlCliente
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ddlCliente;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.ddlCliente_SelectedIndexChanged);
                if (this._ddlCliente != null)
                {
                    this._ddlCliente.SelectedIndexChanged -= handler;
                }
                this._ddlCliente = value;
                if (this._ddlCliente != null)
                {
                    this._ddlCliente.SelectedIndexChanged += handler;
                }
            }
        }

        protected virtual DropDownList ddlOpcoesUsuario
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ddlOpcoesUsuario;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ddlOpcoesUsuario = value;
            }
        }

        protected virtual DropDownList ddlTipo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ddlTipo;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ddlTipo = value;
            }
        }

        protected virtual DataGrid dgRelatorio
        {
            [DebuggerNonUserCode]
            get
            {
                return this._dgRelatorio;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                DataGridSortCommandEventHandler handler = new DataGridSortCommandEventHandler(this.dgRelatorio_SortCommand);
                if (this._dgRelatorio != null)
                {
                    this._dgRelatorio.SortCommand -= handler;
                }
                this._dgRelatorio = value;
                if (this._dgRelatorio != null)
                {
                    this._dgRelatorio.SortCommand += handler;
                }
            }
        }

        protected virtual DataGrid dgRelatorioAgendado
        {
            [DebuggerNonUserCode]
            get
            {
                return this._dgRelatorioAgendado;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                DataGridPageChangedEventHandler handler = new DataGridPageChangedEventHandler(this.dgRelatorioAgendado_PageIndexChanged);
                DataGridItemEventHandler handler2 = new DataGridItemEventHandler(this.dgRelatorioAgendado_ItemDataBound);
                DataGridCommandEventHandler handler3 = new DataGridCommandEventHandler(this.dgRelatorioAgendado_ItemCommand);
                if (this._dgRelatorioAgendado != null)
                {
                    this._dgRelatorioAgendado.PageIndexChanged -= handler;
                    this._dgRelatorioAgendado.ItemDataBound -= handler2;
                    this._dgRelatorioAgendado.ItemCommand -= handler3;
                }
                this._dgRelatorioAgendado = value;
                if (this._dgRelatorioAgendado != null)
                {
                    this._dgRelatorioAgendado.PageIndexChanged += handler;
                    this._dgRelatorioAgendado.ItemDataBound += handler2;
                    this._dgRelatorioAgendado.ItemCommand += handler3;
                }
            }
        }

        protected virtual DataGrid dgTotalConsultaCliente
        {
            [DebuggerNonUserCode]
            get
            {
                return this._dgTotalConsultaCliente;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                DataGridSortCommandEventHandler handler = new DataGridSortCommandEventHandler(this.dgTotalConsultaCliente_SortCommand);
                DataGridPageChangedEventHandler handler2 = new DataGridPageChangedEventHandler(this.dgTotalConsultaCliente_PageIndexChanged);
                if (this._dgTotalConsultaCliente != null)
                {
                    this._dgTotalConsultaCliente.SortCommand -= handler;
                    this._dgTotalConsultaCliente.PageIndexChanged -= handler2;
                }
                this._dgTotalConsultaCliente = value;
                if (this._dgTotalConsultaCliente != null)
                {
                    this._dgTotalConsultaCliente.SortCommand += handler;
                    this._dgTotalConsultaCliente.PageIndexChanged += handler2;
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

        protected virtual HiddenField hdnFldIdLogin
        {
            [DebuggerNonUserCode]
            get
            {
                return this._hdnFldIdLogin;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._hdnFldIdLogin = value;
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

        protected virtual ImageButton ImageButton1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ImageButton1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ImageButton1 = value;
            }
        }

        protected virtual ImageButton ImageButton2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ImageButton2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ImageButton2 = value;
            }
        }

        protected virtual ImageButton imgBtnExportaExcel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._imgBtnExportaExcel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                ImageClickEventHandler handler = new ImageClickEventHandler(this.imgBtnExportaExcel_Click);
                if (this._imgBtnExportaExcel != null)
                {
                    this._imgBtnExportaExcel.Click -= handler;
                }
                this._imgBtnExportaExcel = value;
                if (this._imgBtnExportaExcel != null)
                {
                    this._imgBtnExportaExcel.Click += handler;
                }
            }
        }

        protected virtual HtmlGenericControl itemUsuario
        {
            [DebuggerNonUserCode]
            get
            {
                return this._itemUsuario;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._itemUsuario = value;
            }
        }

        protected virtual Label Label1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label1 = value;
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

        protected virtual Label Label5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label5 = value;
            }
        }

        protected virtual Label lblMsg
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblMsg;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblMsg = value;
            }
        }

        protected virtual Label lblOrdenar
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblOrdenar;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblOrdenar = value;
            }
        }

        protected virtual Label lblQtdTotalConsultada
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblQtdTotalConsultada;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblQtdTotalConsultada = value;
            }
        }

        protected virtual HtmlGenericControl lblRelExcel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblRelExcel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblRelExcel = value;
            }
        }

        protected virtual Label lblTipo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblTipo;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblTipo = value;
            }
        }

        protected virtual Label lblTotal
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblTotal;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblTotal = value;
            }
        }

        protected virtual Label lblUsuario
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblUsuario;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblUsuario = value;
            }
        }

        protected virtual LinkButton lnkBtnTotalCliente
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lnkBtnTotalCliente;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lnkBtnTotalCliente_Click);
                if (this._lnkBtnTotalCliente != null)
                {
                    this._lnkBtnTotalCliente.Click -= handler;
                }
                this._lnkBtnTotalCliente = value;
                if (this._lnkBtnTotalCliente != null)
                {
                    this._lnkBtnTotalCliente.Click += handler;
                }
            }
        }

        protected virtual ModalPopupExtender mpeTotalCliente
        {
            [DebuggerNonUserCode]
            get
            {
                return this._mpeTotalCliente;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._mpeTotalCliente = value;
            }
        }

        protected virtual Panel pnlAgendados
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pnlAgendados;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._pnlAgendados = value;
            }
        }

        protected virtual Panel pnlTotalCliente
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pnlTotalCliente;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._pnlTotalCliente = value;
            }
        }

        protected virtual ToolkitScriptManager smRelClean
        {
            [DebuggerNonUserCode]
            get
            {
                return this._smRelClean;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._smRelClean = value;
            }
        }

        protected virtual TextBox txtDataFim
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtDataFim;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtDataFim = value;
            }
        }

        protected virtual TextBox txtDataInicio
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtDataInicio;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtDataInicio = value;
            }
        }

        protected virtual TextBox txtNomePesq
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtNomePesq;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtNomePesq = value;
            }
        }

        protected virtual menu ucMenuCabecalho
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ucMenuCabecalho;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ucMenuCabecalho = value;
            }
        }

        protected virtual UpdateProgress uptProgressRelClean
        {
            [DebuggerNonUserCode]
            get
            {
                return this._uptProgressRelClean;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._uptProgressRelClean = value;
            }
        }
    }
}

