namespace BIUnit4
{
    using DllPainelDeControle;
    using System;
    using System.Configuration;
    using System.IO;
    using System.IO.Compression;
    using System.Text;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public class GlobalPage : Page
    {
        public GlobalPage()
        {
            base.Error += new EventHandler(this.Page_Error);
        }

        public static byte[] CompactarViewState(byte[] bytes)
        {
            MemoryStream stream = new MemoryStream();
            GZipStream stream2 = new GZipStream(stream, CompressionMode.Compress, true);
            stream2.Write(bytes, 0, bytes.Length);
            stream2.Close();
            return stream.ToArray();
        }

        public static byte[] DescompactarViewState(byte[] bytes)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Position = 0L;
            GZipStream stream2 = new GZipStream(stream, CompressionMode.Decompress, true);
            MemoryStream stream3 = new MemoryStream();
            byte[] buffer = new byte[0x40];
            int count = -1;
            for (count = stream2.Read(buffer, 0, buffer.Length); count > 0; count = stream2.Read(buffer, 0, buffer.Length))
            {
                stream3.Write(buffer, 0, count);
            }
            stream2.Close();
            return stream3.ToArray();
        }

        public static bool IsSessionExpired()
        {
            if ((HttpContext.Current.Session != null) && HttpContext.Current.Session.IsNewSession)
            {
                string str = HttpContext.Current.Request.Headers["Cookie"];
                if ((str != null) && (str.IndexOf("ASP.NET_SessionId") >= 0))
                {
                    return true;
                }
            }
            return false;
        }

