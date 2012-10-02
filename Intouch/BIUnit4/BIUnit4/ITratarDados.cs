namespace BIUnit4
{
    using System;

    public interface ITratarDados
    {
        string TratarEndereco(string endereco, string numero, string complemento, string bairro, string cidade, string estado, string cep);
    }
}

