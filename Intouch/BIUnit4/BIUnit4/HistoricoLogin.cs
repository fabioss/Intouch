namespace BIUnit4
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;

    public class HistoricoLogin : IHistoricoLogin
    {
        DataTable IHistoricoLogin.GetHistoricoLogin(int idCliente, int idUsuario)
        {
            DataTable table = new DataTable();
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.AppendLine("[BIINTOUCH.GETHISTORICOLOGIN] " + idCliente.ToString() + "," + idUsuario.ToString() + ")");
                table = DbIntouch.ExecuteDataTable(builder.ToString());
            }
            catch (Exception)
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                Dictionary<string, string> dictionary2 = dictionary;
                dictionary2.Add("idCliente", idCliente.ToString());
                dictionary2.Add("idUsuario", idUsuario.ToString());
            }
            return table;
        }

        DataTable IHistoricoLogin.GetLogUsuario(int idCliente, string acao, string dataInicio, string dataFim)
        {
            DataTable table = new DataTable();
            StringBuilder builder = new StringBuilder();
            try
            {
                table = DbIntouch.ExecuteDataTable("[BIINTOUCH.LOGUSUARIO] @ID_CLIENTE = " + idCliente.ToString() + ", @ACAO = " + acao + ", @DATA_INICIO = '" + dataInicio + "', @DATA_FIM = '" + dataFim + "'");
            }
            catch (Exception)
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                Dictionary<string, string> dictionary2 = dictionary;
                dictionary2.Add("idCliente", idCliente.ToString());
                dictionary2.Add("acao", acao.ToString());
                dictionary2.Add("dataInicio", dataInicio.ToString());
                dictionary2.Add("dataFim", dataFim.ToString());
            }
            return table;
        }

        int IHistoricoLogin.InserirHistoricoLogin(int idCliente, int idUsuario, string Ip)
        {
            DataTable table = new DataTable();
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.Append("[BIINTOUCH.CRIARHISTORICOLOGIN] ");
                builder.Append(idCliente.ToString() + ",");
                builder.Append(idUsuario.ToString() + ",");
                builder.Append("'" + Ip + "'");
            }
            catch (Exception)
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                Dictionary<string, string> dictionary2 = dictionary;
                dictionary2.Add("idCliente", idCliente.ToString());
                dictionary2.Add("idUsuario", idUsuario.ToString());
                dictionary2.Add("idUsuario", idUsuario.ToString());
            }
            return Convert.ToInt32(DbIntouch.ExecuteScalar(builder.ToString()));
        }
    }
}

