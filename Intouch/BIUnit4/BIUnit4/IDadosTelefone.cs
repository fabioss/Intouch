namespace BIUnit4
{
    using System;

    public interface IDadosTelefone
    {
        int InserirNovoTelefonePf(int idLogin, string idUnit, int idStatus, string ddd, string tel);
        int InserirNovoTelefonePj(int idLogin, string idUnitPj, int idStatus, string ddd, string tel);
    }
}

