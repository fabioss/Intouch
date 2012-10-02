namespace BIUnit4
{
    using System;

    public interface IDadosEmpresa
    {
        int InserirEmpresa(int idStatus, string cpf, string cnpj, string tipo, string pct, string dataEntrada, int idLogin);
    }
}

