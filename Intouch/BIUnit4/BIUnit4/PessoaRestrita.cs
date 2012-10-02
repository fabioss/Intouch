namespace BIUnit4
{
    using System;
    using System.Text;

    public class PessoaRestrita : IPessoaRestrita
    {
        private string _cidade;
        private string _cpf;
        private string _dataNasc;
        private string _idade;
        private string _nome;
        private string _nomeArtistico;
        private string _uf;

        public PessoaRestrita(string nomeArtistico, string nome, string cpf, string dataNasc, string idade, string uf, string cidade)
        {
            this._nomeArtistico = nomeArtistico;
            this._nome = nome;
            this._cpf = cpf;
            this._dataNasc = dataNasc;
            this._idade = idade;
            this._uf = uf;
            this._cidade = cidade;
        }

        void IPessoaRestrita.InserirInformacoesPessoa(PessoaRestrita pessoaRestrita)
        {
            StringBuilder builder = new StringBuilder();
            try
            {
                builder.Append("[BIINTOUCH.INSERE_PESSOAS_RESTRITAS] ");
                builder.Append("@NOMEART ='" + pessoaRestrita._nomeArtistico + "', ");
                builder.Append("@NOME = '" + pessoaRestrita._nome + "',");
                builder.Append("@CPF = '" + pessoaRestrita._cpf + "',");
                builder.Append("@DATANASCIMENTO ='" + pessoaRestrita._dataNasc + "', ");
                builder.Append("@IDADE = '" + pessoaRestrita._idade + "', ");
                builder.Append("@ESTADO ='" + pessoaRestrita._uf + "', ");
                builder.Append("@CIDADE ='" + pessoaRestrita._cidade + "'");
                DbIntouch.ExecuteNonQuery(builder.ToString());
            }
            catch (Exception)
            {
            }
        }

        string IPessoaRestrita.Cidade
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

        string IPessoaRestrita.Cpf
        {
            get
            {
                return this._cpf;
            }
            set
            {
                this._cpf = value;
            }
        }

        string IPessoaRestrita.DataNasc
        {
            get
            {
                return this._dataNasc;
            }
            set
            {
                this._dataNasc = value;
            }
        }

        string IPessoaRestrita.Idade
        {
            get
            {
                return this._idade;
            }
            set
            {
                this._idade = value;
            }
        }

        string IPessoaRestrita.Nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }

        string IPessoaRestrita.NomeArtistico
        {
            get
            {
                return this._nomeArtistico;
            }
            set
            {
                this._nomeArtistico = value;
            }
        }

        string IPessoaRestrita.Uf
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

