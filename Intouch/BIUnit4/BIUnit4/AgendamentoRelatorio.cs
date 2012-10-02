namespace BIUnit4
{
    using System;
    using System.Collections;
    using System.Data;
    using System.Reflection;
    using System.Text;

    public class AgendamentoRelatorio : IAgendamentoRelatorio
    {
        private string _comando;
        private string _comando2;
        private string _dtFim;
        private string _dtInicio;
        private DateTime _dtSolicitacao;
        private bool _fgOk;
        private bool _fgRelatorioDetalhado;
        private int _id;
        private int _idClienteSolicitante;
        private string _loginSolicitante;
        private string _nomeCliente;
        private string _nomeUsuario;
        private string _opcoesUsuario;
        private string _relatorio;
        private string _tipo;

        DataTable IAgendamentoRelatorio.GetAgendamentoRelatorioByCliente(int idCliente)
        {
            return DbIntouch.ExecuteDataTable("[BIINTOUCH.GETAGENDAMENTORELATORIO_BY_CLIENTE] " + idCliente.ToString());
        }

        string IAgendamentoRelatorio.GetComandoRelatorio(string dataInicio, string dataFim, string idCliente, string idLogin, string tipo, int opcoesUsuario)
        {
            return ("[BIINTOUCH.RELATORIO_MONITORAMENTO_INTOUCH] ''" + dataInicio + "'',''" + dataFim + "''," + idCliente + "," + idLogin + "," + tipo + "," + opcoesUsuario.ToString());
        }

        string IAgendamentoRelatorio.GetComandoRelatorioExcel(string idCliente, string idUsuario, string dtInicio, string dtFim)
        {
            return ("[BIINTOUCH.RELATORIO_DETALHADO] " + idCliente + "," + idUsuario + ",''" + dtInicio + "'',''" + dtFim + "''");
        }

        string IAgendamentoRelatorio.GetComandoRelatorioRevenda(string dataInicio, string dataFim, string idsCliente, string tipo, int opcoesUsuario)
        {
            return ("[BIINTOUCH.RELATORIO_MONITORAMENTO_INTOUCH_REVENDA] ''" + dataInicio + "'',''" + dataFim + "'','" + idsCliente + "'," + tipo + "," + opcoesUsuario.ToString());
        }

        string IAgendamentoRelatorio.GetComandoRelatorioRevendaExcel(string idsCliente, string dtInicio, string dtFim)
        {
            return ("[BIINTOUCH.RELATORIO_DETALHADO_REVENDA] '" + idsCliente + "',''" + dtInicio + "'',''" + dtFim + "''");
        }

        DataTable IAgendamentoRelatorio.GetRelatorio(string tabela)
        {
            return DbIntouch.ExecuteDataTable("[BINTOUCH.GETRELATORIO] " + tabela);
        }

        DataTable IAgendamentoRelatorio.GetTotalConsultaClienteRelatorio(string tabela)
        {
            return DbIntouch.ExecuteDataTable("[BIINTOUCH.GETTOTALCONSULTA_CLIENTERELATORIO] '" + tabela + "'");
        }

        void IAgendamentoRelatorio.Inserir(AgendamentoRelatorio agendamento)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(" [BIINTOUCH.CRIAR_AGENDAMENTORELATORIO] ");
            builder.Append("    " + agendamento._idClienteSolicitante.ToString());
            builder.Append("    ,'" + agendamento._loginSolicitante + "'");
            builder.Append("    ,'" + agendamento._dtInicio + "'");
            builder.Append("    ,'" + agendamento._dtFim + "'");
            builder.Append("    ,'" + agendamento._nomeCliente + "'");
            builder.Append("    ,'" + agendamento._nomeUsuario + "'");
            builder.Append("    ,'" + agendamento._tipo + "'");
            builder.Append("    ,'" + agendamento._opcoesUsuario + "'");
            builder.Append("    ,'" + agendamento._comando + "'");
            builder.Append("    ,'" + agendamento._comando2 + "'");
            builder.Append("    ,'" + agendamento._relatorio + "'");
            builder.Append("    ,'" + DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss") + "'");
            builder.Append("    ," + Convert.ToInt32(agendamento._fgRelatorioDetalhado).ToString());
            builder.Append("    ," + Convert.ToInt32(agendamento._fgOk).ToString());
            DbIntouch.ExecuteNonQuery(builder.ToString());
        }

        public static DataTable GetAgendamentoRelatorioByCliente(int idCliente)
        {
            return DbIntouch.ExecuteDataTable("[BIINTOUCH.GETAGENDAMENTORELATORIO_BY_CLIENTE] " + idCliente.ToString());
        }

        string IAgendamentoRelatorio.Comando
        {
            get
            {
                return this._comando;
            }
            set
            {
                this._comando = value;
            }
        }

        string IAgendamentoRelatorio.Comando2
        {
            get
            {
                return this._comando2;
            }
            set
            {
                this._comando2 = value;
            }
        }

        string IAgendamentoRelatorio.DtFim
        {
            get
            {
                return this._dtFim;
            }
            set
            {
                this._dtFim = value;
            }
        }

        string IAgendamentoRelatorio.DtInicio
        {
            get
            {
                return this._dtInicio;
            }
            set
            {
                this._dtInicio = value;
            }
        }

        DateTime IAgendamentoRelatorio.DtSolicitacao
        {
            get
            {
                return this._dtSolicitacao;
            }
            set
            {
                this._dtSolicitacao = value;
            }
        }

        bool IAgendamentoRelatorio.FgOk
        {
            get
            {
                return this._fgOk;
            }
            set
            {
                this._fgOk = value;
            }
        }

        bool IAgendamentoRelatorio.FgRelatorioDetalhado
        {
            get
            {
                return this._fgRelatorioDetalhado;
            }
            set
            {
                this._fgRelatorioDetalhado = value;
            }
        }

        int IAgendamentoRelatorio.Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        int IAgendamentoRelatorio.idClienteSolicitante
        {
            get
            {
                return this._idClienteSolicitante;
            }
            set
            {
                this._idClienteSolicitante = value;
            }
        }

        string IAgendamentoRelatorio.LoginSolicitante
        {
            get
            {
                return this._loginSolicitante;
            }
            set
            {
                this._loginSolicitante = value;
            }
        }

        string IAgendamentoRelatorio.NomeCliente
        {
            get
            {
                return this._nomeCliente;
            }
            set
            {
                this._nomeCliente = value;
            }
        }

        string IAgendamentoRelatorio.NomeUsuario
        {
            get
            {
                return this._nomeUsuario;
            }
            set
            {
                this._nomeUsuario = value;
            }
        }

        string IAgendamentoRelatorio.OpcoesUsuario
        {
            get
            {
                return this._opcoesUsuario;
            }
            set
            {
                this._opcoesUsuario = value;
            }
        }

        string IAgendamentoRelatorio.Relatorio
        {
            get
            {
                return this._relatorio;
            }
            set
            {
                this._relatorio = value;
            }
        }

        string IAgendamentoRelatorio.Tipo
        {
            get
            {
                return this._tipo;
            }
            set
            {
                this._tipo = value;
            }
        }

        public class AgendamentoRelatorioColecao : CollectionBase
        {
            public int Add(AgendamentoRelatorio objAgendamentoRelatorio)
            {
                return base.List.Add(objAgendamentoRelatorio);
            }

            public bool Contains(AgendamentoRelatorio obj)
            {
                return base.List.Contains(obj);
            }

            public AgendamentoRelatorio.AgendamentoRelatorioColecao GetAgendamentoRelatorio(int idCliente)
            {
                AgendamentoRelatorio relatorio = null;
                foreach (DataRow row in AgendamentoRelatorio.GetAgendamentoRelatorioByCliente(idCliente).Rows)
                {
                    relatorio = new AgendamentoRelatorio {
                        _id = (int) row["ID"],
                        _idClienteSolicitante = (int) row["ID_CLIENTE_SOLICITANTE"],
                        _loginSolicitante = row["LOGIN_SOLICITANTE"].ToString(),
                        _dtInicio = row["DT_INICIO"].ToString(),
                        _dtFim = row["DT_FIM"].ToString(),
                        _nomeCliente = row["NOMECLIENTE"].ToString(),
                        _nomeUsuario = row["NOMEUSUARIO"].ToString(),
                        _tipo = row["TIPO"].ToString(),
                        _opcoesUsuario = row["OPCOES_USUARIO"].ToString(),
                        _comando = row["COMANDO"].ToString(),
                        _comando2 = row["COMANDO2"].ToString(),
                        _relatorio = row["RELATORIO"].ToString(),
                        _dtSolicitacao = Convert.ToDateTime(row["DT_SOLICITACAO"]),
                        _fgRelatorioDetalhado = (bool) row["FG_RELATORIO_DETALHADO"],
                        _fgOk = (bool) row["FG_OK"]
                    };
                    base.List.Add(relatorio);
                }
                return ((base.List.Count == 0) ? null : ((AgendamentoRelatorio.AgendamentoRelatorioColecao) base.List));
            }

            public AgendamentoRelatorio GetItem(int id)
            {
                foreach (AgendamentoRelatorio relatorio in base.List)
                {
                    if (relatorio._id == id)
                    {
                        return relatorio;
                    }
                }
                return null;
            }

            public void Insert(int index, AgendamentoRelatorio obj)
            {
                base.List.Insert(index, obj);
            }

            public void Remove(AgendamentoRelatorio obj)
            {
                base.List.Remove(obj);
            }

            public AgendamentoRelatorio this[int index]
            {
                get
                {
                    return (AgendamentoRelatorio) base.List[index];
                }
                set
                {
                    base.List[index] = value;
                }
            }
        }
    }
}

