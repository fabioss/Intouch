namespace BIUnit4
{
    using System;
    using System.Data;

    public interface IHistoricoLogin
    {
        DataTable GetHistoricoLogin(int idCliente, int idUsuario);
        DataTable GetLogUsuario(int idCliente, string acao, string dataInicio, string dataFim);
        int InserirHistoricoLogin(int idCliente, int idUsuario, string Ip);
    }
}

