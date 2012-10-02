namespace BIUnit4
{
    using System;
    using System.Text;

    public class DadosTelefone : IDadosTelefone
    {
        int IDadosTelefone.InserirNovoTelefonePf(int idLogin, string idUnit, int idStatus, string ddd, string tel)
        {
            int num = 0;
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("[BIINTOUCH.INSERIRNOVOTELEFONEPF] ");
                builder.Append("@ID_LOGIN = " + idLogin + ",");
                builder.Append("@ID_UNIT = " + idUnit + ",");
                builder.Append("@DDD = '" + ddd + "',");
                builder.Append("@TELEFONE = '" + tel + "',");
                builder.Append("@STATUS = " + idStatus);
                num = Convert.ToInt32(DbIntouch.ExecuteScalar(builder.ToString()));
            }
            catch (Exception)
            {
            }
            return num;
        }

        int IDadosTelefone.InserirNovoTelefonePj(int idLogin, string idUnitPj, int idStatus, string ddd, string tel)
        {
            int num = 0;
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("UNITEMPRESAS..[BIINTOUCH.INSERIRNOVOTELEFONEPJ] ");
                builder.Append("@ID_LOGIN = " + idLogin + ",");
                builder.Append("@ID_UNIT_PJ = " + idUnitPj + ",");
                builder.Append("@DDD = '" + ddd + "',");
                builder.Append("@TELEFONE = '" + tel + "',");
                builder.Append("@STATUS = " + idStatus);
                num = Convert.ToInt32(DbIntouch.ExecuteScalar(builder.ToString()));
            }
            catch (Exception)
            {
            }
            return num;
        }
    }
}