        public static string MsgErro(string cliente, string usuario, string aplicacao, string classe, string metodo, string excecao, string rastreamentoPilha, ControlCollection controlesPagina)
        {
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.AppendLine("<center>");
                builder.AppendLine("<b>Data do Erro:</b> " + DateTime.Now.ToString() + "<br>");
                builder.AppendLine("<b>Cliente:</b> " + cliente.ToUpper() + "<br>");
                builder.AppendLine("<b>Usu\x00e1rio:</b> " + usuario.ToUpper() + "<br>");
                builder.AppendLine("<b>Aplica\x00e7\x00e3o:</b> " + aplicacao.ToUpper() + "<br>");
                builder.AppendLine("<b>Classe:</b> " + classe.ToUpper() + "<br>");
                builder.AppendLine("<b>M\x00e9todo:</b> " + metodo.ToUpper() + "<br><br>");
                builder.AppendLine("<b>Mensagem de Exce\x00e7\x00e3o: </b><i><font color='red'>" + excecao + "</font><br><br>");
                builder.AppendLine("<b>Rastreamento de Pilha: <font color='red'>" + rastreamentoPilha + "</font></b>");
                builder.AppendLine("<br><br>");
                builder.AppendLine("");
                builder.AppendLine("================================ Controles da P\x00e1gina para Poss\x00edveis Testes =============<br><br>");
                foreach (object obj2 in controlesPagina)
                {
                    string fullName = obj2.GetType().FullName;
                    switch (fullName)
                    {
                        case "System.Web.UI.WebControls.TextBox":
                            builder.AppendLine("<b>Controle:</b> " + ((TextBox) obj2).ID.ToString() + "<br>");
                            builder.AppendLine("<b>Valor:</b> " + ((TextBox) obj2).Text.ToString() + "<br><br>");
                            break;

                        case "System.Web.UI.WebControls.CheckBox":
                            builder.AppendLine("<b>Controle:</b> " + ((CheckBox) obj2).ID.ToString() + "<br>");
                            builder.AppendLine("<b>Valor:</b> " + ((CheckBox) obj2).Checked.ToString() + "<br><br>");
                            break;

                        case "System.Web.UI.WebControls.CheckBoxList":
                            foreach (CheckBox box in ((CheckBoxList) obj2).Items)
                            {
                                if (box.Checked)
                                {
                                    builder.AppendLine("<b>Controle:</b> " + box.ID.ToString() + "<br>");
                                    builder.AppendLine("<b>Valor:</b> " + box.Checked.ToString() + "<br><br>");
                                }
                            }
                            break;

                        case "System.Web.UI.WebControls.RadioButton":
                            builder.AppendLine("<b>Controle:</b> " + ((RadioButton) obj2).ID.ToString() + "<br>");
                            builder.AppendLine("<b>Valor:</b> " + ((RadioButton) obj2).Checked.ToString() + "<br><br>");
                            break;

                        case "System.Web.UI.WebControls.RadioButtonList":
                            foreach (RadioButton button in ((RadioButtonList) obj2).Items)
                            {
                                if (button.Checked)
                                {
                                    builder.AppendLine("<b>Controle:</b> " + button.ID.ToString() + "<br>");
                                    builder.AppendLine("<b>Valor:</b> " + button.Checked.ToString() + "<br><br>");
                                }
                            }
                            break;

                        case "System.Web.UI.WebControls.ListBox":
                            builder.AppendLine("<b>Controle:</b> " + ((ListBox) obj2).ID.ToString() + "<br>");
                            builder.AppendLine("<b>Valor:</b> " + ((ListBox) obj2).SelectedItem.ToString() + "<br><br>");
                            break;

                        case "System.Web.UI.WebControls.DropDownList":
                            builder.AppendLine("<b>Controle:</b> " + ((DropDownList) obj2).ID.ToString() + "<br>");
                            builder.AppendLine("<b>Valor:</b> " + ((DropDownList) obj2).SelectedItem.ToString() + "<br><br>");
                            break;

                        case "System.Web.UI.WebControls.DataGrid":
                            builder.AppendLine("<b>Controle:</b><u>" + ((DataGrid) obj2).ID.ToString() + "</u><br>");
                            builder.AppendLine("<table border=1>");
                            builder.AppendLine("<tr>");
                            foreach (DataGridColumn column in ((DataGrid) obj2).Columns)
                            {
                                builder.AppendLine("<td><b>" + column.HeaderText.ToUpper() + "</b></td>");
                            }
                            builder.AppendLine("</tr>");
                            foreach (DataGridItem item in ((DataGrid) obj2).Items)
                            {
                                builder.AppendLine("<tr>");
                                foreach (TableCell cell in item.Cells)
                                {
                                    if (cell.Controls.Count > 0)
                                    {
                                        foreach (Control control in cell.Controls)
                                        {
                                            fullName = control.ToString();
                                            if ((fullName != null) && (fullName == "System.Web.UI.WebControls.LinkButton"))
                                            {
                                                builder.AppendLine("<td>" + ((LinkButton) control).Text + "</td>");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        builder.AppendLine("<td>" + cell.Text + "</td>");
                                    }
                                }
                                builder.AppendLine("</tr>");
                            }
                            builder.AppendLine("</table><br><br>");
                            break;
                    }
                }
                builder.AppendLine("==================================================================================");
                builder.AppendLine("</center>");
            }
            catch (Exception)
            {
            }
            return builder.ToString();
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            try
            {
                if (ConfigurationManager.AppSettings["MANDAR_EMAIL_ERRO"].ToString() == "SIM")
                {
                    Exception baseException = base.Server.GetLastError().GetBaseException();
                    Mail mail = new Mail();
                    Mail mail2 = mail;
                    mail2.servidorSaida = "smtp.unitfour.com.br";
                    mail2.titulo = string.Format("Erro na aplica\x00e7\x00e3o {0}", ConfigurationManager.AppSettings["APP_NAME"].ToString());
                    mail2.isHTML = true;
                    mail2.mailDestinatario = "intouch.erros@unitfour.com.br";
                    mail2.mailRemetente = "desenvolvimento@unitfour.com.br";
                    mail2.corpoMensagem = baseException.Message.ToString();
                    mail.EnviarEmail();
                }
            }
            catch (Exception)
            {
            }
        }

        public static bool PodeAcessarPagina(Acesso acesso, string paginaAcesso)
        {
            if (acesso == null)
            {
                return false;
            }
            acesso.PaginaAtual = paginaAcesso;
            return acesso.PodeVisualizarModulo();
        }
    }
}

