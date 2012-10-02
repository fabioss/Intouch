namespace Intouch
{
    using System;

    public class SPC_CNPJ_CNAE_PRINCIPAL
    {
        private long _codigo;
        private string _descricao;
        private string _tipo;

        public long Codigo
        {
            get
            {
                return this._codigo;
            }
            set
            {
                this._codigo = value;
            }
        }

        public string Descricao
        {
            get
            {
                return this._descricao;
            }
            set
            {
                this._descricao = value;
            }
        }

        public string Tipo
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
    }
}

