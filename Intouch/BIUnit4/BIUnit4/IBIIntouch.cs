namespace BIUnit4
{
    public interface IBIIntouch
    {
        IAgendamentoRelatorio AgendamentoRelatorio { get; }

        ICampanhaAtualizeSuaSorte CampanhaAtualizeSuaSorte { get; }

        IConsulta Consulta { get; }

        IDadosEmpresa DadosEmpresa { get; }

        IDadosTelefone DadosTelefone { get; }

        IHistoricoLogin HistoricoLogin { get; }

        ITratarDados TratarDados { get; }
    }
}

