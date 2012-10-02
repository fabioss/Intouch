namespace BIUnit4
{
    using System;

    public class BIIntouch : IBIIntouch
    {
        private AgendamentoRelatorio _AgendamentoRelatorio;
        private CampanhaAtualizeSuaSorte _CampanhaAtualizeSuaSorte;
        private Consulta _Consulta;
        private IDadosEmpresa _DadosEmpresa;
        private IDadosTelefone _DadosTelefone;
        private HistoricoLogin _HistoricoLogin;
        private TratarDados _TratarDados;

        IAgendamentoRelatorio IBIIntouch.AgendamentoRelatorio
        {
            get
            {
                if (this._AgendamentoRelatorio == null)
                {
                    this._AgendamentoRelatorio = new AgendamentoRelatorio();
                }
                return this._AgendamentoRelatorio;
            }
        }

        ICampanhaAtualizeSuaSorte IBIIntouch.CampanhaAtualizeSuaSorte
        {
            get
            {
                if (this._CampanhaAtualizeSuaSorte == null)
                {
                    this._CampanhaAtualizeSuaSorte = new CampanhaAtualizeSuaSorte();
                }
                return this._CampanhaAtualizeSuaSorte;
            }
        }

        IConsulta IBIIntouch.Consulta
        {
            get
            {
                if (this._Consulta == null)
                {
                    this._Consulta = new Consulta();
                }
                return this._Consulta;
            }
        }

        IDadosEmpresa IBIIntouch.DadosEmpresa
        {
            get
            {
                if (this._DadosEmpresa == null)
                {
                    this._DadosEmpresa = new DadosEmpresa();
                }
                return this._DadosEmpresa;
            }
        }

        IDadosTelefone IBIIntouch.DadosTelefone
        {
            get
            {
                if (this._DadosTelefone == null)
                {
                    this._DadosTelefone = new DadosTelefone();
                }
                return this._DadosTelefone;
            }
        }

        IHistoricoLogin IBIIntouch.HistoricoLogin
        {
            get
            {
                if (this._HistoricoLogin == null)
                {
                    this._HistoricoLogin = new HistoricoLogin();
                }
                return this._HistoricoLogin;
            }
        }

        ITratarDados IBIIntouch.TratarDados
        {
            get
            {
                if (this._TratarDados == null)
                {
                    this._TratarDados = new TratarDados();
                }
                return this._TratarDados;
            }
        }
    }
}

