namespace BIUnit4
{
    using System;

    public interface IPessoaRestrita
    {
        void InserirInformacoesPessoa(PessoaRestrita pessoaRestrita);

        string Cidade { get; set; }

        string Cpf { get; set; }

        string DataNasc { get; set; }

        string Idade { get; set; }

        string Nome { get; set; }

        string NomeArtistico { get; set; }

        string Uf { get; set; }
    }
}

