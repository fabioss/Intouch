namespace Intouch
{
    using System;

    public class SPC_CNPJ_ENDERECO
    {
        private string _bairro;
        private string _cep;
        private string _cidade;
        private string _complemento;
        private string _logradouro;
        private string _numero;
        private string _uf;

        public string Bairro
        {
            get
            {
                return this._bairro;
            }
            set
            {
                this._bairro = value;
            }
        }

        public string Cep
        {
            get
            {
                return this._cep;
            }
            set
            {
                this._cep = value;
            }
        }

        public string Cidade
        {
            get
            {
                return this._cidade;
            }
            set
            {
                this._cidade = value;
            }
        }

        public string Complemento
        {
            get
            {
                return this._complemento;
            }
            set
            {
                this._complemento = value;
            }
        }

        public string Logradouro
        {
            get
            {
                return this._logradouro;
            }
            set
            {
                this._logradouro = value;
            }
        }

        public string Numero
        {
            get
            {
                return this._numero;
            }
            set
            {
                this._numero = value;
            }
        }

        public string UF
        {
            get
            {
                return this._uf;
            }
            set
            {
                this._uf = value;
            }
        }
    }
}

