namespace BIUnit4
{
    using Microsoft.ApplicationBlocks.Data;
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;

    public class CampanhaAtualizeSuaSorte : ICampanhaAtualizeSuaSorte
    {
        bool ICampanhaAtualizeSuaSorte.CPFParticipanteValido(string CPFParticipante)
        {
            bool flag = false;
            try
            {
                flag = Convert.ToBoolean(Convert.ToInt32(DbIntouch.ExecuteScalar("[BIINTOUCH.VALIDACAO_CPF_PARTICIPANTE_CAMPANHA_ATUALIZE_SUA_SORTE] @CPF_PARTICIPANTE='" + CPFParticipante + "' ")));
            }
            catch (Exception)
            {
            }
            return flag;
        }

        DataTable ICampanhaAtualizeSuaSorte.InformacoesParticipanteCampanha(string CPFParticipante)
        {
            DataTable table = new DataTable();
            try
            {
                string str = this.ExecuteScalar("[PR_GET_INFORMACOES_PARTICIPANTE_CAMPANHA_ATUALIZE_SUA_SORTE] @CPF = '" + CPFParticipante + "'");
                string str2 = DbIntouch.ExecuteScalar("[BIINTOUCH.GET_QTD_PONTOS_CAMPANHA_ATUALIZE_SUA_SORTE] @CPF_PARTICIPANTE = '" + CPFParticipante + "'");
                table.Columns.Add("NOME_PARTICIPANTE");
                table.Columns.Add("QTD_CUPOM");
                DataRow row = table.NewRow();
                row["NOME_PARTICIPANTE"] = str;
                row["QTD_CUPOM"] = str2;
                table.Rows.Add(row);
            }
            catch (Exception)
            {
            }
            return table;
        }

        string ICampanhaAtualizeSuaSorte.PontuarCampanha(string CPFParticipante, EnumTipoInformacao enumTipoInformacao, int identificadorInformacao)
        {
            string str = string.Empty;
            try
            {
                string str2 = this.ExecuteScalar("[PR_GET_RASPADINHA]  ");
                StringBuilder builder = new StringBuilder();
                builder.Append("[BIINTOUCH.INSERIR_PONTOS_CAMPANHA_ATUALIZE_SUA_SORTE] ");
                builder.Append("@CPF_PARTICIPANTE='" + CPFParticipante + "',");
                builder.Append("@ID_TIPO_INFORMACAO=" + ((int) enumTipoInformacao) + ",");
                builder.Append("@IDENTIFICADOR_INFORMACAO=" + identificadorInformacao + ",");
                builder.Append("@CODIGO_RASPADINHA='" + str2 + "'");
                DbIntouch.ExecuteNonQuery(builder.ToString());
                str = DbIntouch.ExecuteScalar("[BIINTOUCH.GET_QTD_PONTOS_CAMPANHA_ATUALIZE_SUA_SORTE] @CPF_PARTICIPANTE = '" + CPFParticipante + "'");
            }
            catch (Exception)
            {
            }
            return str;
        }

        private string ExecuteScalar(string cmd)
        {
            SqlConnection connection = new SqlConnection(Cript_Decript.DeCifra(ConfigurationManager.ConnectionStrings["CONEXAO.ATUALIZE_SUA_SORTE"].ConnectionString));
            DataTable table = new DataTable();
            string str2 = SqlHelper.ExecuteScalar(connection, CommandType.Text, cmd).ToString();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return str2;
        }
    }
}

