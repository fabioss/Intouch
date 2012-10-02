namespace Intouch
{
    using BIUnit4;
    using DllPainelDeControle;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class menu : UserControl
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("lblMenu")]
        private Label _lblMenu;

        [DebuggerNonUserCode]
        public menu()
        {
            base.Load += new EventHandler(this.Page_Load);
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                __ENCList.Add(new WeakReference(this));
            }
        }

        protected string GetMenuAplicacao()
        {
            string parametro = string.Empty;
            HorizontalMenu horizontalMenu = new HorizontalMenu();
            try
            {
                IEnumerator firstXPTO;
                PermissaoAcesso pa = ((Acesso) this.Session["DADOS_ACESSO"]).PermissaoAcesso;
                pa.Perfil.AcaoModuloColecao.GetColecaoByProduto(1);
                parametro = BIUnit4.Cript_Decript.Cifra("produto=" + Convert.ToInt32(1).ToString() + "&cliente=" + ((Usuario) this.Session["USUARIO"]).IdCliente.ToString() + "&login=" + ((Usuario) this.Session["USUARIO"]).IdLogin.ToString() + "");
                try
                {
                    firstXPTO = pa.Perfil.AcaoModuloColecao.GetEnumerator();
                    while (firstXPTO.MoveNext())
                    {
                        AcaoModulo am = (AcaoModulo) firstXPTO.Current;
                        if ((am.ProdutoModulo != null) && am.ProdutoModulo.Modulo.Ativo)
                        {
                            IEnumerator secondXPTO;
                            HorizontalMenu.ItemMenu itemMenu = new HorizontalMenu.ItemMenu(am.ProdutoModulo.Modulo.Descricao, am.ProdutoModulo.Modulo.Pagina + "?p=" + parametro, string.Empty);
                            SubModulo.SubModuloColecao subModuloColecao = new SubModulo.SubModuloColecao();
                            subModuloColecao.GetSubModulo(pa.Perfil.IdPerfil, am.ProdutoModulo.Modulo.IdModulo);
                            try
                            {
                                secondXPTO = subModuloColecao.GetEnumerator();
                                while (secondXPTO.MoveNext())
                                {
                                    SubModulo sm = (SubModulo) secondXPTO.Current;
                                    itemMenu.ItemSubMenuColecao.Add(new HorizontalMenu.ItemMenu(sm.Descricao, sm.Pagina + "?p=" + parametro, string.Empty));
                                }
                            }
                            finally
                            {
                                //if (secondXPTO is IDisposable)
                                //{
                                //    (secondXPTO as IDisposable).Dispose();
                                //}
                            }
                            horizontalMenu.ItemMenuCol.Add(itemMenu);
                        }
                    }
                }
                finally
                {
                    //if (firstXPTO is IDisposable)
                    //{
                    //    (firstXPTO as IDisposable).Dispose();
                    //}
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                ProjectData.ClearProjectError();
            }
            this.Session["MENU"] = horizontalMenu.MontarMenuHtml();
            return this.Session["MENU"].ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (this.Session["MENU"] != null)
                {
                    this.lblMenu.Text = this.Session["MENU"].ToString();
                }
                else
                {
                    this.lblMenu.Text = this.GetMenuAplicacao();
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
    }
}

