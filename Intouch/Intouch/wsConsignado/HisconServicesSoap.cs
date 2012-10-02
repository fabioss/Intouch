namespace Intouch.wsConsignado
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data;
    using System.ServiceModel;

    [GeneratedCode("System.ServiceModel", "3.0.0.0"), ServiceContract(Namespace="http://localhost/HisconServices", ConfigurationName="wsConsignado.HisconServicesSoap")]
    public interface HisconServicesSoap
    {
        [OperationContract(Action="http://localhost/HisconServices/ConsultaProvider_IncluiConsulta", ReplyAction="*"), XmlSerializerFormat]
        DataSet ConsultaProvider_IncluiConsulta(string login, string senha, string cpf, string nb);
        [XmlSerializerFormat, OperationContract(Action="http://localhost/HisconServices/ConsultaProvider_SelecionaConsulta", ReplyAction="*")]
        DataSet ConsultaProvider_SelecionaConsulta(string login, string senha, string codigo);
    }
}

