namespace Intouch
{
    using System;

    public class SPC_CPF_ConsultaRealizada
    {
        private DateTime _dataConsulta;
        private DateTime _dataultimaocorrencia;
        private string _nomeAssociado;
        private string _nomeEntidade;
        private string _origem;
        private int _quantidadediasconsultados;
        private int _quantidadetotal;

        public DateTime DataConsulta
        {
            get
            {
                return this._dataConsulta;
            }
            set
            {
                this._dataConsulta = value;
            }
        }

        public DateTime DataUltimaOcorrencia
        {
            get
            {
                return this._dataultimaocorrencia;
            }
            set
            {
                this._dataultimaocorrencia = value;
            }
        }

        public string NomeAssociado
        {
            get
            {
                return this._nomeAssociado;
            }
            set
            {
                this._nomeAssociado = value;
            }
        }

        public string NomeEntidade
        {
            get
            {
                return this._nomeEntidade;
            }
            set
            {
                this._nomeEntidade = value;
            }
        }

        public string Origem
        {
            get
            {
                return this._origem;
            }
            set
            {
                this._origem = value;
            }
        }

        public int QuantidadeDiasConsultados
        {
            get
            {
                return this._quantidadediasconsultados;
            }
            set
            {
                this._quantidadediasconsultados = value;
            }
        }

        public int QuantidadeTotal
        {
            get
            {
                return this._quantidadetotal;
            }
            set
            {
                this._quantidadetotal = value;
            }
        }
    }
}

