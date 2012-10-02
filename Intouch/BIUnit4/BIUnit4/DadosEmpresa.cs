namespace BIUnit4
{
    using System;
    using System.Text;

    public class DadosEmpresa : IDadosEmpresa
    {
        int IDadosEmpresa.InserirEmpresa(int idStatus, string cpf, string cnpj, string tipo, string pct, string dataEntrada, int idLogin)
        {
            int num = 0;
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("[BIINTOUCH.HISTORICO_STATUS_EMPRESAS] ");
                builder.Append("@STATUS = " + idStatus + ",");
                builder.Append("@CPF = '" + cpf + "',");
                builder.Append("@CNPJ = '" + cnpj + "',");
                builder.Append("@TIPO = '" + tipo + "',");
                builder.Append("@PCT = '" + pct + "',");
                builder.Append("@DATA_ENTRADA = '" + dataEntrada + "',");
                builder.Append("@ID_LOGIN = " + idLogin);
                num = Convert.ToInt32(DbIntouch.ExecuteScalar(builder.ToString()));
            }
            catch (Exception)
            {
            }
            return num;
        }
    }
}

