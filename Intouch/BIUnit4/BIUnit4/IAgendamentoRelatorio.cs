namespace BIUnit4
{
    using System;
    using System.Data;

    public interface IAgendamentoRelatorio
    {
        DataTable GetAgendamentoRelatorioByCliente(int idCliente);
        string GetComandoRelatorio(string dataInicio, string dataFim, string idCliente, string idLogin, string tipo, int opcoesUsuario);
        string GetComandoRelatorioExcel(string idCliente, string idUsuario, string dtInicio, string dtFim);
        string GetComandoRelatorioRevenda(string dataInicio, string dataFim, string idsCliente, string tipo, int opcoesUsuario);
        string GetComandoRelatorioRevendaExcel(string idsCliente, string dtInicio, string dtFim);
        DataTable GetRelatorio(string tabela);
        DataTable GetTotalConsultaClienteRelatorio(string tabela);
        void Inserir(AgendamentoRelatorio agendamento);

        string Comando { get; set; }

        string Comando2 { get; set; }

        string DtFim { get; set; }

        string DtInicio { get; set; }

        DateTime DtSolicitacao { get; set; }

        bool FgOk { get; set; }

        bool FgRelatorioDetalhado { get; set; }

        int Id { get; set; }

        int idClienteSolicitante { get; set; }

        string LoginSolicitante { get; set; }

        string NomeCliente { get; set; }

        string NomeUsuario { get; set; }

        string OpcoesUsuario { get; set; }

        string Relatorio { get; set; }

        string Tipo { get; set; }
    }
}

