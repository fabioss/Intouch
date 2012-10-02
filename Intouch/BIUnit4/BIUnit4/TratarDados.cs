namespace BIUnit4
{
    using System;
    using System.Text;

    public class TratarDados : AbstractError, ITratarDados
    {
        string ITratarDados.TratarEndereco(string endereco, string numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format("SELECT DATAFOURLIB2010.DBO.FN_TRATA_ENDERECO('{0}', '{1}', '{2}', '{3}', '{4}')", new object[] { endereco + " " + numero + " " + complemento, bairro, cidade, estado, cep }));
            return DbIntouch.ExecuteScalar(builder.ToString());
        }
    }
}

