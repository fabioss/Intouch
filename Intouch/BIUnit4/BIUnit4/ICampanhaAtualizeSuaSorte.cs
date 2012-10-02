namespace BIUnit4
{
    using System;
    using System.Data;

    public interface ICampanhaAtualizeSuaSorte
    {
        bool CPFParticipanteValido(string CPFParticipante);
        DataTable InformacoesParticipanteCampanha(string CPFParticipante);
        string PontuarCampanha(string CPFParticipante, EnumTipoInformacao enumTipoInformacao, int identificadorInformacao);
    }
}

