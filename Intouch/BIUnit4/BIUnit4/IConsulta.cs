namespace BIUnit4
{
    using DllPainelDeControle;
    using System;
    using System.Data;

    public interface IConsulta
    {
        bool AutorizadoParaConsultar(string usuario, string Ip, string senha, string cliente, EnumProduto produto, ref int idLogin);
        DataTable BuscaApresentacao(string tipoPessoa, string nome, string dataInicial, string dataFinal, string idadeInicial, string idadeFinal, string endereco, string numero, string complemento, string bairro, string cidade, string uf, string cep, string ddd, string telefone);
        DataTable CarregaDadosMae(string idUnit);
        DataSet CarregaDadosPf(string idUnit, bool filtroProcon);
        DataSet CarregaDadosPj(string idUnit, bool filtroProcon);
        DataTable CarregaEmpresasLigadas(string idUnitPj, Usuario usuario, int idHistoricoLogin);
        DataTable CarregarDadosComerciasPf(string cpf);
        DataTable CarregarDadosComerciasPj(string cnpj);
        DataTable CarregarPessoasLigadas(string idPessoa, string ultimoNome, Usuario usuario, int idHistoricoLogin);
        void CobrarConsulta(Usuario usuario, string intIdPessoa, int intTipoConsulta, int idHistoricoLogin);
        DataTable GetCcf(string cpf_cnpj);
        string GetIdUnit(string documento);
        DataTable GetMaisTelefone(string idUnit, string tipoPessoa);
        DataTable GetPerfil(string cpf_cnpj);
        DataTable GetPerfilConsumo(string cpf);
        string GetTipoDocumento(string documento);
        DataTable GetVeiculo(string cpf_cnpj);
        int InserirInformacoesPf(string cpf, string nome, string sexo, string dataNasc, string idade, string estadoCivil, string nomeMae, int idUnit, int idLogin, bool obito);
        int InserirInformacoesPj(string cnpj, string razao, string nomeFantasia, string dataAbertura, string cnae, string qtdFuncionarios, string situacao, string njur, string porte, string qtdProprietarios, int idUnit, int idLogin);
        int InserirNovoEmailPf(string email, bool particular, int idStatus, int idUnit, int idLogin);
        int InserirNovoEmailPj(string email, bool particular, int idStatus, int idUnitPj, int idLogin);
        int InserirNovoEndereco(string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string cep, int idStatus, int idUnit, int idLogin, int hEndId, int tipoConsulta, int origem, int idCliente);
        DataSet LocalizarPessoaMarcondes(string[] opcoesAvancadas, bool filtroProcon);
        DataTable LocalizaVizinhos(string idUnit, string tipoPessoa, string melhorcep);
    }
}

