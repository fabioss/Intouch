namespace Intouch
{
    using System;

    public class SPC_CPF_CHEQUE
    {
        private short _banco;
        private int _codAlinea;
        private string _dscAlinea;
        private DateTime _dtEmissao;
        private string _nmAssociado;
        private string _nmEntidade;
        private short _numAgencia;
        private int _numCheque;
        private string _numCtaCorrente;
        private string _origem;
        private decimal _valorCheque;

        public short Banco
        {
            get
            {
                return this._banco;
            }
            set
            {
                this._banco = value;
            }
        }

        public int CodAlinea
        {
            get
            {
                return this._codAlinea;
            }
            set
            {
                this._codAlinea = value;
            }
        }

        public string DscAlinea
        {
            get
            {
                return this._dscAlinea;
            }
            set
            {
                this._dscAlinea = value;
            }
        }

        public DateTime DtEmissao
        {
            get
            {
                return this._dtEmissao;
            }
            set
            {
                this._dtEmissao = value;
            }
        }

        public string NmAssociado
        {
            get
            {
                return this._nmAssociado;
            }
            set
            {
                this._nmAssociado = value;
            }
        }

        public string NmEntidade
        {
            get
            {
                return this._nmEntidade;
            }
            set
            {
                this._nmEntidade = value;
            }
        }

        public short NumAgencia
        {
            get
            {
                return this._numAgencia;
            }
            set
            {
                this._numAgencia = value;
            }
        }

        public string NumCC
        {
            get
            {
                return this._numCtaCorrente;
            }
            set
            {
                this._numCtaCorrente = value;
            }
        }

        public int NumCheque
        {
            get
            {
                return this._numCheque;
            }
            set
            {
                this._numCheque = value;
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

        public decimal VlCheque
        {
            get
            {
                return this._valorCheque;
            }
            set
            {
                this._valorCheque = value;
            }
        }
    }
}

