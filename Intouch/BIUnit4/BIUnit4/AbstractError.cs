namespace BIUnit4
{
    using System;

    public abstract class AbstractError
    {
        private string _erro;

        protected AbstractError()
        {
        }

        public string Erro
        {
            get
            {
                return this._erro;
            }
            set
            {
                this._erro = value;
            }
        }
    }
}

